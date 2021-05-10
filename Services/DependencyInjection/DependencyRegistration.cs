using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DataLib;
using DataLib.UnitOfWork;
namespace Services.DependencyInjection
{
    public class DependencyRegistration
    {
        public IServiceProvider Сontainer { get; }

        public void Build() {

            ServiceCollection _serviceCollection = new ServiceCollection();

            // реєструємо залежності для сервісів            
            _serviceCollection.AddSingleton<IDestinationService, DestinationService>();
            _serviceCollection.AddSingleton<IOrderService, OrderService>();
            _serviceCollection.AddSingleton<IProductService, ProductService>();
            _serviceCollection.AddSingleton<IDeliveryTypeService, DeliveryTypeService>();
            _serviceCollection.AddSingleton<IOrderStatusService, OrderStatusService>();
            _serviceCollection.AddSingleton<ITransportService, TransportService>();

            // реєструємо залежності для репозиторіїв
            _serviceCollection.AddScoped<IDestinationRepository, DestinationRepository>();
            _serviceCollection.AddScoped<IDeliveryTypeRepository, DeliveryTypeRepository>();
            _serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            _serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            _serviceCollection.AddScoped<ITransportRepository, TransportRepository>();
            _serviceCollection.AddScoped<IOrderStatusRepository, OrderStatusRepository>();

            // реєструємо залежності для одиниці роботи
            _serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            _serviceCollection.BuildServiceProvider();
        
        }
    }
}
