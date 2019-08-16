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
using System.Drawing.Printing;

/// <summary>
/// APP-Name: Dollar's Computer
/// Author's Name: Kharak Singh Kular
/// Creation Date: 15/8/2019
/// Description: This form is for displaying the product cost information
/// </summary>
namespace Lab11_KharakSingh_301042015.Views
{
    public partial class OrderForm : Form
    {
        //instance fields
        public const decimal TAX_RATE_ON_PRODUCT = 0.13m;
        private decimal _totalProductPrice;
        
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for Next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for shopping. \n\nYour order will be prodessed in 7-10 business days.",
                "Your order", MessageBoxButtons.OK);
            Application.Exit();
        }

        /// <summary>
        /// Event handler for exit item in Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// Event handler for creating event every time the form displays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event handler for event of displaying About box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }

        /// <summary>
        /// Event handler for displaying print preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your product selection is printing", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Form.StartPosition = FormStartPosition.CenterScreen;
            //ProductPrintForm.centre
            ProductPrintForm.Print();
            
        }
    }
}
