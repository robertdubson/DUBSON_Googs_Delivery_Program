using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Mappers;
using Model;
using DataLib;
using DataLib.UnitOfWork;

namespace Presenters
{
    public class OrdersPresenter
    {
        IOrderView _view;

        OrderService orderService;

        OrderMapper orderMapper;

        List<OrderModel> orders;

        UnitOfWork _unitOfWork;


        public OrdersPresenter(IOrderView view) {

            _view = view;

            _unitOfWork = new UnitOfWork(new ApplicationContext());

            orderService = new OrderService(_unitOfWork.OrderRepository);

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

                orderService.DeleteOrder(_view.SelectedOrder.ID);

                _unitOfWork.Complete();

                _view.DisplayData(orderService.GetAllOrders().Select(ord => orderMapper.FromDomainToModel(ord)).ToList());

                
                
                //_unitOfWork.Dispose();

            }
            
        
        }
    }
}
