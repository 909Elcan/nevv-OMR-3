
using CoreCodeFirst.E_commerce;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class CoreContext : DbContext
    {
       public DbSet<Category> Categorys {get; set;}
       public DbSet <Customer>  Customers{ get; set; }
       public DbSet <CustomerAddress> CustomerAddresss{get; set;}
       public DbSet <Order> Orderss { get; set; }
       public DbSet <OrderProduct> OrderProducts{ get; set; }
       public DbSet <Product> Products{get; set;}

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseSqlServer(@"Data Source=127.0.0.1;Initial Catalog=MyNewDatabase;User Id=127.0.0.1,1443;Password=SəninŞifrən123;TrustServerCertificate=True;Encrypt=True");
      }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });
        }



       

    }
    

}