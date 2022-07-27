using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestClientUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void rekwestLogo_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {

            CreateProductForm form = new CreateProductForm();
            form.Show();
        }

        private void listProductsButton_Click(object sender, EventArgs e)
        {
            ListProductsForm form = new ListProductsForm();
            form.Show();
        }
    }
}
