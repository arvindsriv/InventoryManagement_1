using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InventoryManagement.SP_Test;

namespace InventoryManagement.Models
{
    public class ProductDb : DbContext
    {
        public ProductDb()
            : base("name=DefaultConnection")
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        // Code for SP testing
        // StoredProc object to call a proc named "testone"
        [StoredProcAttributes.Name("testone")]
        [StoredProcAttributes.ReturnTypes(typeof(TestOneResultSet))]
        public StoredProc<testone> test { get; set; }


    }
}