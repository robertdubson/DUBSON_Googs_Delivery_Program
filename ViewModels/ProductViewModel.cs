﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Services;
using DataLib;
using Mappers;
using Commands;
using DataLib.UnitOfWork;
using System.Data.Entity;

namespace ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged, IViewModel
    {

        public string MessageText { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private ProductModel currentProduct;

        DestinationViewModel destinationVM;

        public DestinationViewModel DestinationModelView { get { return destinationVM; }  }

        TransportService transportService;

        TransportMapper _transportMapper;

        TransportMapper transportMapper;

        OrderMapper _orderMapper;

        OrderService orderService;

        public RelayCommand CreateOrderCommand { get; set; }

        public void OnPropertyChanged(string propertyName) {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        ProductService productService;

        UnitOfWork _unitOfWork;

        ProductMapper _productMapper;

        DestinationService destinationService;

        DestinationMapper _destinationMapper;

        //private List<TransportModel> neededTransports;

        private List<ProductModel> modelObjects;

        List<DestinationModel> destinations;

        DestinationModel _selectedDestination;

        public DestinationModel SelectedDestination { get { return _selectedDestination; } 
            
            
            
            set { _selectedDestination = value;            
                OnPropertyChanged("SelectedDestination"); 
            } }

        public ProductViewModel() {

            _unitOfWork = new UnitOfWork(new ApplicationContext());

            productService = new ProductService(_unitOfWork.ProductRepository);

            transportService = new TransportService(_unitOfWork.TransportRepository);

            _transportMapper = new TransportMapper();

            transportMapper = new TransportMapper();

            _productMapper = new ProductMapper();

            destinationService = new DestinationService(_unitOfWork.DestinationRepository);

            _destinationMapper = new DestinationMapper();

            //neededTransports = new List<TransportModel>();

            modelObjects = new List<ProductModel>();

            CreateOrderCommand = new RelayCommand(CreateAnOrder);

            new DestinationViewModel();
            
            destinationVM =  DestinationViewModel.Instance;

            //DestinationModelView.parentViewModel = this;

            _orderMapper = new OrderMapper();

            orderService = new OrderService(_unitOfWork.OrderRepository);


            LoadData();
        
        }

        public List<ProductModel> ModelObjects { get { return modelObjects; } set { modelObjects = value; OnPropertyChanged("modelObjects"); } }

        public ProductModel CurrentProduct { get { return currentProduct; } set { currentProduct = value; OnPropertyChanged("CurrentProduct"); } }

       

        public void LoadData() {

            modelObjects = productService.GetAllProducts().Select(prod => _productMapper.FromDomainToModel(prod)).ToList();
        
        }

        public void CreateAnOrder() {

            //DestinationModelView = new DestinationViewModel();

            SelectedDestination = DestinationViewModel.Instance.SelectedDestination;

            OrderModel newOrder = _orderMapper.FromDomainToModel(orderService.CreateAnOrder(_destinationMapper.FromModelToDomain(SelectedDestination), _productMapper.FromModelToDomain(CurrentProduct), transportService.GetSuitableTransport(_productMapper.FromModelToDomain(CurrentProduct))));

            //_unitOfWork.OrderRepository.Add(_orderMapper.FromDomainToEntity(_orderMapper.FromModelToDomain(newOrder)));
            
            
            orderService.AddOrder(_orderMapper.FromModelToDomain(newOrder));
            
            
            
            _unitOfWork.Complete();

            newOrder.InvolvedTransport.InTheShop = false;

            //transportService.UpdateTransport(_transportMapper.FromModelToDomain(newOrder.InvolvedTransport));

            //_unitOfWork.Complete();

            _unitOfWork.Dispose();

            //orderService.AddOrder(_orderMapper.FromModelToDomain(newOrder));

            MessageText = "Ви замовили продукт " + newOrder.Product.Name + ", що коштує " + newOrder.Product.Price + " $ . Товар буде доставлено до пункту " + newOrder.Destination.Name + " за " + newOrder.TimeNeededForDelivery + " одиниць часу";
        
            
        }
    }
}
