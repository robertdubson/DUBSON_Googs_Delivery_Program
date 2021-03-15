﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;

namespace DeliveryViewForms
{
    public partial class ProductForm : Form, IProductView
    {
        public event Action ProductSelected;

        public event Action CategorySelected;

        public Dictionary<string, DeliveryTypeModel> DeliveryTypes { get; set; }

        public Dictionary<string, ProductModel> Products { get; set; }
        public ProductModel SelectedProduct { get { return listBoxProducts.SelectedItem as ProductModel; } set { } }

        public DeliveryTypeModel SelectedType { get { return listBoxDeliveryTypes.SelectedItem as DeliveryTypeModel; } set { } }

        public ProductForm()
        {
            InitializeComponent();

            BindComponent();

            DeliveryTypes = new Dictionary<string, DeliveryTypeModel>();

            Products = new Dictionary<string, ProductModel>();
        
        }



        public void BindComponent() {

            
            this.listBoxProducts.SelectedIndexChanged +=
                listBoxProducts_SelectedIndexChanged;

            this.listBoxDeliveryTypes.SelectedIndexChanged +=
                listBoxDeliveryTypes_SelectedIndexChanged;

        }

       

        

        public void DisplayData(List<DeliveryTypeModel> deliveryTypeItems, List<ProductModel> productItems)
        {

            listBoxDeliveryTypes.DataSource = deliveryTypeItems;

            listBoxProducts.DataSource = productItems;
            //foreach (DeliveryTypeModel delType in deliveryTypeItems) {

                //listBoxDeliveryTypes.Items.Add(delType.ToString());

               // DeliveryTypes.Add(delType.ToString(), delType);
            
            //}

            //foreach (ProductModel prod in productItems) {

                //listBoxProducts.Items.Add(prod.ToString());

               //Products.Add(prod.ToString(), prod);
            
            //}
        }

        public void ProdSel()
        {
            MessageBox.Show("PrODUCT WAS SELECTED");
        }

        public void CatSel()
        {
            MessageBox.Show("CATEGORY WAS SELECTED");
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ProductSelected != null)
            {
                this.ProductSelected();
            }
        }

        private void listBoxDeliveryTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CategorySelected != null)
            {
                this.CategorySelected();
            }
        }
    }
}
