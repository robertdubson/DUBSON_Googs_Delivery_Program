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
using DataLib;
namespace DeliveryViewForms
{
    public partial class StartForm : Form
    {
        DataInitializer dataInitializer;
        
        public StartForm()
        {
            InitializeComponent();

            dataInitializer = new DataInitializer();
            
        }

        private void seeAllProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();

            ProductPresenter presenter = new ProductPresenter(productForm);

            productForm.Show();

            this.Hide();

            //this.Dispose();

            

            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            this.Close();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();

            about.Show();

            this.Hide();
        }
    }
}
