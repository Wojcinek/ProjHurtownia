//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkty_Magazyn
    {
        public int id_produktu { get; set; }
        public int id_magazynu { get; set; }
        public Nullable<int> ilosc { get; set; }
    
        internal virtual Magazyny Magazyny { get; set; }
        internal virtual Produkty Produkty { get; set; }
    }
}
