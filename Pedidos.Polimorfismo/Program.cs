using System;

namespace Pedidos.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new Cartao()); //injeto a dependencia
            double valor = 2000;
            pedido.Pagar(valor);
            Console.ReadLine();
        }
    }
}
