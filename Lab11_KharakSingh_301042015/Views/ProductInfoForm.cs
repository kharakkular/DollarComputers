﻿using System;
using Lab11_KharakSingh_301042015.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// APP-Name: Dollar's Computer
/// Author's Name: Kharak Singh Kular
/// Creation Date: 15/8/2019
/// Description: This form is for displaying the product information
/// </summary>
namespace Lab11_KharakSingh_301042015.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for closing application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for Next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ProductIDTextLabel.Text != "0" &&( ProductIDTextLabel.Text != null || ProductManufacturerTextLabel.Text != null))
            {
                Program.Forms[FormName.ORDER_FORM].Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Event Handler for Select another product button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// Event handler for generating event every time the form shows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextLabel.Text = Program.product.productID.ToString();
            ProductConditionTextLabel.Text = Program.product.condition;
            ProductCostTextLabel.Text = String.Format("{0:C}", Program.product.cost);
            ProductPlatformTextLabel.Text = Program.product.platform;
            ProductOperatingSystemTextLabel.Text = Program.product.OS;
            ProductManufacturerTextLabel.Text = Program.product.manufacturer;
            ProductModelTextLabel.Text = Program.product.model;
            ProductScreenSizeTextLabel.Text = Program.product.screensize;
            ProductRamTextLabel.Text = Program.product.RAM_size;
            ProductCpuBrandTextLabel.Text = Program.product.CPU_brand;
            ProductCpuSpeedTextLabel.Text = Program.product.CPU_speed;
            ProductHDDTextLabel.Text = Program.product.HDD_size;
            ProductCpuNumberTextLabel.Text = Program.product.CPU_number;

            if (Program.IsOpenSavedOrderPressed)
            {
                openToolStripMenuItem_Click(sender, e);
                Program.IsOpenSavedOrderPressed = false;
                this.BringToFront();
            }


        }

        /// <summary>
        /// Event handler for saving file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure the file dialog
            //var fileName = Program.product.manufacturer + "-" + Program.product.productID +".txt";
            ProductInfoSaveFileDialog.FileName = "Product.txt";
            ProductInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //Open file dialog
            var result = ProductInfoSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //Open a stream to write
                using(StreamWriter writer = new StreamWriter(File.Open(ProductInfoSaveFileDialog.FileName, 
                                                                            FileMode.Create)))
                {
                    writer.WriteLine(Program.product.productID.ToString());
                    writer.WriteLine(Program.product.cost.ToString());
                    writer.WriteLine(Program.product.manufacturer);
                    writer.WriteLine(Program.product.model);
                    writer.WriteLine(Program.product.RAM_type);
                    writer.WriteLine(Program.product.RAM_size);
                    writer.WriteLine(Program.product.displaytype);
                    writer.WriteLine(Program.product.screensize);
                    writer.WriteLine(Program.product.resolution);
                    writer.WriteLine(Program.product.CPU_Class);
                    writer.WriteLine(Program.product.CPU_brand);
                    writer.WriteLine(Program.product.CPU_type);
                    writer.WriteLine(Program.product.CPU_speed);
                    writer.WriteLine(Program.product.CPU_number);
                    writer.WriteLine(Program.product.condition);
                    writer.WriteLine(Program.product.OS);
                    writer.WriteLine(Program.product.platform);
                    writer.WriteLine(Program.product.HDD_size);
                    writer.WriteLine(Program.product.HDD_speed);
                    writer.WriteLine(Program.product.GPU_Type);
                    writer.WriteLine(Program.product.optical_drive);
                    writer.WriteLine(Program.product.Audio_type);
                    writer.WriteLine(Program.product.LAN);
                    writer.WriteLine(Program.product.WIFI);
                    writer.WriteLine(Program.product.width);
                    writer.WriteLine(Program.product.height);
                    writer.WriteLine(Program.product.depth);
                    writer.WriteLine(Program.product.weight);
                    writer.WriteLine(Program.product.moust_type);
                    writer.WriteLine(Program.product.power);
                    writer.WriteLine(Program.product.webcam);

                    //clean up
                    writer.Close();
                    writer.Dispose();

                    //saved file feedback to user
                    MessageBox.Show("File Saved", "Saving File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
        }

        /// <summary>
        /// Event handler for opening file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure the file dialog
            ProductInfoOpenFileDialog.FileName = "Product.txt";
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductInfoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //Open the file dialog
            var result = ProductInfoOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(File.Open(ProductInfoOpenFileDialog.FileName,
                                                                                FileMode.Open)))
                    {
                        Program.product.productID = short.Parse(reader.ReadLine());
                        Program.product.cost = decimal.Parse(reader.ReadLine());
                        Program.product.manufacturer = reader.ReadLine();
                        Program.product.model = reader.ReadLine();
                        Program.product.RAM_type = reader.ReadLine();
                        Program.product.RAM_size = reader.ReadLine();
                        Program.product.displaytype = reader.ReadLine();
                        Program.product.screensize = reader.ReadLine();
                        Program.product.resolution = reader.ReadLine();
                        Program.product.CPU_Class = reader.ReadLine();
                        Program.product.CPU_brand = reader.ReadLine();
                        Program.product.CPU_type = reader.ReadLine();
                        Program.product.CPU_speed = reader.ReadLine();
                        Program.product.CPU_number = reader.ReadLine();
                        Program.product.condition = reader.ReadLine();
                        Program.product.OS = reader.ReadLine();
                        Program.product.platform = reader.ReadLine();
                        Program.product.HDD_size = reader.ReadLine();
                        Program.product.HDD_speed = reader.ReadLine();
                        Program.product.GPU_Type = reader.ReadLine();
                        Program.product.optical_drive = reader.ReadLine();
                        Program.product.Audio_type = reader.ReadLine();
                        Program.product.LAN = reader.ReadLine();
                        Program.product.WIFI = reader.ReadLine();
                        Program.product.width = reader.ReadLine();
                        Program.product.height = reader.ReadLine();
                        Program.product.depth = reader.ReadLine();
                        Program.product.weight = reader.ReadLine();
                        Program.product.moust_type = reader.ReadLine();
                        Program.product.power = reader.ReadLine();
                        Program.product.webcam = reader.ReadLine();
                    
                        reader.Close();
                        reader.Dispose();
                    }

                    // Updates information in the labels of the form
                    ProductIDTextLabel.Text = Program.product.productID.ToString();
                    ProductConditionTextLabel.Text = Program.product.condition;
                    ProductCostTextLabel.Text = String.Format("{0:C}", Program.product.cost);
                    ProductPlatformTextLabel.Text = Program.product.platform;
                    ProductOperatingSystemTextLabel.Text = Program.product.OS;
                    ProductManufacturerTextLabel.Text = Program.product.manufacturer;
                    ProductModelTextLabel.Text = Program.product.model;
                    ProductScreenSizeTextLabel.Text = Program.product.screensize;
                    ProductRamTextLabel.Text = Program.product.RAM_size;
                    ProductCpuBrandTextLabel.Text = Program.product.CPU_brand;
                    ProductCpuSpeedTextLabel.Text = Program.product.CPU_speed;
                    ProductHDDTextLabel.Text = Program.product.HDD_size;
                    ProductCpuNumberTextLabel.Text = Program.product.CPU_number;
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
