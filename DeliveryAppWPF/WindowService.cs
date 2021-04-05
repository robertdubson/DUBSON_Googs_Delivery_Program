using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Commands;
namespace DeliveryAppWPF
{
    public class WindowService
    {
        MainWindow mainWindow;
        public WindowService(MainWindow window)
        {
            mainWindow = window;

            GoToAboutCommand = new RelayCommand(GoToAbout);
            
            GoToProductsCommand = new RelayCommand(GoToProducts);
            
            GoToRecentOrdersCommand = new RelayCommand(GoToRecentOrders);
            
            ExitCommand = new RelayCommand(Exit);
        
        }

        public RelayCommand GoToAboutCommand { get; }

        

        public RelayCommand GoToProductsCommand { get; }

        

        public RelayCommand GoToRecentOrdersCommand { get;  }

        

        public RelayCommand ExitCommand { get; }

        public void GoToProducts() {

            ProductsWindow productsWindow = new ProductsWindow();

            productsWindow.Show();
        
        
        }

        public void GoToAbout() {

            AboutWindow aboutWindow = new AboutWindow();

            aboutWindow.Show();
        
        }

        public void GoToRecentOrders() {

            RecentOrdersWindow recentOrdersWindow = new RecentOrdersWindow();

            recentOrdersWindow.Show();
        
        }

        public void Exit() {

            mainWindow.Close();
        
        }
    }
}
