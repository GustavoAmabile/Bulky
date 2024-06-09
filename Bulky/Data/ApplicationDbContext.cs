using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Agent> Agents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().
                HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Drama", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Comedy", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Agent>().
                HasData(
                new Agent { Id = 1, Name = "Hugo", Number = 01, Team = "Coordenação", IsAvailable = true },
                new Agent { Id = 2, Name = "Marco", Number = 01, Team = "Coordenação", IsAvailable = true },
                new Agent { Id = 5, Name = "Giovani", Number = 01, Team = "Instrução", IsAvailable = true },
                new Agent { Id = 6, Name = "João", Number = 01, Team = "Coordenação", IsAvailable = true },
                new Agent { Id = 7, Name = "Cleiton", Number = 01, Team = "Sor 1", IsAvailable = true },
                new Agent { Id = 8, Name = "Davidson", Number = 01, Team = "Sor 2", IsAvailable = true },
                new Agent { Id = 9, Name = "Tharik", Number = 01, Team = "Sor 2", IsAvailable = true },
                new Agent { Id = 10, Name = "Ailton", Number = 01, Team = "Sor 1", IsAvailable = true }
                );

        }

       
    }
        
}
