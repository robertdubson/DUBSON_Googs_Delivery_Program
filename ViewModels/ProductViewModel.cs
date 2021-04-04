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

        public void OnPropertyChanged(string propertyName) {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        ProductService productService;

        ProductMapper productMapper;

        private List<ProductModel> modelObects;

        public ProductViewModel() {

            productService = new ProductService(new DataInitializer().productRepository);

            productMapper = new ProductMapper();

            modelObects = new List<ProductModel>();

            LoadData();
        
        }

        public List<ProductModel> ModelObjects { get { return modelObects; } set { modelObects = value; OnPropertyChanged("modelObjects"); } }

        public void LoadData() {

            modelObects = productService.GetAllProducts().Select(prod => productMapper.FromDomainToModel(prod)).ToList();
        
        }
    }
}
