using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    //S.O.L.I.D
    public class Pedido
    {
        //Associação
        private FormaPagamento _formaPagamento = new Boleto();

        public Pedido(FormaPagamento formaPagamento)
        {   //guardo internamente a forma de pagamento 
            //que foi passada no construtor da classe
            //para que depois seja feita a delegação
            this._formaPagamento = formaPagamento;
        }

        public void Fechar(double valor)
        {
            //delegar polimórfica
            //semelhante a um padrão state
            _formaPagamento.Pagar(valor);
        }
    }

    public abstract class FormaPagamento
    {
        public abstract void Pagar(double valor);
    }

    public class Boleto : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago no boleto no valor de " + valor);
        }
    }

    public class Cartao : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago no cartâo no valor de " + valor);
        }
    }

    public class Cheque : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago no cheque no valor de " + valor);
        }
    }
}

