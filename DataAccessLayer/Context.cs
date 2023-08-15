using EntityLayer.Entities;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
