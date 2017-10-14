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
            Database.SetInitializer(new AirlineInitializer());
        }
        public DbSet<TypSamolotu> TypSamolotu { get; set; }
        public DbSet<Samolot> Samolot { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }}
