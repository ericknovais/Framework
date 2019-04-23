using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        //Trocar Especifico
        private static void TrocarInteito(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        //Trocar Generico
        private static void Trocar<T>(ref T a,ref T b )
        {
            T aux = a;
            a = b;
            b = aux;
        }

        static void Main(string[] args)
        {
            //Trocando Inteiros
            int a = 10;
            int b = 20;
            TrocarInteito(ref a, ref b); //Trocar Especifico
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            Console.ReadLine();

            //Trocando bool
            bool b1 = true;
            bool b2 = false;
            Trocar<bool>(ref b1, ref b2); //Trocar Generico
            Console.WriteLine("B1: " + b1);
            Console.WriteLine("B2: " + b2);
            Console.ReadLine();

            //Trocando double
            double d1 = 10.3;
            double d2 = 20.3;
            Trocar<double>(ref d1, ref d2); // Trocar Generico
            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D2: " + d2);
            Console.ReadLine();
        }
    }
}
