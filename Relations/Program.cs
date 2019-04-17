using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Relations
{
    class Program
    {
        static void Main(string[] args)
        {
            string _conStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
            SqlConnection con = new SqlConnection(_conStr);

            var _sql1 = "SELECT * FROM CLIENTES";
            var _sql2 = "SELECT * FROM CONTATOS";

            var cmd1 = new SqlCommand(_sql1, con);
            var cmd2 = new SqlCommand(_sql2, con);

            var ds = new DataSet("CLIENTES");

            var da1 = new SqlDataAdapter(cmd1); 
            var da2 = new SqlDataAdapter(cmd2);

            da1.Fill(ds, "CLIENTES");
            da2.Fill(ds, "CONTATOS");

            var dtClientes = ds.Tables[0];
            var dtContatos = ds.Tables[1];

            DataRelation relation = ds.Relations.Add(
               "ClientesContatos",
                dtClientes.Columns["IdCliente"],
                dtContatos.Columns["IdCliente"]
                );

            foreach (DataRow cli in dtClientes.Rows)
            {
                Console.WriteLine("Nome Cliente: " + cli[1].ToString().ToUpper());
                foreach (DataRow cont in cli.GetChildRows(relation))
                {
                    Console.WriteLine(cont[1].ToString() + " - " + cont[2].ToString().ToUpper());
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}
