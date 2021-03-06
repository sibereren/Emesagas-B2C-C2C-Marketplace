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
    
    public partial class Uyes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uyes()
        {
            this.Sipariss = new HashSet<Sipariss>();
            this.Uruns = new HashSet<Uruns>();
            this.UyeIpAdreslers = new HashSet<UyeIpAdreslers>();
        }
    
        public int UyeId { get; set; }
        public string Soyad { get; set; }
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public int FotografId { get; set; }
        public int SehirId { get; set; }
        public bool UyelikAktifMi { get; set; }
        public bool TedarikciMi { get; set; }
        public bool UyelikDogrulandiMi { get; set; }
        public System.DateTime UyeKayitTarihi { get; set; }
        public Nullable<int> UyeIpAdreslerId { get; set; }
        public string AspNetUsersId { get; set; }
    
        public virtual Fotografs Fotografs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sipariss> Sipariss { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uruns> Uruns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UyeIpAdreslers> UyeIpAdreslers { get; set; }
        public virtual UyeIpAdreslers UyeIpAdreslers1 { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
