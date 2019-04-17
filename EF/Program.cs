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
            ConsultarClientes3(ctx);
            Console.ReadKey();
        }

        private static void ConsultarClientes3(CadastroEntities ctx)
        {
            var qry = from _contatos in ctx.CONTATOS
                      select new
                      {
                          Nome = _contatos.CLIENTE.NomeCliente,
                          Contato = _contatos.Contato1
                      };
            foreach (var cli in qry)
            {
                Console.WriteLine(cli.Nome + " - " + cli.Contato);
            }
        }

        private static void ConsultaClientes2(CadastroEntities ctx)
        {
            var qry = from cli in ctx.CLIENTES
                          //where cli.NomeCliente.Contains("Gi")
                      orderby cli.IdCliente descending
                      select cli;

            foreach (var c in qry)
            {
                Console.WriteLine(c.IdCliente + " - " + c.NomeCliente + " - " + c.Email);
            }
        }

        private static void ConsultarClientes1(CadastroEntities ctx)
        {
            foreach (var cli in ctx.CLIENTES)
            {
                Console.WriteLine("Nome: " + cli.NomeCliente.ToUpper());
                foreach (var cont in cli.CONTATOS)
                {
                    Console.WriteLine("Tipo: " + cont.Tipo);
                    Console.WriteLine("Contato: " + cont.Contato1.ToUpper());
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

        private static void Inserir(CadastroEntities ctx)
        {
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
