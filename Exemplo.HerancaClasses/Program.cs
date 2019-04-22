using ENDH.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.HerancaClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica cli1 = new PessoaFisica();
            cli1.Codigo = 1;
            cli1.Nome = "ERICK";
            cli1.CPF = "408.926.318-21";

            cli1.Mostrar();

            PessoaJuridica cli2 = new PessoaJuridica();
            cli2.Codigo = 2;
            cli2.Nome = "GIOVANNA";
            cli2.CNPJ = "60.807.435/0001-74";

            cli2.Mostrar();
            Console.ReadLine();
        }
    }
}
