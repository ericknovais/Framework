using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = @"Data Source=DH\DESENV;Initial Catalog=Cadastro;
                                        User ID=sa;Password=endh";
                                        //Connect Timeout=30;Encrypt=False;
                                        //TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            try
            {
                Console.WriteLine("Conexão com banco de dados efetuada com sucesso...");
                Console.WriteLine("Estado da conexão " + con.State);

            }
            finally
            {
                con.Close();
                Console.WriteLine("Estado da conexão " + con.State);
            }

            Console.ReadKey();
        }
    }
}
