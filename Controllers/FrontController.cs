using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Domain;
using DataLib;
using DataLib.UnitOfWork;
namespace Controllers
{
    public class FrontController
    {
        TransportService _transportService;
        ProductService _productService;
        DestinationService _destinationService;

        IUnitOfWork unitOfWork;

        public FrontController(DataInitializer dataInitializer) {

            //unitOfWork = new UnitOfWork(new ApplicationContext());
            
            _transportService = new TransportService(unitOfWork);

            _productService = new ProductService(unitOfWork);

            _destinationService = new DestinationService(unitOfWork);
        
        
        }
    }
}
