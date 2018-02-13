using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using KeyRegister.Models;

namespace KeyRegister.DAL
{
    public class Context : DbContext
    {
        public Context() : base("KeyRegister_BDD") { }

        public DbSet<Campus> Campus { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Etat> Etats { get; set; }
        public DbSet<Historique> Historiques { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}