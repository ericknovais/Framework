using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Adapters
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);
            string _sql = "SELECT * FROM CLIENTES";
            SqlCommand cmd = new SqlCommand(_sql, con);
            DataSet ds = new DataSet("Cadastro");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Clientes");
            var dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("IDCliente: " + row[0].ToString());
                Console.WriteLine("NomeCliente: " + row[1].ToString());
                Console.WriteLine("E-mail: " + row[2].ToString());
            }
            dt.WriteXml("dados.xml");

            Console.ReadKey();
        }
    }
}
