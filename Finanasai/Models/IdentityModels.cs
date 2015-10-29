using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Finanasai.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Finansai.DAL.AsmeninePrieziura> AsmeninePrieziuras { get; set; }

        public DbSet<Finansai.DAL.Metai> Metai { get; set; }

        public DbSet<Finansai.DAL.BustoIslaidos> BustoIslaidos { get; set; }

        public DbSet<Finansai.DAL.Dienos> Dienos { get; set; }

        public DbSet<Finansai.DAL.Dovanos> Dovanos { get; set; }

        public DbSet<Finansai.DAL.Santaupos> Santaupos { get; set; }

        public DbSet<Finansai.DAL.Kita> Kita { get; set; }

        public DbSet<Finansai.DAL.Maistas> Maistas { get; set; }

        public DbSet<Finansai.DAL.Menesiai> Menesiai { get; set; }

        public DbSet<Finansai.DAL.Pramogos> Pramogos { get; set; }

        public DbSet<Finansai.DAL.Savaites> Savaites { get; set; }

        public DbSet<Finansai.DAL.Transportas> Transportas { get; set; }
    }
}