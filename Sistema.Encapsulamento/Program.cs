using BancoDoBrasil.Contas;
using System;

namespace Sistema.Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.ContaCorrente, "0213208");

            conta.Deposistar(500);
            conta.Sacar(300);
            
            Console.WriteLine(conta.getSaldo().ToString());
            Console.ReadLine();
        }
    }
}
