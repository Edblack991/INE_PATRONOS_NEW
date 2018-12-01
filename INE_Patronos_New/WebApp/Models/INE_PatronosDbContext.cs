using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class INE_PatronosDbContext : DbContext
    {

        public INE_PatronosDbContext() : base("INE_PatronosDbContext")
        {
            Database.SetInitializer<INE_PatronosDbContext>(new INE_PatronosDbInitializer());
        }

        public DbSet<City> Citys { get; set; }
        public DbSet<CountryRegion> CountryRegions { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<PoliticalParty> PoliticalPartys { get; set; }
        public DbSet<VotePresident> VotePresidents { get; set; }
        public DbSet<VoteGovernor> VoteGovernors { get; set; }
        public DbSet<VoteMayor> VoteMayors { get; set; }
        public DbSet<President> Presidents { get; set; }
        public DbSet<Governor> Governors { get; set; }
        public DbSet<Mayor> Mayors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}