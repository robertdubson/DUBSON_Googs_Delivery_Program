using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Commands;
namespace ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged, IViewModel
    {
        public ICommand _changeWindowCommand;

        AboutViewModel about;

        HomeViewModel home;

        OrderViewModel orders;

        ProductViewModel products;

        DestinationViewModel destinations;

        IViewModel _currentWindowViewModel;

        public RelayCommand SetAboutVMCommand { get; set; }

        public RelayCommand SetHomeVMCommand { get; set; }

        public RelayCommand SetOrdersVMCommand { get; set; }

        public RelayCommand SetProductsVMCommand { get; set; }

        public RelayCommand ExitCommand { get; set; }

        public ApplicationViewModel()
        {
            about = new AboutViewModel();

            home = new HomeViewModel();

            orders = new OrderViewModel();

            products = new ProductViewModel();

            _currentWindowViewModel = products;

            SetAboutVMCommand = new RelayCommand(SetAboutVM);

            SetProductsVMCommand = new RelayCommand(SetProductsVM);

            SetOrdersVMCommand = new RelayCommand(SetOrdersVM);

            ExitCommand = new RelayCommand(Exit);

        }

        public void SetOrdersVM() {

            CurrentWindowViewModel = orders;
        
        }

        public void SetProductsVM() {

            CurrentWindowViewModel = products;
        
        }

        public void SetAboutVM() {

            CurrentWindowViewModel = about;
        
        }

        public void Exit() {

            Environment.Exit(0);

        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        

        public IViewModel CurrentWindowViewModel { get { return _currentWindowViewModel; } set {  _currentWindowViewModel = value; OnPropertyChanged("CurrentWindowViewModel");  } }

        
    
    }
}
