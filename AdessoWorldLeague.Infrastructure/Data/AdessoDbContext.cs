using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdessoWorldLeauge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdessoWorldLeague.Infrastructure.Data
{
    public class AdessoDbContext : DbContext
    {
        public AdessoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Draw> Draws { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Groups");
                
                entity.Property(p => p.Id).UseIdentityColumn();
            });
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Countries");

                entity.Property(p => p.Id).UseIdentityColumn();
            });
            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Teams");

                entity.Property(p => p.Id).UseIdentityColumn();
            });
            modelBuilder.Entity<Draw>(entity =>
            {
                entity.ToTable("Draws");

                entity.Property(p => p.Id).UseIdentityColumn();
            });
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Türkiye",
                },
                new Country
                {
                    Id = 2,
                    Name = "Almanya"
                },
                new Country
                {
                    Id = 3,
                    Name = "Fransa"
                },
                new Country
                {
                    Id = 4,
                    Name = "Hollanda"
                },
                new Country
                {
                    Id = 5,
                    Name = "Portekiz"
                },
                new Country
                {
                    Id = 6,
                    Name = "İtalya"
                },
                new Country
                {
                    Id = 7,
                    Name = "İspanya"
                },
                new Country
                {
                    Id = 8,
                    Name = "Belçika"
                });

            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Adesso İstanbul",
                    CountryId = 1,
                },
                new Team
                {
                    Id = 2,
                    Name = "Adesso Ankara",
                    CountryId = 1,
                },
                new Team
                {
                    Id = 3,
                    Name = "Adesso İzmir",
                    CountryId = 1,
                },
                new Team
                {
                    Id = 4,
                    Name = "Adesso Antalya",
                    CountryId = 1,
                }, new Team
                {
                    Id = 5,
                    Name = "Adesso Berlin",
                    CountryId = 2,
                },
                new Team
                {
                    Id = 6,
                    Name = "Adesso Frankfurt",
                    CountryId = 2,
                },
                new Team
                {
                    Id = 7,
                    Name = "Adesso Münih",
                    CountryId = 2,
                },
                new Team
                {
                    Id = 8,
                    Name = "Adesso Dortmund",
                    CountryId = 2,
                },
                new Team
                {
                    Id = 9,
                    Name = "Adesso Paris",
                    CountryId = 3,
                },
                new Team
                {
                    Id = 10,
                    Name = "Adesso Marsilya",
                    CountryId = 3,
                },
                new Team
                {
                    Id = 11,
                    Name = "Adesso Nice",
                    CountryId = 3,
                },
                new Team
                {
                    Id = 12,
                    Name = "Adesso Lyon",
                    CountryId = 3,
                },
                new Team
                {
                    Id = 13,
                    Name = "Adesso Amsterdam",
                    CountryId = 4,
                },
                new Team
                {
                    Id = 14,
                    Name = "Adesso Rotterdam",
                    CountryId = 4,
                },
                new Team
                {
                    Id = 15,
                    Name = "Adesso Lahey",
                    CountryId = 4,
                },
                new Team
                {
                    Id = 16,
                    Name = "Adesso Eindhoven",
                    CountryId = 4,
                },
                new Team
                {
                    Id = 17,
                    Name = "Adesso Lisbon",
                    CountryId = 5,
                },
                new Team
                {
                    Id = 18,
                    Name = "Adesso Porto",
                    CountryId = 5,
                },
                new Team
                {
                    Id = 19,
                    Name = "Adesso Braga",
                    CountryId = 5,
                },
                new Team
                {
                    Id = 20,
                    Name = "Adesso Coimbra",
                    CountryId = 5,
                },
                new Team
                {
                    Id = 21,
                    Name = "Adesso Roma",
                    CountryId = 6,
                },
                new Team
                {
                    Id = 22,
                    Name = "Adesso Milano",
                    CountryId = 6,
                },
                new Team
                {
                    Id = 23,
                    Name = "Adesso Venedik",
                    CountryId = 6,
                },
                new Team
                {
                    Id = 24,
                    Name = "Adesso Napoli",
                    CountryId = 6,
                },
                new Team
                {
                    Id = 25,
                    Name = "Adesso Sevilla",
                    CountryId = 7,
                },
                new Team
                {
                    Id = 26,

                    Name = "Adesso Madrid",
                    CountryId = 7,
                },
                new Team
                {
                    Id = 27,
                    Name = "Adesso Barselona",
                    CountryId = 7,
                },
                new Team
                {
                    Id = 28,
                    Name = "Adesso Granada",
                    CountryId = 7,
                },
                new Team
                {
                    Id = 29,
                    Name = "Adesso Brüksel",
                    CountryId = 8,
                },
                new Team
                {
                    Id = 30,
                    Name = "Adesso Brugge",
                    CountryId = 8,
                },
                new Team
                {
                    Id = 31,
                    Name = "Adesso Gent",
                    CountryId = 8,
                },
                new Team
                {
                    Id = 32,
                    Name = "Adesso Anvers",
                    CountryId = 8,
                }
            );
        }
    }
}
