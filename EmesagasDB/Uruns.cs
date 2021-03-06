//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmesagasDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uruns
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uruns()
        {
            this.SiparisDetays = new HashSet<SiparisDetays>();
        }
    
        public int UrunId { get; set; }
        public int UyeId { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public short UrunStokAdedi { get; set; }
        public short UrunStokKalan { get; set; }
        public short UrunStokSatilan { get; set; }
        public bool UrununDevamiVarMi { get; set; }
        public short FiyatKacAdetIcin { get; set; }
        public decimal UrunFiyati { get; set; }
        public string UrunAciklama { get; set; }
        public int FotografID { get; set; }
        public System.DateTime UrunEklenmeTarihi { get; set; }
        public bool IlanAktifMi { get; set; }
        public Nullable<int> UrunAgirlikGram { get; set; }
        public string UrunKisaAciklama { get; set; }
        public System.DateTime UrunGuncellenmeTarihi { get; set; }
        public string UrunUretimYeri { get; set; }
    
        public virtual Fotografs Fotografs { get; set; }
        public virtual Kategoris Kategoris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDetays> SiparisDetays { get; set; }
        public virtual Uyes Uyes { get; set; }
    }
}
