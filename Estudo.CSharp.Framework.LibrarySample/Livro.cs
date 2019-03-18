using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo.CSharp.Framework.LibrarySample.Library;

namespace Estudo.CSharp.Framework.LibrarySample
{
    public class Livro
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }


        private int anoPublicacao;

        public int AnoPublicacao
        {
            get { return anoPublicacao; }
            set { anoPublicacao = value; }
        }

         Biblioteca _biblioteca;

        public Biblioteca _Biblioteca
        {
            get { return _biblioteca; }
            set { _biblioteca = value; }
        }

    }
}
