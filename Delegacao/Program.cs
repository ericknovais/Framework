﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = 2500;
            var pedido = new Pedido(new Boleto()); //Injeção de dependencia (DI) / Inversão de Controle (IoC)
            pedido.Fechar(valor);
            Console.ReadLine();
        }
    }
}
