using emesagas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmesagasData
{
    public class Uruns
    {
        public Uruns()
        {
            this.ApplicationUser = new HashSet<ApplicationUser>();
            this.SiparisDetays = new HashSet<SiparisDetays>();
        }

        public int UrunsId { get; set; }
        public int UyeId { get; set; }
        public Kategoris Kategoris { get; set; }
        public string UrunAdi { get; set; }
        public short UrunStokAdedi { get; set; }
        public short UrunStokKalan { get; set; }
        public short UrunStokSatilan { get; set; }

        public decimal UrunFiyati { get; set; }
        public string UrunAciklama { get; set; }
        public DateTime UrunEklenmeTarihi { get; set; }
        public bool IlanAktifMi { get; set; }
        public string UrunKisaAciklama { get; set; }
        public DateTime UrunGuncellenmeTarihi { get; set; }

        public ICollection<UrunFotograflars> UrunFotograflars { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
        public virtual ICollection<SiparisDetays> SiparisDetays { get; set; }
    }
}
