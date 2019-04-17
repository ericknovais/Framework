using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var conBuilder = getConnectionStringFromConfig();
            var ConStr = conBuilder;
            
        }

        private static string getConnectionStringFromConfig()
        {
            return ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
        }

        private static SqlConnectionStringBuilder getConnectionStringFromBuilder()
        {
            var conBuilder = new SqlConnectionStringBuilder();
            conBuilder.DataSource = @"DH\DESENV";
            conBuilder.InitialCatalog = "Cadastro";
            conBuilder.UserID = "sa";
            conBuilder.Password = "endh";
            return conBuilder;
        }

        private void InserirCliente()
        {
            //string ConnectionString = @"Server = DH\DESENV; Database = Cadastro;
            //User ID = sa; Password = endh";
            //Connect Timeout=30;Encrypt=False;
            //TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var conBuilder = getConnectionStringFromConfig();

            var ConnectionString = conBuilder;

            var con = new SqlConnection(ConnectionString);

            //Entrada de Dados 
            Console.WriteLine("Informe o nome do cliente");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o e-mail do cliente");
            var email = Console.ReadLine();
            //gravação de dados
            //var SQL = "INSERT INTO CLIENTES(NomeCliente,Email) VALUES(@NomeCliente,@Email);";
            var SQL = "InsertCliente";
            var cmd = new SqlCommand(SQL, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NomeCliente", nome);
            cmd.Parameters.AddWithValue("@Email", email);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Registro salvo com sucesso");
                Console.ReadKey();
            }
            finally
            {

                con.Close();
            }

            Console.ReadKey();
        }

        private void Transacoes(string ConStr)
        {
            using (var con = new SqlConnection(ConStr))
            {
                con.Open();
                var trans = con.BeginTransaction();
                try
                {
                    //var sql1 = "INSERT INTO CLIENTES(NomeCliente,Email) VALUES(@NomeCliente,@Email);";
                    var sql2 = "Delete CLIENTES WHERE IDCliente=3";
                    var sql1 = "INSERT INTO CLIENTES(NomeCliente) VALUES(@NomeCliente);";
                    var cmd1 = con.CreateCommand();
                    cmd1.CommandText = sql1;
                    cmd1.Transaction = trans;
                    var cmd2 = con.CreateCommand();
                    cmd2.Transaction = trans;
                    cmd2.CommandText = sql2;
                    cmd1.Parameters.AddWithValue("@NomeCliente", "Erick");
                    cmd1.Parameters.AddWithValue("@Email", "erick.hora@gmail.com");
                    //Executados em uma única trasação
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    //Efetiva operações no DB
                    trans.Commit();
                    Console.WriteLine("Comandos executados com sucesso");
                }
                catch (Exception e)
                {

                    Console.WriteLine("Erro ao executar trasalção");
                    Console.WriteLine(e.GetType());
                    Console.WriteLine(e.Message);

                }
                Console.ReadLine();
            }
        }

        private void SelectTabela(string ConStr)
        {
            using (var con = new SqlConnection(ConStr))
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = "SelecClientesProdutos";
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                // Somente Leitura, sem cache
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//
                //varredura no data reader
                Console.WriteLine("LISTAGEM DE CLIENTES");
                Console.WriteLine("--------------------");
                while (dr.Read())
                {
                    Console.WriteLine("ID: " + dr[0].ToString());
                    Console.WriteLine("Nome: " + dr[1]);
                    Console.WriteLine("E-mail: " + dr[2]);
                    Console.WriteLine("--------------------------------");
                }

                dr.NextResult(); //Posiciona leitor no próximo resultSet
                Console.WriteLine("LISTAGEM DE PRODUTOS");
                Console.WriteLine("--------------------");
                while (dr.Read())
                {
                    Console.WriteLine("ID: " + dr[0].ToString());
                    Console.WriteLine("Nome: " + dr[1]);
                    Console.WriteLine("--------------------------------");
                }
                dr.Close();
                Console.ReadKey();
            }
        }
    }
}
