namespace Lab11_KharakSingh_301042015.Views
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDTextLabel = new System.Windows.Forms.Label();
            this.ProductConditionLabel = new System.Windows.Forms.Label();
            this.ProductConditionTextLabel = new System.Windows.Forms.Label();
            this.ProductCostLabel = new System.Windows.Forms.Label();
            this.ProductCostTextLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductManufacturerTextLabel = new System.Windows.Forms.Label();
            this.ProductModelTextLabel = new System.Windows.Forms.Label();
            this.ProductOperatingSystemTextLabel = new System.Windows.Forms.Label();
            this.ProductPlatformTextLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductModelLabel = new System.Windows.Forms.Label();
            this.ProductOperatingSystemLabel = new System.Windows.Forms.Label();
            this.ProductPlatformLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductCpuNumberTextLabel = new System.Windows.Forms.Label();
            this.ProductCpuBrandTextLabel = new System.Windows.Forms.Label();
            this.ProductHDDTextLabel = new System.Windows.Forms.Label();
            this.ProductScreenSizeTextLabel = new System.Windows.Forms.Label();
            this.ProductCpuSpeedTextLabel = new System.Windows.Forms.Label();
            this.ProductRamTextLabel = new System.Windows.Forms.Label();
            this.ProductCpuNumberLabel = new System.Windows.Forms.Label();
            this.ProductCpuBrandLabel = new System.Windows.Forms.Label();
            this.ProductHDDLabel = new System.Windows.Forms.Label();
            this.ProductScreenSizeLabel = new System.Windows.Forms.Label();
            this.ProductCpuSpeedLabel = new System.Windows.Forms.Label();
            this.ProductRamLabel = new System.Windows.Forms.Label();
            this.ProductInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Silver;
            this.NextButton.Location = new System.Drawing.Point(659, 496);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(93, 34);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Silver;
            this.CancelButton.Location = new System.Drawing.Point(513, 496);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 34);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.BackColor = System.Drawing.Color.Silver;
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(28, 496);
            this.SelectAnotherProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(273, 34);
            this.SelectAnotherProductButton.TabIndex = 7;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = false;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(782, 26);
            this.ProductInfoMenuStrip.TabIndex = 9;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductIDLabel.Location = new System.Drawing.Point(23, 48);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(112, 27);
            this.ProductIDLabel.TabIndex = 10;
            this.ProductIDLabel.Text = "Product ID";
            this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductIDTextLabel
            // 
            this.ProductIDTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIDTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductIDTextLabel.Location = new System.Drawing.Point(140, 48);
            this.ProductIDTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDTextLabel.Name = "ProductIDTextLabel";
            this.ProductIDTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductIDTextLabel.TabIndex = 12;
            this.ProductIDTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductConditionLabel
            // 
            this.ProductConditionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductConditionLabel.Location = new System.Drawing.Point(283, 48);
            this.ProductConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductConditionLabel.Name = "ProductConditionLabel";
            this.ProductConditionLabel.Size = new System.Drawing.Size(99, 27);
            this.ProductConditionLabel.TabIndex = 10;
            this.ProductConditionLabel.Text = "Condition";
            this.ProductConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductConditionTextLabel
            // 
            this.ProductConditionTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductConditionTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductConditionTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductConditionTextLabel.Location = new System.Drawing.Point(386, 48);
            this.ProductConditionTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductConditionTextLabel.Name = "ProductConditionTextLabel";
            this.ProductConditionTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductConditionTextLabel.TabIndex = 12;
            this.ProductConditionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductCostLabel.Location = new System.Drawing.Point(533, 48);
            this.ProductCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(73, 30);
            this.ProductCostLabel.TabIndex = 10;
            this.ProductCostLabel.Text = "Cost";
            this.ProductCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductCostTextLabel
            // 
            this.ProductCostTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductCostTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCostTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductCostTextLabel.Location = new System.Drawing.Point(610, 48);
            this.ProductCostTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCostTextLabel.Name = "ProductCostTextLabel";
            this.ProductCostTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductCostTextLabel.TabIndex = 12;
            this.ProductCostTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ProductInfoGroupBox.Controls.Add(this.ProductManufacturerTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductModelTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductOperatingSystemTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductPlatformTextLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductOperatingSystemLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductPlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(28, 128);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(729, 181);
            this.ProductInfoGroupBox.TabIndex = 13;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ProductManufacturerTextLabel
            // 
            this.ProductManufacturerTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductManufacturerTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductManufacturerTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductManufacturerTextLabel.Location = new System.Drawing.Point(160, 104);
            this.ProductManufacturerTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductManufacturerTextLabel.Name = "ProductManufacturerTextLabel";
            this.ProductManufacturerTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductManufacturerTextLabel.TabIndex = 12;
            this.ProductManufacturerTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductModelTextLabel
            // 
            this.ProductModelTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductModelTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductModelTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductModelTextLabel.Location = new System.Drawing.Point(415, 104);
            this.ProductModelTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductModelTextLabel.Name = "ProductModelTextLabel";
            this.ProductModelTextLabel.Size = new System.Drawing.Size(261, 28);
            this.ProductModelTextLabel.TabIndex = 12;
            this.ProductModelTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductOperatingSystemTextLabel
            // 
            this.ProductOperatingSystemTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductOperatingSystemTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductOperatingSystemTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductOperatingSystemTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductOperatingSystemTextLabel.Location = new System.Drawing.Point(415, 41);
            this.ProductOperatingSystemTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductOperatingSystemTextLabel.Name = "ProductOperatingSystemTextLabel";
            this.ProductOperatingSystemTextLabel.Size = new System.Drawing.Size(261, 28);
            this.ProductOperatingSystemTextLabel.TabIndex = 12;
            this.ProductOperatingSystemTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductPlatformTextLabel
            // 
            this.ProductPlatformTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductPlatformTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPlatformTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductPlatformTextLabel.Location = new System.Drawing.Point(160, 39);
            this.ProductPlatformTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductPlatformTextLabel.Name = "ProductPlatformTextLabel";
            this.ProductPlatformTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductPlatformTextLabel.TabIndex = 12;
            this.ProductPlatformTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductManufacturerLabel
            // 
            this.ProductManufacturerLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductManufacturerLabel.Location = new System.Drawing.Point(17, 103);
            this.ProductManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductManufacturerLabel.Name = "ProductManufacturerLabel";
            this.ProductManufacturerLabel.Size = new System.Drawing.Size(132, 27);
            this.ProductManufacturerLabel.TabIndex = 10;
            this.ProductManufacturerLabel.Text = "Manufacturer";
            this.ProductManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductModelLabel
            // 
            this.ProductModelLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductModelLabel.Location = new System.Drawing.Point(304, 103);
            this.ProductModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductModelLabel.Name = "ProductModelLabel";
            this.ProductModelLabel.Size = new System.Drawing.Size(107, 27);
            this.ProductModelLabel.TabIndex = 10;
            this.ProductModelLabel.Text = "Model";
            this.ProductModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductOperatingSystemLabel
            // 
            this.ProductOperatingSystemLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductOperatingSystemLabel.Location = new System.Drawing.Point(304, 41);
            this.ProductOperatingSystemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductOperatingSystemLabel.Name = "ProductOperatingSystemLabel";
            this.ProductOperatingSystemLabel.Size = new System.Drawing.Size(107, 27);
            this.ProductOperatingSystemLabel.TabIndex = 10;
            this.ProductOperatingSystemLabel.Text = "OS";
            this.ProductOperatingSystemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductPlatformLabel
            // 
            this.ProductPlatformLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductPlatformLabel.Location = new System.Drawing.Point(48, 40);
            this.ProductPlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductPlatformLabel.Name = "ProductPlatformLabel";
            this.ProductPlatformLabel.Size = new System.Drawing.Size(96, 27);
            this.ProductPlatformLabel.TabIndex = 10;
            this.ProductPlatformLabel.Text = "Platform";
            this.ProductPlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuNumberTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuBrandTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductHDDTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductScreenSizeTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuSpeedTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductRamTextLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductHDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductScreenSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductCpuSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.ProductRamLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(28, 315);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(729, 148);
            this.TechSpecsGroupBox.TabIndex = 14;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // ProductCpuNumberTextLabel
            // 
            this.ProductCpuNumberTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductCpuNumberTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuNumberTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductCpuNumberTextLabel.Location = new System.Drawing.Point(611, 100);
            this.ProductCpuNumberTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuNumberTextLabel.Name = "ProductCpuNumberTextLabel";
            this.ProductCpuNumberTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductCpuNumberTextLabel.TabIndex = 12;
            this.ProductCpuNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductCpuBrandTextLabel
            // 
            this.ProductCpuBrandTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductCpuBrandTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuBrandTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductCpuBrandTextLabel.Location = new System.Drawing.Point(611, 37);
            this.ProductCpuBrandTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuBrandTextLabel.Name = "ProductCpuBrandTextLabel";
            this.ProductCpuBrandTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductCpuBrandTextLabel.TabIndex = 12;
            this.ProductCpuBrandTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductHDDTextLabel
            // 
            this.ProductHDDTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductHDDTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductHDDTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductHDDTextLabel.Location = new System.Drawing.Point(358, 101);
            this.ProductHDDTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductHDDTextLabel.Name = "ProductHDDTextLabel";
            this.ProductHDDTextLabel.Size = new System.Drawing.Size(101, 28);
            this.ProductHDDTextLabel.TabIndex = 12;
            this.ProductHDDTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductScreenSizeTextLabel
            // 
            this.ProductScreenSizeTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductScreenSizeTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductScreenSizeTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductScreenSizeTextLabel.Location = new System.Drawing.Point(148, 36);
            this.ProductScreenSizeTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductScreenSizeTextLabel.Name = "ProductScreenSizeTextLabel";
            this.ProductScreenSizeTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductScreenSizeTextLabel.TabIndex = 12;
            this.ProductScreenSizeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductCpuSpeedTextLabel
            // 
            this.ProductCpuSpeedTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductCpuSpeedTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCpuSpeedTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductCpuSpeedTextLabel.Location = new System.Drawing.Point(148, 102);
            this.ProductCpuSpeedTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuSpeedTextLabel.Name = "ProductCpuSpeedTextLabel";
            this.ProductCpuSpeedTextLabel.Size = new System.Drawing.Size(113, 28);
            this.ProductCpuSpeedTextLabel.TabIndex = 12;
            this.ProductCpuSpeedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductRamTextLabel
            // 
            this.ProductRamTextLabel.BackColor = System.Drawing.Color.White;
            this.ProductRamTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductRamTextLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductRamTextLabel.Location = new System.Drawing.Point(358, 35);
            this.ProductRamTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductRamTextLabel.Name = "ProductRamTextLabel";
            this.ProductRamTextLabel.Size = new System.Drawing.Size(101, 28);
            this.ProductRamTextLabel.TabIndex = 12;
            this.ProductRamTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductCpuNumberLabel
            // 
            this.ProductCpuNumberLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductCpuNumberLabel.Location = new System.Drawing.Point(463, 101);
            this.ProductCpuNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuNumberLabel.Name = "ProductCpuNumberLabel";
            this.ProductCpuNumberLabel.Size = new System.Drawing.Size(130, 27);
            this.ProductCpuNumberLabel.TabIndex = 10;
            this.ProductCpuNumberLabel.Text = "CPU Number";
            this.ProductCpuNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductCpuBrandLabel
            // 
            this.ProductCpuBrandLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductCpuBrandLabel.Location = new System.Drawing.Point(478, 37);
            this.ProductCpuBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuBrandLabel.Name = "ProductCpuBrandLabel";
            this.ProductCpuBrandLabel.Size = new System.Drawing.Size(115, 27);
            this.ProductCpuBrandLabel.TabIndex = 10;
            this.ProductCpuBrandLabel.Text = "CPU Brand";
            this.ProductCpuBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductHDDLabel
            // 
            this.ProductHDDLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductHDDLabel.Location = new System.Drawing.Point(277, 101);
            this.ProductHDDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductHDDLabel.Name = "ProductHDDLabel";
            this.ProductHDDLabel.Size = new System.Drawing.Size(77, 27);
            this.ProductHDDLabel.TabIndex = 10;
            this.ProductHDDLabel.Text = "HDD";
            this.ProductHDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductScreenSizeLabel
            // 
            this.ProductScreenSizeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductScreenSizeLabel.Location = new System.Drawing.Point(37, 38);
            this.ProductScreenSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductScreenSizeLabel.Name = "ProductScreenSizeLabel";
            this.ProductScreenSizeLabel.Size = new System.Drawing.Size(107, 27);
            this.ProductScreenSizeLabel.TabIndex = 10;
            this.ProductScreenSizeLabel.Text = "LCD Size";
            this.ProductScreenSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductCpuSpeedLabel
            // 
            this.ProductCpuSpeedLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductCpuSpeedLabel.Location = new System.Drawing.Point(5, 103);
            this.ProductCpuSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductCpuSpeedLabel.Name = "ProductCpuSpeedLabel";
            this.ProductCpuSpeedLabel.Size = new System.Drawing.Size(139, 27);
            this.ProductCpuSpeedLabel.TabIndex = 10;
            this.ProductCpuSpeedLabel.Text = "CPU Speed";
            this.ProductCpuSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductRamLabel
            // 
            this.ProductRamLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ProductRamLabel.Location = new System.Drawing.Point(258, 36);
            this.ProductRamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductRamLabel.Name = "ProductRamLabel";
            this.ProductRamLabel.Size = new System.Drawing.Size(96, 27);
            this.ProductRamLabel.TabIndex = 10;
            this.ProductRamLabel.Text = "RAM";
            this.ProductRamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductInfoOpenFileDialog
            // 
            this.ProductInfoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductCostTextLabel);
            this.Controls.Add(this.ProductConditionTextLabel);
            this.Controls.Add(this.ProductIDTextLabel);
            this.Controls.Add(this.ProductCostLabel);
            this.Controls.Add(this.ProductConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductIDTextLabel;
        private System.Windows.Forms.Label ProductConditionLabel;
        private System.Windows.Forms.Label ProductConditionTextLabel;
        private System.Windows.Forms.Label ProductCostLabel;
        private System.Windows.Forms.Label ProductCostTextLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ProductManufacturerTextLabel;
        private System.Windows.Forms.Label ProductOperatingSystemTextLabel;
        private System.Windows.Forms.Label ProductPlatformTextLabel;
        private System.Windows.Forms.Label ProductManufacturerLabel;
        private System.Windows.Forms.Label ProductOperatingSystemLabel;
        private System.Windows.Forms.Label ProductPlatformLabel;
        private System.Windows.Forms.Label ProductModelTextLabel;
        private System.Windows.Forms.Label ProductModelLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label ProductCpuNumberTextLabel;
        private System.Windows.Forms.Label ProductCpuBrandTextLabel;
        private System.Windows.Forms.Label ProductHDDTextLabel;
        private System.Windows.Forms.Label ProductScreenSizeTextLabel;
        private System.Windows.Forms.Label ProductCpuSpeedTextLabel;
        private System.Windows.Forms.Label ProductRamTextLabel;
        private System.Windows.Forms.Label ProductCpuNumberLabel;
        private System.Windows.Forms.Label ProductCpuBrandLabel;
        private System.Windows.Forms.Label ProductHDDLabel;
        private System.Windows.Forms.Label ProductScreenSizeLabel;
        private System.Windows.Forms.Label ProductCpuSpeedLabel;
        private System.Windows.Forms.Label ProductRamLabel;
        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductInfoSaveFileDialog;
    }
}