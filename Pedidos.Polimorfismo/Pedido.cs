using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Polimorfismo
{
    public abstract class FormaPagamento
    {
        public abstract void Pagar(double valor);
    }

    public class Boleto : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago valor de {0} no boleto", valor);
        }
    }

    public class Cartao : FormaPagamento
    {
        public  override void Pagar(double valor)
        {
            Console.WriteLine("Pago valor de {0} no cartão", valor);
        }
    }

    public class Pedido
    {
        public Pedido(FormaPagamento formaPagamento)
        {
            this._formaPagamento = formaPagamento;
        }
        //Associação, programando para uma abstração
        private FormaPagamento _formaPagamento;

        public void Pagar(double valor)
        {
            //delegação polimorfica
            this._formaPagamento.Pagar(valor);
        }
    }
}
