using System;
using Lab11_KharakSingh_301042015.Views;
using Lab11_KharakSingh_301042015.Controls;
using Lab11_KharakSingh_301042015.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_KharakSingh_301042015
{
    static class Program
    {
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

            Application.Run(Forms[FormName.SPLASH_SCREEN]);
        }
    }
}
