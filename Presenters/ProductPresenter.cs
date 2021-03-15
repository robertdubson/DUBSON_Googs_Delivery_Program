using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;
using Services;
using Mappers;
using DataLib;
using Domain;
namespace Presenters
{
    public class ProductPresenter
    {
        ProductService _productService;

        ProductMapper productMapper;

        DeliveryTypeMapper deliveryTypeMapper;

        List<DeliveryTypeModel> deliveryTypes;

        List<ProductModel> products;

        IProductView _view;

        public ProductPresenter(IProductView view) {

            _productService = new ProductService(new DataInitializer().productRepository);

            productMapper = new ProductMapper();

            deliveryTypeMapper = new DeliveryTypeMapper();

            deliveryTypes = _productService.GetAllTypes().Select(delType => deliveryTypeMapper.FromDomainToModel(delType)).ToList();

            products = _productService.GetAllProducts().Select(prod => productMapper.FromDomainToModel(prod)).ToList();

            _view = view;

            _view.DisplayData(deliveryTypes, products);

            _view.ProductSelected += SelectTheProduct;

            _view.CategorySelected += RebuildCategoryTable;

            //this.initialize();

            

        }

        public void OnDataSelected()
        {
            if (this._view.SelectedProduct != null)
            {
                //this.view.LoadData(this.view.SelectedData);
                
            }
        }

        //public void initialize() {

           // _view.CategorySelected += RebuildCategoryTable;

            //_view.ProductSelected += SelectTheProduct;
        //}

        public void SelectTheProduct() {

            //_view.ProdSel();
        
        }

        public void RebuildCategoryTable() {

            //_view.CatSel();
            
            //List<ProductModel> allProducts = products;

            _view.DisplayData(deliveryTypes, _productService.GetProductsByType(deliveryTypeMapper.FromModelToDomain(this._view.SelectedType)).Select(prod => productMapper.FromDomainToModel(prod)).ToList());
        
        }

    }
}
