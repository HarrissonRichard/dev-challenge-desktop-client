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
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
        }

        private async void createNewProductButton_Click(object sender, EventArgs e)
        {

            try
            {
                await SaveProduct();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private async Task SaveProduct()
        {

            if (!ValidateNewProductForm())
            {
                MessageBox.Show("Corrija todos erros e tente de novo");

            }
            else
            {
                ProductModel product = new ProductModel
                {

                    Identifier = newProductIdentifierValue.Text,
                    Description = newProductDescriptionValue.Text,
                    DescriptionEN = newProductDescriptionENValue.Text,
                    Price = decimal.Parse(newProductPriceValue.Text),
                    Unit = newProductUnitValue.Text,
                    AvailableSTK = int.Parse(newProductAvailableStkValue.Text),
                    Vat = int.Parse(newProductVatValue.Text)
                };

                var newProduct = await ProductController.CreateRemoteProduct(product);
                product.RemoteId = newProduct.Id;
                await ProductController.CreateLocalProduct(product);

                MessageBox.Show("Produto Adicionado!");

               newProductIdentifierValue.Text = "";
                newProductDescriptionValue.Text = "";
                newProductDescriptionENValue.Text = "";
                newProductPriceValue.Text = "";
                newProductUnitValue.Text = "";
                newProductAvailableStkValue.Text = "";
                newProductVatValue.Text = "";

            }



        }


        private bool ValidateNewProductForm()
        {
            bool isValid = true;

            if (newProductIdentifierValue.Text.Length < 0)
            {

                MessageBox.Show("Por Favor introduza um identificador valido, pelo menos 5 caracteres");
                isValid = false;
            }
            if (newProductDescriptionValue.Text.Length < 5)
            {
                MessageBox.Show("A descricao precisa pelo menos 5 caracteres");
                isValid = false;
            }
            decimal price = 0;
            bool validPrice = decimal.TryParse(newProductPriceValue.Text, out price);
            if (!(validPrice && (price >= 0)))
            {
                MessageBox.Show("Introduza um preco valido");
                isValid = false;
            }

            int availableSTK = 0;
            bool validSTK = int.TryParse(newProductAvailableStkValue.Text, out availableSTK);
            if (!(validSTK && (availableSTK >= 0)))
            {
                MessageBox.Show("Introduza um stock valido");
                isValid = false;
            }

            int vat = 0;
            bool validVat = int.TryParse(newProductVatValue.Text, out vat);
            if (!(validVat) && (vat >= 0))
            {
                MessageBox.Show("Introduza um VAT valido");
                isValid = false;
            }


            if (newProductUnitValue.Text.Length < 0)
            {
                MessageBox.Show("Introduza o tipo de unidade do produto");
                isValid = false;
            }

            return isValid;
        }

        private void newProductDescriptionENValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
