using GestionEnseignants.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionEnseignants.Models
{
    public class EnseignantContext : IdentityDbContext<GestionEnseignantsUser>
    {
        public EnseignantContext(DbContextOptions<EnseignantContext> options) : base(options)
        {
        }

        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Departement> Departements { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Enseignant>().Property(e => e.departementId).HasColumnName("departementId");

        }
    }
}

            // Customize the ASP.NET Identity model and override
