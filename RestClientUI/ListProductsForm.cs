using RestClientLibray.Controllers;
using RestClientLibray.Models;
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
    public partial class ListProductsForm : Form
    {
        public ListProductsForm()
        {
            InitializeComponent();
            LoadDataGridView();
            populateGridView();
        }

        private void LoadDataGridView()
        {

            productsDataGridView.CellClick += productsDataGridView_CellClick;
            productsDataGridView.ColumnHeadersVisible = true;

            productsDataGridView.ColumnCount = 12;

            // Set the column header names.
            productsDataGridView.Columns[0].Name = "Id";
            productsDataGridView.Columns[1].Name = "Identifier";
            productsDataGridView.Columns[2].Name = "Description";
            productsDataGridView.Columns[3].Name = "DescriptionEN";
            productsDataGridView.Columns[4].Name = "Price";
            productsDataGridView.Columns[5].Name = "Unit";
            productsDataGridView.Columns[6].Name = "AvailableSTK";
            productsDataGridView.Columns[7].Name = "Vat";
            productsDataGridView.Columns[8].Name = "Inactive";
            productsDataGridView.Columns[9].Name = "ComponentType";
            productsDataGridView.Columns[10].Name = "RemoteId";
            DataGridViewButtonColumn actionButton = new DataGridViewButtonColumn();
            actionButton.Name = "action";
            actionButton.Text = "Actualizar Produto";
            productsDataGridView.Columns.Insert(11, actionButton);
            actionButton.UseColumnTextForButtonValue = true;


        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == productsDataGridView.Columns["action"].Index)
            {
                ProductModel selectedProduct = new ProductModel();
                selectedProduct.RemoteId = int.Parse(productsDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString());
                selectedProduct.Id = int.Parse(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                selectedProduct.Identifier = productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                selectedProduct.Description = productsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                selectedProduct.DescriptionEN = productsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                selectedProduct.Price = decimal.Parse(productsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                selectedProduct.Unit = productsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                selectedProduct.AvailableSTK = int.Parse(productsDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
                selectedProduct.Vat = int.Parse(productsDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                selectedProduct.Inactive = bool.Parse(productsDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());
                UpdateProductForm form = new UpdateProductForm();
                form.Show();
               form.fillFormInputs(selectedProduct);
                //Do something with your button.
            }
        }

        public async void populateGridView()
        {

            List<ProductModel> products = await ProductController.GetProducts();
            


            for (int i = 0; i < products.Count; i++)
            {
                //gotta makeit an arra
                string[] str = new string[]
                {
                      products[i].Id + "",
                      products[i].Identifier,
                      products[i].Description,
                      products[i].DescriptionEN,
                      products[i].Price + "",
                      products[i].Unit,
                      products[i].AvailableSTK.ToString(),
                      products[i].Vat.ToString(),
                      products[i].Inactive.ToString(),
                      products[i].ComponentType.ToString(),
                      products[i].RemoteId.ToString()
                };

                productsDataGridView.Rows.Add(str);
            }
            productsDataGridView.Refresh();

        }





    }
}
