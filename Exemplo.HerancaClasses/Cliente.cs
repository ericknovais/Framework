using System;

namespace ENDH.Cadastro
{
    public class Cliente
    {
        public int Codigo;
        public string Nome;

        public void Mostrar()
        {
            Console.WriteLine("Dados do Cliente: {0} - {1}", Codigo, Nome);
        }
    }

    public class PessoaFisica : Cliente
    {
        public string CPF;

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CPF: {0}", CPF);
        }
    }

    public class PessoaJuridica : Cliente
    {
        public string CNPJ;

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CNPJ: {0}", CNPJ);
        }

    }

    public class Governo : Cliente
    {
        public string Setor;
    }
}
