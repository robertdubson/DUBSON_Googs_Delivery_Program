using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Services;
using DataLib;
using Mappers;

namespace ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ProductModel currentProduct;

        public void OnPropertyChanged(string propertyName) {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        ProductService productService;

        ProductMapper productMapper;

        private List<ProductModel> modelObjects;

        public ProductViewModel() {

            productService = new ProductService(new DataInitializer().productRepository);

            productMapper = new ProductMapper();

            modelObjects = new List<ProductModel>();

            LoadData();
        
        }

        public List<ProductModel> ModelObjects { get { return modelObjects; } set { modelObjects = value; OnPropertyChanged("modelObjects"); } }

        public ProductModel CurrentProduct { get { return currentProduct; } set { currentProduct = value; OnPropertyChanged("currentProduct"); } }

        public void LoadData() {

            modelObjects = productService.GetAllProducts().Select(prod => productMapper.FromDomainToModel(prod)).ToList();
        
        }
    }
}
