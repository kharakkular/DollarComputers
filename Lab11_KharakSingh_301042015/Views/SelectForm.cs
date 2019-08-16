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
using Lab11_KharakSingh_301042015.Model;
using System.Data.Entity;

/// <summary>
/// APP-Name: Dollar's Computer
/// Author's Name: Kharak Singh Kular
/// Creation Date: 15/8/2019
/// Description: This form is for displaying all products for selecting
/// </summary>
namespace Lab11_KharakSingh_301042015.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (SelectProductDataGridView.Rows[SelectProductDataGridView.CurrentCell.RowIndex].Selected)
            {
                Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
                this.Hide();
            }
            else
            {
                NextButton.BackColor = Color.Blue;
                NextButton.ForeColor = Color.Transparent;
            }
            
        }

        /// <summary>
        /// Event handler for cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for loading form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            SelectedComputerInformationLabel.Text = null;

            using(var db = new ProductModel())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
            var rowIndex = SelectProductDataGridView.CurrentCell.RowIndex;
            SelectProductDataGridView.Rows[rowIndex].Selected = false;
            SelectedComputerInformationLabel.Text = string.Empty;
        }

        /// <summary>
        /// Event handler for selection of item every time it is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectProductDataGridView.SelectedRows.Count == 1)
            {
                NextButton.BackColor = Color.Silver;
                NextButton.ForeColor = Color.Black;

                int rowIndex = SelectProductDataGridView.CurrentCell.RowIndex;
                var rows = SelectProductDataGridView.Rows;
                var columnCount = SelectProductDataGridView.ColumnCount;
                var cells = rows[rowIndex].Cells;

                rows[rowIndex].Selected = true;

                string outPutString = string.Empty;

                for (int i = 0; i < columnCount; i++)
                {
                    if (i == 0)
                    {
                        Program.product.productID = short.Parse(cells[i].Value.ToString());
                    }
                    if (i == 1)
                    {
                        Program.product.cost = decimal.Parse(cells[i].Value.ToString());
                    }
                    if (i==2)
                    {
                        Program.product.manufacturer = cells[i].Value.ToString();
                    }
                  
                    if (i==3)
                    {
                        Program.product.model = cells[i].Value.ToString();
                    }
                    if (i==4)
                    {
                        Program.product.RAM_type = cells[i].Value.ToString();
                        
                    }
                    if (i==5)
                    {
                        Program.product.RAM_size = cells[i].Value.ToString();
                    }
                    if (i==6)
                    {
                        Program.product.displaytype = cells[i].Value.ToString();
                    }
                    if (i==7)
                    {
                        Program.product.screensize = cells[i].Value.ToString();
                    }
                    if (i==8)
                    {
                        Program.product.resolution = cells[i].Value.ToString();
                    }
                    if (i==9)
                    {
                        Program.product.CPU_Class = cells[i].Value.ToString();
                    }
                    if (i==10)
                    {
                        Program.product.CPU_brand = cells[i].Value.ToString();
                    }
                    if (i==11)
                    {
                        Program.product.CPU_type = cells[i].Value.ToString();
                    }
                    if (i==12)
                    {
                        Program.product.CPU_speed = cells[i].Value.ToString();
                    }
                    if (i==13)
                    {
                        Program.product.CPU_number = cells[i].Value.ToString();
                    }
                    if (i==14)
                    {
                        Program.product.condition = cells[i].Value.ToString();
                    }
                    if (i==15)
                    {
                        Program.product.OS = cells[i].Value.ToString();
                    }
                    if (i==16)
                    {
                        Program.product.platform = cells[i].Value.ToString();
                    }
                    if (i==17)
                    {
                        Program.product.HDD_size = cells[i].Value.ToString();
                    }
                    if (i==18)
                    {
                        Program.product.HDD_speed = cells[i].Value.ToString();
                    }
                    if (i==19)
                    {
                        Program.product.GPU_Type = cells[i].Value.ToString();
                    }
                    if (i==20)
                    {
                        Program.product.optical_drive = cells[i].Value.ToString();
                    }
                    if (i==21)
                    {
                        Program.product.Audio_type = cells[i].Value.ToString();
                    }
                    if (i==22)
                    {
                        Program.product.LAN = cells[i].Value.ToString();
                    }
                    if (i==23)
                    {
                        Program.product.WIFI = cells[i].Value.ToString();
                    }
                    if (i==24)
                    {
                        Program.product.width = cells[i].Value.ToString();
                    }
                    if (i==25)
                    {
                        Program.product.height = cells[i].Value.ToString();
                    }
                    if (i==26)
                    {
                        Program.product.depth = cells[i].Value.ToString();
                    }
                    if (i==27)
                    {
                        Program.product.weight = cells[i].Value.ToString();
                    }
                    if (i==28)
                    {
                        Program.product.moust_type = cells[i].Value.ToString();
                    }
                    if (i==29)
                    {
                        Program.product.power = cells[i].Value.ToString();
                    }
                    if (i==30)
                    {
                        Program.product.webcam = cells[i].Value.ToString();
                    }
                }

                outPutString = "Company- " + Program.product.manufacturer + ", Model- " 
                                + Program.product.model  + ", Cost- " + String.Format("{0:c}",Program.product.cost);

                SelectedComputerInformationLabel.Text = outPutString;
            }

        }
    }
}
