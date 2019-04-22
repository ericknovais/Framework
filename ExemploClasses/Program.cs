using Erick.Util;
using System;

namespace ExemploClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            string xStr = Console.ReadLine(); //UI

            Console.WriteLine("Digite o segundo número");
            string yStr = Console.ReadLine(); //UI

            int x = Convert.ToInt32(xStr);
            int y = Convert.ToInt32(yStr);

            int r = Calculado.Somar(x, y);

            Console.WriteLine("O resultado da sua soma é: " + r); //UI
            Console.ReadKey();
        }


    }
}
