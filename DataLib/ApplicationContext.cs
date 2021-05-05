using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entity;


namespace DataLib
{
    public class ApplicationContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationEntity>().ToTable("Destination");

            modelBuilder.Entity<OrderEntity>().ToTable("Order");

            modelBuilder.Entity<TransportEntity>().ToTable("Transport");

            modelBuilder.Entity<ProductEntity>().ToTable("Product");

            modelBuilder.Entity<DeliveryTypeEntity>().ToTable("DeliveryType");

            modelBuilder.Entity<TransportTypeEntity>().ToTable("TransportType");

            modelBuilder.Entity<OrderStatusEntity>().ToTable("OrderStatus");

        }

        public ApplicationContext() : base("ApplicationConnection") { 
        

        
        }
    }
}
