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
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        public void fillFormInputs(ProductModel product)
        {
            idNotToUpdateValue.Text = product.Id.ToString();
            remoteIdNotToUpdateValue.Text = product.RemoteId.ToString();
            identifierToUpdateValue.Text = product.Identifier;
            descriptionToUpdateValue.Text = product.DescriptionEN;
            descriptionENToUpdateValue.Text = product.DescriptionEN;
            availableSTKToUpdateValue.Text = product.AvailableSTK.ToString();
            priceToUpdateValue.Text = product.Price.ToString();
            vatToUpdateValue.Text = product.Vat.ToString();
            unitToUpdateValue.Text = product.Unit.ToString();
            inactiveToUpdateValue.Checked = product.Inactive;
        }


        private bool ValidateUpdateProductForm()
        {
            bool isValid = true;

            if (identifierToUpdateValue.Text.Length < 0)
            {

                MessageBox.Show("Por Favor introduza um identificador valido, pelo menos 5 caracteres");
                isValid = false;
            }
            if (descriptionToUpdateValue.Text.Length < 5)
            {
                MessageBox.Show("A descricao precisa pelo menos 5 caracteres");
                isValid = false;
            }
            decimal price = 0;
            bool validPrice = decimal.TryParse(priceToUpdateValue.Text, out price);
            if (!(validPrice && (price >= 0)))
            {
                MessageBox.Show("Introduza um preco valido");
                isValid = false;
            }

            int availableSTK = 0;
            bool validSTK = int.TryParse(availableSTKToUpdateValue.Text, out availableSTK);
            if (!(validSTK && (availableSTK >= 0)))
            {
                MessageBox.Show("Introduza um stock valido");
                isValid = false;
            }

            int vat = 0;
            bool validVat = int.TryParse(vatToUpdateValue.Text, out vat);
            if (!(validVat) && (vat >= 0))
            {
                MessageBox.Show("Introduza um VAT valido");
                isValid = false;
            }


            if (unitToUpdateValue.Text.Length < 0)
            {
                MessageBox.Show("Introduza o tipo de unidade do produto");
                isValid = false;
            }

            return isValid;
        }

        private async void updateProduct()
        {

            try
            {

                if (!ValidateUpdateProductForm())
                {
                    MessageBox.Show("Corrija todos erros e tente de novo");
                    throw new Exception("Error");
                }

                ProductModel product = new ProductModel
                {
                    Id = int.Parse(idNotToUpdateValue.Text),
                    RemoteId = int.Parse(remoteIdNotToUpdateValue.Text),
                    Identifier = identifierToUpdateValue.Text,
                    Description = descriptionToUpdateValue.Text,
                    DescriptionEN = descriptionENToUpdateValue.Text,
                    Price = decimal.Parse(priceToUpdateValue.Text),
                    Unit = unitToUpdateValue.Text,
                    Inactive = inactiveToUpdateValue.Checked,
                    AvailableSTK = int.Parse(availableSTKToUpdateValue.Text),
                    Vat = int.Parse(vatToUpdateValue.Text)
                };

                await ProductController.UpdateLocalProduct(product);
                var updatedProduct = await ProductController.UpdateRemoteProduct(product);

                MessageBox.Show("Produto Actualizado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception("Error");

            }


        }

        private void saveAlteredProductButton_Click(object sender, EventArgs e)
        {
            updateProduct();
        }
    }
}
