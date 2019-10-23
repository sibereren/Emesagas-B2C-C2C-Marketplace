using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace emesagas.Models
{
    public class UrunFotograflars
    {
        [Key]
        public int UrunFotograflarId { get; set; }
        public string UrunFotografUrl { get; set; }
        public string UrunFotografAdi { get; set; }
        public string UrunFotografAciklama { get; set; }
        public string UrunFotografEtiket { get; set; }
        public int UrunsId { get; set; }
        public EmesagasData.Uruns Uruns { get; set; }


    }
}