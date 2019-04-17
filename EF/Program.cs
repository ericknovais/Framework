using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new CadastroEntities();
            var cli = new CLIENTE()
            {
                NomeCliente = "Luan Ferreira",
                Email = "luan.fereira@gmail.com"
            };

            var cont1 = new CONTATO()
            {
                Tipo = "Email",
                Contato1 = "luan.fereira@gmail.com",
                CLIENTE = cli
            };

            var cont2 = new CONTATO()
            {
                Tipo = "Fone",
                Contato1 = "27380748",
                CLIENTE = cli
            };

            ctx.CONTATOS.Add(cont1);
            ctx.CONTATOS.Add(cont2);
            ctx.SaveChanges();
            Console.WriteLine("Registro salvo com sucesso");
            Console.ReadKey();
        }
    }
}
