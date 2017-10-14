using newAirlines.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newAirlines.PersistanceContextEF
{
    class AirlineContext : DbContext
    {
        
            public AirlineContext() : base("name=AirlineDBConnectionString")
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<AirlineContext,
               newAirlines.Migrations.Configuration>("AirlineDBConnectionString"));
            }

        public DbSet<TypSamolotu> TypSamolotu { get; set; }
        public DbSet<Samolot> Samolot { get; set; }
        public DbSet<Lot> Lot { get; set; }
        public DbSet<Kierunek> Kierunek { get; set; }
        public DbSet<Odprawa> Odprawa { get; set; }
        public DbSet<OdprawaPasazer> OdrpawaPasazer { get; set; }
        public DbSet<Pasazer> Pasazer { get; set; }
        public DbSet<Stanowisko> Stanowisko { get; set; }

        public object Airline { get; private set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }}
