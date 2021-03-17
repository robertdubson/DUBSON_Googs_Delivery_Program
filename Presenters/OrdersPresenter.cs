using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Mappers;
using Model;
using DataLib;

namespace Presenters
{
    public class OrdersPresenter
    {
        IOrderView _view;

        OrderService orderService;

        OrderMapper orderMapper;

        List<OrderModel> orders;

        public OrdersPresenter(IOrderView view) {

            _view = view;

            orderService = new OrderService(new DataInitializer().orderRepository);

            orderMapper = new OrderMapper();

            orders = orderService.GetAllOrders().Select(ord => orderMapper.FromDomainToModel(ord)).ToList();

            _view.DisplayData(orders);

            _view.OrderCanceled += CancelOrder;
        
        }

        public void CancelOrder() {

            if (_view.SelectedOrder == null)
            {
                _view.OrderWasntselected();
            }
            else {

                orderService.DeleteOrder(orderMapper.FromModelToDomain(_view.SelectedOrder));

                _view.DisplayData(orderService.GetAllOrders().Select(ord => orderMapper.FromDomainToModel(ord)).ToList());

            }
            
        
        }
    }
}
