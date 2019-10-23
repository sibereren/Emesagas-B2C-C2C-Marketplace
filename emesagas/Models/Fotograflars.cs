using emesagas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmesagasData
{
   public class Fotograflars
    {
        
        public int Id { get; set; }
        public string FotografUrl { get; set; }
        public string FotografAdi { get; set; }
        public string FotografAciklama { get; set; }
        public string FotografEtiket { get; set; }
        
    }
}
