using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes_E_Tabelas
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Hashtable();
            alunos.Add(1, "Erick Novais");
            alunos.Add(2, "Giovanna");
            alunos.Add(3, "Leo");
            alunos.Add(4, "Luan");

            foreach (var aluno in alunos.Values)
            {
                Console.WriteLine(aluno);
            }

            foreach (DictionaryEntry aluno in alunos)
            {
                Console.WriteLine(aluno.Key + " - " + aluno.Value);
            }
            Console.WriteLine("Informe posição a ser lida: ");
            string pos = Console.ReadLine();
           // int pos = Convert.ToInt32(str);

            if (alunos.ContainsKey(pos))
                Console.WriteLine("O valor para essa  chave é :" + alunos[pos]);
            else
                Console.WriteLine("Não contem essa chave");

            Console.WriteLine("Informe letra ou parte a pesquisar no nome:");

            string str = Console.ReadLine();

            var qry = from string aluno in alunos.Values
                      where aluno.Contains(str)
                      select aluno;

            foreach(string aluno in qry)
                Console.WriteLine(aluno);

            Console.ReadLine();
        }
    }
}
