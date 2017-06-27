namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Warehouse.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Warehouse.DataAccess.WarehouseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Warehouse.DataAccess.WarehouseContext";
        }

        protected override void Seed(Warehouse.DataAccess.WarehouseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                p => p.Name,
                new Product { Name = "Toaster 2000", Category = "Home Appliances", Price = 199, Count = 2 },
                new Product { Name = "Toaster 3000", Category = "Home Appliances", Price = 299, Count = 4 },
                new Product { Name = "Galaxy Note 7", Category = "Electronics", Price = 4500, Count = 7 },
                new Product { Name = "Ipad Helium ", Category = "Electronics", Price = 5100, Count = 2 }
            );
        }
    }
}
