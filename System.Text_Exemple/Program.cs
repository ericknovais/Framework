using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Text_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("New ");
            sb.Append("Youk");

            sb.Insert(4, " HEllO ");
            sb.Remove(4, 6);
            sb.Replace('k', 'q');

            Console.WriteLine(sb.ToString());
            sb.Clear();
            Console.ReadKey();
            #endregion


        }
    }
}
