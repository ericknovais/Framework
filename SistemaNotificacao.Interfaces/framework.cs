using System;

namespace SistemaNotificacao.Interfaces
{
    public interface INotificacao
    {
        void Enviar(string Mensagem);
    }

    public abstract class Notificacao : INotificacao
    {
        public abstract void Enviar(string Mensagem);
    }

    public class Email : Notificacao
    {
        public override void Enviar(string Mensagem)
        {
            Console.WriteLine("Enviando EMAIL: " + Mensagem);
        }
    }

    public class SMS : Notificacao
    {
        public override void Enviar(string Mensagem)
        {
            Console.WriteLine("Enviando SMS: " + Mensagem);
        }
    }

    public abstract class Pessoa
    {
        public string Nome;
    }

    public class Funcionario : Pessoa, INotificacao
    {
        public void Enviar(string Mensagem)
        {
            Console.WriteLine("Funcionario está notificando: " + Mensagem);
        }
    }
}
