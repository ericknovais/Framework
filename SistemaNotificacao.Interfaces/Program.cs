using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificacao.Interfaces
{
    //UI
    class Program
    {
        //Associação  concreta
        //private static Email email = new Email();

        //Associção para Abstração
        private static INotificacao notificacao;

        static void Main(string[] args)
        {
            string Mensagem = "Olá Mundo";
            notificacao = new Funcionario();
            notificacao.Enviar(Mensagem); //Delegação
            Console.ReadLine();
        }
    }
}
