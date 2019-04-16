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
    }
}
