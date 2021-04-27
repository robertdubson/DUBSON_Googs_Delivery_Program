using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Services;
using System.ComponentModel;
using DataLib;
using Mappers;
using DataLib.UnitOfWork;

namespace ViewModels
{
    public class OrderViewModel : IViewModel, INotifyPropertyChanged
    {
        List<OrderModel> modelObjects;

        OrderModel currentOrder;

        OrderService _orderService;

        OrderMapper orderMapper;

        public OrderViewModel()
        {
            _orderService = new OrderService(new UnitOfWork(new ApplicationContext()).OrderRepository);
            
            orderMapper = new OrderMapper();

            LoadData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        public List<OrderModel> ModelObjects { get { return modelObjects; } set { modelObjects = value; OnPropertyChanged("ModelObjects"); } }

        public OrderModel CurrentOrder { get { return currentOrder; } set { currentOrder = value; OnPropertyChanged("CurrentOrder"); } }

        public void LoadData() {

            ModelObjects = _orderService.GetAllOrders().Select(order => orderMapper.FromDomainToModel(order)).ToList();
        
        }
    }
}
