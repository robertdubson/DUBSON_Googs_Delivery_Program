using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presenters;

namespace DeliveryViewForms
{
    public partial class DestinationsForm : Form, IDestinationView
    {
        public ProductModel SelectedProduct { get; set; }

        public DestinationModel SelectedDestination { get { return listBoxDestinations.SelectedItem as DestinationModel; } set { } }

        public event Action DestinationSelected;

        public void DisplayData(List<DestinationModel> destinations) {

            this.listBoxDestinations.DataSource = destinations;
            
        }


        public DestinationsForm()
        {
            InitializeComponent();
        }

        

        public DestinationsForm(ProductModel product) {

            InitializeComponent();

            SelectedProduct = product;

            BindComponent();

        }

        public void DisplayCurrentOrderInfo(OrderModel order) {

            MessageBox.Show("Ви замовили продукт " + order.Product.Name + ", що коштує " + order.Product.Price + " $ . Товар буде доставлено до пункту " + order.Destination.Name + "за " + order.TimeNeededForDelivery + " одиниць часу");
        
        }

        public void BindComponent()
        {

            buttonSelectDestination.Click += buttonSelectDestination_Click;
            //listBoxDestinations.SelectedIndexChanged += listBoxDestinations_SelectedIndexChanged;

        }

        private void listBoxDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSelectDestination_Click(object sender, EventArgs e)
        {
            if (this.DestinationSelected != null)
            {

                this.DestinationSelected();

            }
        }

        public void DestinationWasntSelected() {

            MessageBox.Show("Будь ласка, оберіть пункт призначення!");
        
        }
    }
}
