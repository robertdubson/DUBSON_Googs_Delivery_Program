using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Domain;
using DataLib;

namespace Controllers
{
    public class FrontController
    {
        TransportService _transportService;
        ProductService _productService;
        DestinationService _destinationService;

        public FrontController(DataInitializer dataInitializer) {

            _transportService = new TransportService(dataInitializer.transportRepository);

            _productService = new ProductService(dataInitializer.productRepository);

            _destinationService = new DestinationService(dataInitializer.destinationRepository);
        
        
        }
    }
}
