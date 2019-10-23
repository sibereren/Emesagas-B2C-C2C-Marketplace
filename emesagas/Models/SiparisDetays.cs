using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmesagasData
{
    public class SiparisDetays
    {
        public SiparisDetays()
        {
            this.Uruns = new HashSet<Uruns>();
          
        }
        public int Id { get; set; }
        public decimal DetayFiyat { get; set; }
        public short DetayAdet { get; set; }
        [Required]
        public virtual Siparis Siparis { get; set; }
        public virtual ICollection<Uruns> Uruns { get; set; }
    }
}
