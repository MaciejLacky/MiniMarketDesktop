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
    
    public partial class WzPozycje
    {
        public int Wz_PozycjeId { get; set; }
        public Nullable<int> Wz_PozycjeIdTowaru { get; set; }
        public Nullable<int> Wz_PozycjeIdKategori { get; set; }
        public string Wz_PozycjeKod { get; set; }
        public string Wz_PozycjeNazwa { get; set; }
        public Nullable<decimal> Wz_PozycjeIlosc { get; set; }
        public string Wz_PozycjeJm { get; set; }
        public Nullable<decimal> Wz_Rabat { get; set; }
        public Nullable<decimal> Wz_PozycjeCenaNetto { get; set; }
        public Nullable<byte> Wz_PozycjeVatZakup { get; set; }
        public Nullable<byte> Wz_PozycjeVatSprzedaz { get; set; }
        public Nullable<decimal> Wz_PozycjeCenaBrutto { get; set; }
        public Nullable<int> Wz_PozycjeWprowId { get; set; }
        public Nullable<System.DateTime> Wz_PozycjeDataWprow { get; set; }
        public Nullable<int> Wz_PozycjeZmienId { get; set; }
        public Nullable<System.DateTime> Wz_PozycjeDataZmien { get; set; }
        public Nullable<bool> Wz_PozycjeCzyAktywne { get; set; }
        public Nullable<int> Wz_IdWZ { get; set; }
    
        public virtual Towary Towary { get; set; }
        public virtual WZ WZ { get; set; }
    }
}
