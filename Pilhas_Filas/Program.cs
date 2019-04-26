using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas_Filas
{
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExemploQueue();

        }

        private static void ExemploQueue()
        {
            //FIFO Primeiro entra - Primeiro Sai
            var lista = new Queue<Aluno>();
            lista.Enqueue(new Aluno() { Matricula = 56, Nome = "Erick" });
            lista.Enqueue(new Aluno() { Matricula = 50, Nome = "Giovanna" });
            lista.Enqueue(new Aluno() { Matricula = 60, Nome = "Guilherme" });

            Console.WriteLine(lista.Peek().Nome);
            while (lista.Count > 0)
                Console.WriteLine(lista.Dequeue().Nome);

            Console.ReadLine();
        }

        private static void ExemploStack()
        {
            //LIFO - Ultimo a entrar - primeiro a sair
            var pilha = new Stack<Aluno>();
            pilha.Push(new Aluno() { Matricula = 56, Nome = "Erick" });
            pilha.Push(new Aluno() { Matricula = 50, Nome = "Giovanna" });
            pilha.Push(new Aluno() { Matricula = 60, Nome = "Guilherme" });

            while (pilha.Count > 0)
            {
                Console.WriteLine(pilha.Pop().Nome);
            }
            Console.ReadKey();
        }
    }
}
