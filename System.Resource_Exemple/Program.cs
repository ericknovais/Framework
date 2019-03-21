using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace System.Resource_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Resources.ResourceManager rm = new ResourceManager(typeof(System.Resource_Exemple.Main));
            string d = rm.GetString("DESCRICAO");
            Console.WriteLine(d);
            // Console.ReadKey();

            Console.WriteLine(ResorceHelper.getResorce("DESCRICAO"));
            Console.ReadKey();

        }
    }
}
