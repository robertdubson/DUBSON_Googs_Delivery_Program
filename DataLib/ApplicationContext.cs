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

           

            // modelBuilder.Entity<OrderEntity>().

            //modelBuilder.Entity<TransportEntity>().HasRequired<TransportTypeEntity>(transport => transport.TransportType).;

            //modelBuilder.Entity<TransportEntity>().HasRequired<DeliveryTypeEntity>(transport => transport.DeliveryType);

            //modelBuilder.Entity<OrderEntity>().HasRequired<TransportEntity>(order => order.InvolvedTransport);

            //modelBuilder.Entity<OrderEntity>().HasRequired<ProductEntity>(order => order.Product);

            //modelBuilder.Entity<OrderEntity>().HasRequired<DestinationEntity>(order => order.Destination);

            //modelBuilder.Entity<ProductEntity>().HasRequired<DeliveryTypeEntity>(prod => prod.DeliveryType);

        }

        public ApplicationContext() : base("ApplicationConnection") { 
        

        
        }
    }
}
