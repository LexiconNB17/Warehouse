using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Warehouse.Models;

namespace Warehouse.DataAccess
{
    public class WarehouseContext : DbContext
    {       
        public WarehouseContext() : base("name=WarehouseContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
