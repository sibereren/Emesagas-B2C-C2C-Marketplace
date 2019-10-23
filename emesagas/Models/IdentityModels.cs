using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using EmesagasData;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace emesagas.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            var tedarikciMi = await manager.AddClaim<ApplicationUser,
            return userIdentity;
        }
        public ApplicationUser()
        {
            this.UyeIpAdreslers = new HashSet<UyeIpAdreslers>();
            this.Uruns = new HashSet<Uruns>();

        }


        public string Soyad { get; set; }
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public string Adres { get; set; }
        public ICollection<Fotograflars> Fotograflars { get; set; }

        public int? SehirId { get; set; }
        public bool? UyelikKapaliMi { get; set; }
        public DateTime? UyeKayitTarihi { get; set; }
        public int? UyeIpAdreslerId { get; set; }

        public bool TedarikciMi { get; set; }


        public virtual ICollection<UyeIpAdreslers> UyeIpAdreslers { get; set; }
        public virtual ICollection<Uruns> Uruns { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("EmesagasEntities", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<EmesagasData.Uruns> Uruns { get; set; }
    }
}