//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTATO
    {
        public int IdContato { get; set; }
        public string Tipo { get; set; }
        public string Contato1 { get; set; }
        public int IdCliente { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
