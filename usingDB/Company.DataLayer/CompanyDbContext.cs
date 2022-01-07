using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using usingDB.Migrations;
namespace Company.DataLayer
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("MyConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyDbContext, Configuration>());
        }
        public DbSet<Company.DomainModels.Brands> Brands { get; set; }
        public DbSet<Company.DomainModels.Category> Categories { get; set; }
        public DbSet<Company.DomainModels.Product> Products { get; set; }
    }
}
