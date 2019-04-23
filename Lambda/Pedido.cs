using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate void PagarNotify(double valor);

    public class Pedido
    { 
        //Ponteiro para o método
        //Forma de injetar código no meu framework
        //Código da implementação vem de fora
        public event PagarNotify PagarEvent; //Alguem deve apontar

        public void Pagar(double valor)
        {
            //delegação
            this.PagarEvent(valor);
        }
    }

    public class Boleto
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Pago boleto no valor: " + valor);
        }
    }
}
