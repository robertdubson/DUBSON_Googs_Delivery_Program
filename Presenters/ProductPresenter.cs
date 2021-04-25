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
using DataLib.UnitOfWork;

namespace Presenters
{
    public class ProductPresenter
    {
        ProductService _productService;

        ProductMapper productMapper;

        DeliveryTypeMapper deliveryTypeMapper;

        List<DeliveryTypeModel> deliveryTypes;

        DeliveryTypeService _deliveryTypeService;

        List<ProductModel> products;

        IProductView _view;

        UnitOfWork _unitOFWork;

        public ProductPresenter(IProductView view) {

            

            productMapper = new ProductMapper();

            deliveryTypeMapper = new DeliveryTypeMapper();

            _unitOFWork = new UnitOfWork(new ApplicationContext());

            _productService = new ProductService(_unitOFWork.ProductRepository);

            _deliveryTypeService = new DeliveryTypeService(_unitOFWork.DeliveryTypeRepository);

            deliveryTypes = _deliveryTypeService.GetAllDeliveryTypes().Select(delType => deliveryTypeMapper.FromDomainToModel(delType)).ToList();

            products = _productService.GetAllProducts().Select(prod => productMapper.FromDomainToModel(prod)).ToList();

            _view = view;

            _view.DisplayData(deliveryTypes, products);

            _view.ProductSelected += SelectTheProduct;

            _view.CategorySelected += RebuildCategoryTable;

            _view.textChanged += FindByText;

            _view.parametersChanged += FindByParameters;

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

        public void FindByText() {

            _view.DisplayData(deliveryTypes, _productService.FindByText(_view.InsertedText).Select(prod => productMapper.FromDomainToModel(prod)).ToList());
        
        }

        public void FindByParameters() {

            _view.DisplayData(deliveryTypes, _productService.FindByParameters(Convert.ToDouble(_view.maxWeight), Convert.ToDouble(_view.minWeight), Convert.ToDouble(_view.minVolume), Convert.ToDouble(_view.maxVolume), Convert.ToDouble(_view.maxPrice), Convert.ToDouble(_view.minPrice)).Select(prod => productMapper.FromDomainToModel(prod)).ToList());

            _unitOFWork.Complete();
        }

        public void SelectTheProduct() {

            //_view.ProdSel();
        
        }

        public void RebuildCategoryTable() {

            //_view.CatSel();
            
            //List<ProductModel> allProducts = products;

            _view.DisplayData(deliveryTypes, _productService.GetProductsByType(deliveryTypeMapper.FromModelToDomain(this._view.SelectedType)).Select(prod => productMapper.FromDomainToModel(prod)).ToList());

            _unitOFWork.Complete();
        
        }

    }
}
