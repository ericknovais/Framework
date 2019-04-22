using System;
using System.Windows.Forms;

namespace Sistema.Abstracao
{
    public enum TipoEnvio
    {
        Email = 0,
        SMS = 1,
        WhatsApp = 2
    };

    public abstract class FormaEnvio
    {
        public abstract void Enviar(string Aviso);
    }

    public class Email : FormaEnvio
    {
        public override void Enviar(string Aviso)
        {
            //Simulando envio de E-mail
            MessageBox.Show("E-mail enviado: " + Aviso);
        }
    }

    public class SMS : FormaEnvio
    {
        public override void Enviar(string Aviso)
        {
            //Simulando envio de E-mail
            MessageBox.Show("SMS enviado: " + Aviso);
        }
    }

    public class WhatsApp : FormaEnvio
    {
        public override void Enviar(string Aviso)
        {
            //Simulando envio de E-mail
            MessageBox.Show("WhatsApp enviado: " + Aviso);
        }
    }

    public class Fabrica
    {
        public static FormaEnvio CriarEnvio(TipoEnvio tipo)
        {
            switch (tipo)
            {
                case TipoEnvio.Email:
                    return new Email();
                case TipoEnvio.SMS:
                    return new SMS();
                case TipoEnvio.WhatsApp:
                    return new WhatsApp();
                default:
                    return null;
            }
        }
    }
}
