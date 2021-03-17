using Model;
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

        public event Action parametersChanged;

        public event Action textChanged;

        public string InsertedText { get { return textBox1.Text; } }

        public decimal minWeight { get { return numericUpDownMinWeight.Value; } }

        public decimal maxWeight { get { return numericUpDownMaxWeight.Value; } }

        public decimal minVolume { get { return numericUpDownMinVolume.Value; } }

        public decimal maxVolume { get { return numericUpDownMaxVolume.Value; } }

        public decimal minPrice { get { return numericUpDownMinPrice.Value; } }

        public decimal maxPrice { get { return numericUpDownMinWeight.Value; } }


        // public event Action GetBack;

        // public event Action GoToDestinationSelection;

        public ProductModel SelectedProduct { get { return listBoxProducts.SelectedItem as ProductModel; } set { } }

        public DeliveryTypeModel SelectedType { get { return listBoxDeliveryTypes.SelectedItem as DeliveryTypeModel; } set { } }

        public ProductForm()
        {
            
            InitializeComponent();

            setNumericsMaxMinValues();

            BindComponent();

        }

        


        public void BindComponent() {

            
            this.listBoxProducts.SelectedIndexChanged +=
                listBoxProducts_SelectedIndexChanged;

            this.listBoxDeliveryTypes.SelectedIndexChanged +=
                listBoxDeliveryTypes_SelectedIndexChanged;

            this.numericUpDownMinWeight.ValueChanged += numericUpDownMinWeight_ValueChanged;

            this.numericUpDownMaxWeight.ValueChanged += numericUpDownMaxWeight_ValueChanged;

            this.numericUpDownMaxVolume.ValueChanged += numericUpDownMaxVolume_ValueChanged;

            this.numericUpDownMinVolume.ValueChanged += numericUpDownMinVolume_ValueChanged;

            this.numericUpDownMinPrice.ValueChanged += numericUpDownMinPrice_ValueChanged;

            this.numericUpDownMaxPrice.ValueChanged += numericUpDownMaxPrice_ValueChanged;

            this.textBox1.TextChanged += textBox1_TextChanged;

        }

        private void setNumericsMaxMinValues()
        {

            this.numericUpDownMinWeight.Maximum = 9999;

            this.numericUpDownMinWeight.Minimum = 0;

            this.numericUpDownMaxWeight.Maximum = 9999;

            this.numericUpDownMaxWeight.Minimum = 0;

            this.numericUpDownMinVolume.Maximum = 9999;

            this.numericUpDownMinVolume.Minimum = 0;

            this.numericUpDownMaxVolume.Maximum = 9999;

            this.numericUpDownMaxVolume.Minimum = 0;

            this.numericUpDownMinPrice.Maximum = 9999;

            this.numericUpDownMinPrice.Minimum = 0;

            this.numericUpDownMaxPrice.Maximum = 9999;

            this.numericUpDownMaxPrice.Minimum = 0;


        }


        public void DisplayData(List<DeliveryTypeModel> deliveryTypeItems, List<ProductModel> productItems)
        {

            listBoxDeliveryTypes.DataSource = deliveryTypeItems;

            listBoxProducts.DataSource = productItems;
            
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



        private void buttonBack_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();

            this.Hide();
            
            this.Dispose();

            startForm.Show();

                 
        }

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            DestinationsForm destinationForm = new DestinationsForm(SelectedProduct);

            this.Hide();
            this.Dispose();

            DestinationPresenter destinationPresenter = new DestinationPresenter(destinationForm, SelectedProduct);

            destinationForm.Show();
        
        }

        private void numericUpDownMinWeight_ValueChanged(object sender, EventArgs e)
        {
            if (this.parametersChanged != null)
            {

                this.parametersChanged();

            }
        }

        private void numericUpDownMaxWeight_ValueChanged(object sender, EventArgs e)
        {
            if (this.parametersChanged != null)
            {

                this.parametersChanged();

            }
        }

        private void numericUpDownMinVolume_ValueChanged(object sender, EventArgs e)
        {
            if (this.parametersChanged != null)
            {

                this.parametersChanged();

            }
        }

        private void numericUpDownMaxVolume_ValueChanged(object sender, EventArgs e)
        {
            if (this.parametersChanged != null)
            {

                this.parametersChanged();

            }
        }

        private void numericUpDownMinPrice_ValueChanged(object sender, EventArgs e)
        {
            if (this.parametersChanged != null)
            {

                this.parametersChanged();

            }
        }

        private void numericUpDownMaxPrice_ValueChanged(object sender, EventArgs e)
        {
            if (this.parametersChanged != null)
            {

                this.parametersChanged();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textChanged!=null) {

                this.textChanged();
            
            }
        }
    }
}
