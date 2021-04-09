using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Services;
using Mappers;
using DataLib;

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

        DestinationService destinationService;

        TransportService transportService;

        OrderService orderService;

        public DestinationPresenter(IDestinationView view, ProductModel selectedProduct) {

            _view = view;

            SelectedProduct = selectedProduct;

            _destinationMapper = new DestinationMapper();

            _transportMapper = new TransportMapper();

            _productMapper = new ProductMapper();

            _orderMapper = new OrderMapper();

            destinationService = new DestinationService(new DataInitializer().destinationRepository);

            transportService = new TransportService(new DataInitializer().transportRepository);

            orderService = new OrderService(new DataInitializer().orderRepository);

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

                orderService.AddOrder(_orderMapper.FromModelToDomain(newOrder));

                transportService.UpdateTransport(_transportMapper.FromModelToDomain(newOrder.InvolvedTransport));

                _view.DisplayCurrentOrderInfo(newOrder);


            }

            
        
        }
    }
}
