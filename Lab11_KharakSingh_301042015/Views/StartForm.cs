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

/// <summary>
/// APP-Name: Dollar's Computer
/// Author's Name: Kharak Singh Kular
/// Creation Date: 15/8/2019
/// Description: This form is the start form of the Application
/// </summary>
namespace Lab11_KharakSingh_301042015.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for New order button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// Event handler for exit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for open saved order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSaveOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.IsOpenSavedOrderPressed = true;
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();


        }
    }
}
