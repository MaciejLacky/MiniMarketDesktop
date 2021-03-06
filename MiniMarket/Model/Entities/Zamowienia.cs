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
    
    public partial class Zamowienia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienia()
        {
            this.ZamowieniaPozycje = new HashSet<ZamowieniaPozycje>();
        }
    
        public int Zam_IdZamowienia { get; set; }
        public string Zam_NrDok { get; set; }
        public Nullable<int> Zam_IdKontrahent { get; set; }
        public Nullable<int> Zam_IdKontrahentOdbiorca { get; set; }
        public Nullable<int> Zam_IdKategoria { get; set; }
        public Nullable<int> Zam_IdMagazyn { get; set; }
        public Nullable<System.DateTime> Zam_DataWyst { get; set; }
        public Nullable<System.DateTime> Zam_DataSprzedazy { get; set; }
        public Nullable<System.DateTime> Zam_DataOd { get; set; }
        public Nullable<decimal> Zam_Rabat { get; set; }
        public string Zam_PlatnoscTyp { get; set; }
        public Nullable<System.DateTime> Zam_Termin { get; set; }
        public Nullable<int> Zam_IdPozycji { get; set; }
        public Nullable<int> Zam_WprowId { get; set; }
        public Nullable<System.DateTime> Zam_DataWprow { get; set; }
        public Nullable<int> Zam_ZmienId { get; set; }
        public Nullable<System.DateTime> Zam_DataZmian { get; set; }
        public Nullable<bool> Zam_CzyAktywne { get; set; }
        public Nullable<int> Zam_IdRodzajDokumentu { get; set; }
        public Nullable<int> Zam_IdRodzajPlatnosci { get; set; }
        public Nullable<int> ZamIdDokumentNettoBrutto { get; set; }
    
        public virtual Kontrahenci Kontrahenci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZamowieniaPozycje> ZamowieniaPozycje { get; set; }
        public virtual DokumentNettoBrutto DokumentNettoBrutto { get; set; }
        public virtual Kategorie Kategorie { get; set; }
        public virtual Magazyny Magazyny { get; set; }
        public virtual RodzajeDokumentow RodzajeDokumentow { get; set; }
        public virtual RodzajePlatnosci RodzajePlatnosci { get; set; }
        public virtual RodzajePlatnosci RodzajePlatnosci1 { get; set; }
    }
}
