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
/// Description: This form is the Splash form
/// </summary>
namespace Lab11_KharakSingh_301042015.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Splash timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// Event handler for load function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
