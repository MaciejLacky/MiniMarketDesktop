//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniMarket.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firmy
    {
        public int F_FirmaId { get; set; }
        public string F_FRNazwa { get; set; }
        public string F_FRAdres { get; set; }
        public string F_FRNIP { get; set; }
        public string F_FRREGON { get; set; }
        public string F_FRWprowadzil { get; set; }
        public Nullable<System.DateTime> F_FRDataWprowadzenia { get; set; }
        public string F_FRZZmienil { get; set; }
        public Nullable<System.DateTime> F_FRDataZmiany { get; set; }
        public Nullable<bool> F_CzyAktywne { get; set; }
    }
}
