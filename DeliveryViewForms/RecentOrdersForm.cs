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
    public partial class RecentOrdersForm : Form, IOrderView
    {
        public event Action OrderCanceled;

        public OrderModel SelectedOrder { get { return listBoxRecentOrders.SelectedItem as OrderModel; } }

        public RecentOrdersForm()
        {
            InitializeComponent();

            BindComponent();
        }

        private void BindComponent() {

            buttonCancelTheOrder.Click += buttonCancelTheOrder_Click;
        
        }

        private void buttonGetBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            StartForm startForm = new StartForm();

            startForm.Show();
        }

        public void DisplayData(List<OrderModel> orders) {

            listBoxRecentOrders.DataSource = orders;
        
        }

        private void buttonCancelTheOrder_Click(object sender, EventArgs e)
        {           

                OrderCanceled();               

        }

        public void OrderWasntselected() {

            MessageBox.Show("Будь ласка, оберіть замовлення, від якого хочете відмовитись.");        
        }
    }
}
