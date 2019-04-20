using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
}

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public int Somar(int x, int y)
    {
        return x + y;
    }

    [WebMethod]
    public List<Cliente> GetClientes()
    {
        var result = new List<Cliente>();

        result.Add(new Cliente() { Id = 1, Nome = "Erick Novais" });
        result.Add(new Cliente() { Id = 2, Nome = "Giovanna Memoli" });
        result.Add(new Cliente() { Id = 3, Nome = "Luan Ferreira" });

        return result;
    }

}
