﻿using System;
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
using Commands;
namespace ViewModels
{
    public class OrderViewModel : IViewModel, INotifyPropertyChanged
    {

        private string _messageText;

        public string MessageText { get { return _messageText; } set { _messageText = value; OnPropertyChanged("MessageText"); } }

        List<OrderModel> modelObjects;

        OrderModel currentOrder;

        IOrderService _orderService;

        OrderMapper orderMapper;

        public RelayCommand DeleteSelectedOrder { get; set; }

        IUnitOfWork _unitOfWork;

        public OrderViewModel()
        {
            _unitOfWork = new UnitOfWork(new ApplicationContext());
            
            _orderService = new OrderService(_unitOfWork);
            
            orderMapper = new OrderMapper();

            DeleteSelectedOrder = new RelayCommand(DeleteOrder);

            LoadData();
        }

        public OrderViewModel(IUnitOfWork unitOfWork, IOrderService orderService) {

            _unitOfWork = unitOfWork;

            _orderService = orderService;

            orderMapper = new OrderMapper();

            DeleteSelectedOrder = new RelayCommand(DeleteOrder);

            LoadData();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private void DeleteOrder() {

            if (CurrentOrder == null)
            {

                MessageText = "Будь ласка, оберіть замовлення, яке ви хочете видалити.";

            }

            else {

                _orderService.DeleteOrder(orderMapper.FromModelToDomain(CurrentOrder).ID);

                _unitOfWork.Complete();

                LoadData();

            }

            
        }

        public List<OrderModel> ModelObjects { get { return modelObjects; } set { modelObjects = value; OnPropertyChanged("ModelObjects"); } }

        public OrderModel CurrentOrder { get { return currentOrder; } set { currentOrder = value; OnPropertyChanged("CurrentOrder"); } }

        public void LoadData() {

            ModelObjects = _orderService.GetAllOrders().Select(order => orderMapper.FromDomainToModel(order)).ToList();
        
        }
    }
}
