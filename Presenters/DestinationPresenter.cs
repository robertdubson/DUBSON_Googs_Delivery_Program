using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Services;
using Mappers;
using DataLib;
using DataLib.UnitOfWork;
using System.Data.Entity;
using Entity;
namespace Presenters
{
    public class DestinationPresenter
    {
        IDestinationView _view;

        ProductModel SelectedProduct { get; set; }

        List<DestinationModel> destinations;

        DestinationMapper _destinationMapper;

        ProductMapper _productMapper;

        OrderMapper _orderMapper;

        TransportMapper _transportMapper;

        OrderStatusMapper _orderStatusMapper;

        DestinationService destinationService;

        TransportService transportService;

        OrderService orderService;

        OrderStatusService OrderStatusService;

        UnitOfWork _unitOfWork;

        public DestinationPresenter(IDestinationView view, ProductModel selectedProduct) {

            _view = view;

            SelectedProduct = selectedProduct;

            _destinationMapper = new DestinationMapper();

            _transportMapper = new TransportMapper();

            _productMapper = new ProductMapper();

            _orderMapper = new OrderMapper();

            _orderStatusMapper = new OrderStatusMapper();

            _unitOfWork = new UnitOfWork(new ApplicationContext());

            destinationService = new DestinationService(_unitOfWork.DestinationRepository);

            transportService = new TransportService(_unitOfWork.TransportRepository);

            orderService = new OrderService(_unitOfWork.OrderRepository);

            OrderStatusService = new OrderStatusService(_unitOfWork.OrderStatusRepository);

            destinations = destinationService.GetAllDestinations().Select(dest => _destinationMapper.FromDomainToModel(dest)).ToList();

            _view.DisplayData(destinations);

            _view.DestinationSelected += BeginOrderCreation;
        
        }

        public void BeginOrderCreation() {

            if (_view.SelectedDestination == null)
            {

                _view.DestinationWasntSelected();

            }
            else {

        
                OrderModel newOrder = _orderMapper.FromDomainToModel(orderService.CreateAnOrder(_destinationMapper.FromModelToDomain(_view.SelectedDestination), _productMapper.FromModelToDomain(SelectedProduct), transportService.GetSuitableTransport(_productMapper.FromModelToDomain(SelectedProduct))));

                newOrder.Status = _orderStatusMapper.FromDomainToModel(OrderStatusService.GetStatusByID(1));

                orderService.AddOrder(_orderMapper.FromModelToDomain(newOrder));

                _unitOfWork.Complete();

                //_unitOfWork.OrderRepository.Add(_orderMapper.FromDomainToEntity(_orderMapper.FromModelToDomain(newOrder)));


                newOrder.InvolvedTransport.InTheShop = false;

                transportService.UpdateTransport(_transportMapper.FromModelToDomain(newOrder.InvolvedTransport));

                _view.DisplayCurrentOrderInfo(newOrder);

                _unitOfWork.Complete();

                _unitOfWork.Dispose();
            }

            
        
        }
    }
}
