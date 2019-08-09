using System;
using Lab11_KharakSingh_301042015.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab11_KharakSingh_301042015.Views
{
    public partial class OrderForm : Form
    {
        public const decimal TAX_RATE_ON_PRODUCT = 0.13m;
        private decimal _totalProductPrice;
        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for shopping. \n\nYour order will be prodessed in 7-10 business days.",
                "Your order", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            try
            {
                if (Program.product.platform.ToLower() == "laptop")
                {
                    OrderFormPictureBox.Image = Properties.Resources.OrderFormLaptop;
                }
                else
                {
                    OrderFormPictureBox.Image = Properties.Resources.OrderFormDesktop;
                }
            }
            catch (Exception exception)
            {
                Debug.Write(exception.Message);
            }
           
            //update information in labels
            ProductPlatformTextLabel.Text = Program.product.platform;
            ProductManufacturerTextLabel.Text = Program.product.manufacturer;
            ProductConditionTextLabel.Text = Program.product.condition;
            ProductWebCamTextLabel.Text = Program.product.webcam;
            ProductResolutionTextLabel.Text = Program.product.resolution;
            ProductDisplayTypeTextLabel.Text = Program.product.displaytype;
            ProductPriceTextLabel.Text = string.Format("{0:C}",Program.product.cost);

            decimal priceOfProduct = Program.product.cost ?? 0m;
            
            var tax = priceOfProduct * TAX_RATE_ON_PRODUCT;
            _totalProductPrice = priceOfProduct + tax;

            ProductTaxTextLabel.Text = string.Format("{0:C}", tax);
            ProductTotalTextLabel.Text = string.Format("{0:C}", _totalProductPrice);


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }
    }
}
