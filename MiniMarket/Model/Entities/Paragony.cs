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
    
    public partial class Paragony
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paragony()
        {
            this.ParagonyPozycje = new HashSet<ParagonyPozycje>();
            this.TowaryIlosci = new HashSet<TowaryIlosci>();
        }
    
        public int Par_IdParagonu { get; set; }
        public string Par_NrDok { get; set; }
        public Nullable<int> Par_IdKontrahent { get; set; }
        public Nullable<int> Par_IdKontrahentOdbiorca { get; set; }
        public Nullable<int> Par_IdKategoria { get; set; }
        public Nullable<int> Par_IdMagazyn { get; set; }
        public Nullable<System.DateTime> Par_DataWyst { get; set; }
        public Nullable<System.DateTime> Par_DataSprzedazy { get; set; }
        public Nullable<System.DateTime> Par_DataOd { get; set; }
        public Nullable<decimal> Par_Rabat { get; set; }
        public string Par_PlatnoscTyp { get; set; }
        public Nullable<System.DateTime> Par_Termin { get; set; }
        public Nullable<int> Par_IdPozycji { get; set; }
        public Nullable<int> Par_WprowId { get; set; }
        public Nullable<System.DateTime> Par_DataWprow { get; set; }
        public Nullable<int> Par_ZmienId { get; set; }
        public Nullable<System.DateTime> Par_DataZmian { get; set; }
        public Nullable<bool> Par_CzyAktywne { get; set; }
        public Nullable<int> Par_IdNettoBrutto { get; set; }
        public Nullable<int> Par_IdRodzajuDokumentu { get; set; }
        public Nullable<int> Par_IdRodzajuPlatnosci { get; set; }
    
        public virtual Kontrahenci Kontrahenci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParagonyPozycje> ParagonyPozycje { get; set; }
        public virtual DokumentNettoBrutto DokumentNettoBrutto { get; set; }
        public virtual Kategorie Kategorie { get; set; }
        public virtual Magazyny Magazyny { get; set; }
        public virtual RodzajeDokumentow RodzajeDokumentow { get; set; }
        public virtual RodzajePlatnosci RodzajePlatnosci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TowaryIlosci> TowaryIlosci { get; set; }
    }
}