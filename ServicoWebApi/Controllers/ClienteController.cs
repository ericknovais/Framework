using ServicoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicoWebApi.Controllers
{
    public class ClienteController : ApiController
    {
        Cliente[] clientes = new Cliente[]
        {
            new Cliente{ID =1, Nome="ERICK NOVAIS", Email="erick.hora@Outlook.com" },
            new Cliente{ID =2, Nome="GIOVANNA MEMOLI", Email="gi.memoli@Outlook.com" }
        };

        public IEnumerable<Cliente> GetClientes()
        {
            return clientes;
        }

        public IHttpActionResult getCliente(int id)
        {
            var cli = clientes.FirstOrDefault((x) => x.ID.Equals(id));
            return Ok(cli);
        }
    }
}
