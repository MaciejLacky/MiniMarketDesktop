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
    
    public partial class DokumentNettoBrutto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DokumentNettoBrutto()
        {
            this.FakturyZakupu = new HashSet<FakturyZakupu>();
            this.FakturySprzedazy = new HashSet<FakturySprzedazy>();
            this.Zamowienia = new HashSet<Zamowienia>();
            this.Paragony = new HashSet<Paragony>();
            this.PZ = new HashSet<PZ>();
            this.Rezerwacje = new HashSet<Rezerwacje>();
            this.WZ = new HashSet<WZ>();
        }
    
        public int Id_FakturaLiczonaOd { get; set; }
        public string Nazwa { get; set; }
        public Nullable<bool> CzyAktywne { get; set; }
        public string Wprowadzil { get; set; }
        public Nullable<System.DateTime> DataWprowadzenia { get; set; }
        public string Zmienil { get; set; }
        public Nullable<System.DateTime> DataZmiany { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FakturyZakupu> FakturyZakupu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FakturySprzedazy> FakturySprzedazy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paragony> Paragony { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PZ> PZ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezerwacje> Rezerwacje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WZ> WZ { get; set; }
    }
}
