using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DataLib;
using DataLib.UnitOfWork;
using Services;
using ViewModels;
namespace DeliveryAppWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }

        public App() {

            IServiceCollection collection = new ServiceCollection();

            ConfigureServices(collection);

            ServiceProvider = collection.BuildServiceProvider();
        
        }

        public void ConfigureServices(IServiceCollection collection) {

            // реєструємо залежності для сервісів            
            collection.AddSingleton<IDestinationService, DestinationService>();
            collection.AddSingleton<IOrderService, OrderService>();
            collection.AddSingleton<IProductService, ProductService>();
            collection.AddSingleton<IDeliveryTypeService, DeliveryTypeService>();
            collection.AddSingleton<IOrderStatusService, OrderStatusService>();
            collection.AddSingleton<ITransportService, TransportService>();

            // реєструємо залежності для репозиторіїв
            collection.AddScoped<IDestinationRepository, DestinationRepository>();
            collection.AddScoped<IDeliveryTypeRepository, DeliveryTypeRepository>();
            collection.AddScoped<IOrderRepository, OrderRepository>();
            collection.AddScoped<IProductRepository, ProductRepository>();
            collection.AddScoped<ITransportRepository, TransportRepository>();
            collection.AddScoped<IOrderStatusRepository, OrderStatusRepository>();

            // реєструємо залежності для одиниці роботи
            collection.AddScoped<IUnitOfWork, UnitOfWork>();


        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow() { DataContext = new ApplicationViewModel(ServiceProvider) };
            window.Show();
        }
    }
}
