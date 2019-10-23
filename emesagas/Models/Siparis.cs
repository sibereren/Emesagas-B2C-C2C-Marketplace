using emesagas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmesagasData
{
   public class Siparis
    {
        public int SiparisId { get; set; }
        public virtual SiparisDetays SiparisDetays { get; set; }
        public decimal SiparisTutari { get; set; }
        public string KargoAlicisi { get; set; }
        public string KargoAdresi { get; set; }
        public int KargoSehirId { get; set; }
        public string KargoTelefon { get; set; }
        public KargoYontem KargoYontem { get; set; }
        public int OdemeYontemiId { get; set; }
        public System.DateTime SiparisTarih { get; set; }
        public System.DateTime KargolanmaTarih { get; set; }
        public string KargoTakipNo { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
