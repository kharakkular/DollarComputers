using System;
using Lab11_KharakSingh_301042015.Views;
using Lab11_KharakSingh_301042015.Controls;
using Lab11_KharakSingh_301042015.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// APP-Name: Dollar's Computer
/// Author's Name: Kharak Singh Kular
/// Creation Date: 15/8/2019
/// Description: This is the main class of the program from which the application runs
/// </summary>
namespace Lab11_KharakSingh_301042015
{
    static class Program
    {
        public static bool IsOpenSavedOrderPressed;
        public static Dictionary<FormName, Form> Forms;
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());
            
            product = new Product();
            IsOpenSavedOrderPressed = false;
            Application.Run(Forms[FormName.SPLASH_SCREEN]);
        }
    }
}
