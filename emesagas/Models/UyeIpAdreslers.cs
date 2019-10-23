using emesagas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmesagasData
{
    public class UyeIpAdreslers
    {

        public UyeIpAdreslers()
        {
            this.ApplicationUser = new HashSet<ApplicationUser>();
        }


        public int Id { get; set; }
        public string IpNo { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}
