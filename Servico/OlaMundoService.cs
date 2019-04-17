using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servico
{
    public class OlaMundoService : IOlaMundoService
    {
        public string OlaMundo()
        {
            return "Ola Mundo - WCF";
        }
    }
}
