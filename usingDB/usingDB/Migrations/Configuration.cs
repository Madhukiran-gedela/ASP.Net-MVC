namespace usingDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<usingDB.Models.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "usingDB.Models.CompanyDbContext";
        }

        protected override void Seed(usingDB.Models.CompanyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Brands.AddOrUpdate(new Models.Brands()
            {
                BrandID = 1,
                BrandName = "Sony",
            },
            new Models.Brands()
            {
                BrandID = 2,
                BrandName = "Apple",
            });
            context.Categories.AddOrUpdate(new Models.Category()
            {
                CategoryID = 1,
                CategoryName = "Mobiles",
            },
            new Models.Category()
            {
                CategoryID = 2,
                CategoryName="laptops"
            });
            context.Products.AddOrUpdate(new Models.Product()
            {
                ProductID = 1,
                ProductName = "Iphone 13",
                CategoryID = 1,
                BrandID = 2,
                Price = 90000,
                Active = true,
                DateOfPurchase = DateTime.Now
            });
        }
    }
}
