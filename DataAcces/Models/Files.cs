//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAcces.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Files
    {
        public int ID { get; set; }
        public string Název { get; set; }
        public string Cesta { get; set; }
        public double Velikost { get; set; }
        public Nullable<int> Pocet_Stazeni { get; set; }
        public System.DateTime Datum_Nahrani { get; set; }
    }
}
