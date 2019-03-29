using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace System.XML_Exemple
{
    public partial class Form3 : Form
    {
        string arquivo = @"E:\Erick\Estudos\DevMidia C#\Framework\System.XML_Exemple\XML\Agenda.xml";
        XmlDocument xDoc = new XmlDocument();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Deserelizador
            XElement elementX = XElement.Load(arquivo);
            Contatos contatos = Serializador.Deserialize<Contatos>(elementX);

            //Serializador
            XElement xReturn = Serializador.Serialize<Contatos>(contatos);

        }
    }
}
