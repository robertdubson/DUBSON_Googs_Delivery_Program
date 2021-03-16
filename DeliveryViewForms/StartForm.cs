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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            
            
        }

        private void seeAllProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();

            ProductPresenter presenter = new ProductPresenter(productForm);

            productForm.Show();

            this.Hide();

            //this.Dispose();

            

            
        }
    }
}
