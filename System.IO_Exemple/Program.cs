using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("the quick brown fox jumps over the lazy dog");
            sb.Append("Erick Novais da Hora vai sobreescrever o texto já existente");
            File.AppendAllText(@"C:\Users\eri_c\Desktop\teste.txt", sb.ToString());

            string[] values = { "Line 1", "Line 2", "Line 3" };
            File.AppendAllLines(@"C:\Users\eri_c\Desktop\teste2.txt", values);

            File.Delete(@"C:\Users\eri_c\Desktop\teste3.txt");

            File.Copy(@"C:\Users\eri_c\Desktop\teste.txt", @"C:\Users\eri_c\Desktop\teste3.txt");

            //File.Encrypt(@"C:\Users\eri_c\Desktop\teste3.txt");

        }
    }
}
