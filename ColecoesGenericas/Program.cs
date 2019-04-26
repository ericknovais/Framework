using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecoesGenericas
{
    class Program
    {
        public class Aluno
        {
            public int Matricula;
            public string Nome;
            public string Curso;
            public override string ToString()
            {
                return Matricula.ToString() + " - " + Nome + " - " + Curso ;
            }
        }

        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            alunos.Add(new Aluno() { Matricula = 57, Nome = "Erick Novais", Curso = "Ads" });
            foreach (var aluno in alunos)
                Console.WriteLine(aluno);
            Console.ReadLine();
        }
    }
}
