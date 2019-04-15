using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

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

            using (var con = new SqlConnection(ConnectionString))
            {
                Console.WriteLine("String de conexão: " + ConnectionString);
                con.Open();
                Console.WriteLine("Conexão com banco de dados efetuada com sucesso...");
                Console.WriteLine("Estado da conexão " + con.State);
                con.Close();
                Console.WriteLine("Estado da conexão " + con.State);
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
