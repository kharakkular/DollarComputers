namespace Lab11_KharakSingh_301042015
{
    partial class OrderForm
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
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.DescriptionLabel1 = new System.Windows.Forms.Label();
            this.ProductInformationLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionLabel2 = new System.Windows.Forms.Label();
            this.ProductCostLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DescriptionLabel3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductPictureBox.Location = new System.Drawing.Point(617, 101);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(311, 241);
            this.ProductPictureBox.TabIndex = 0;
            this.ProductPictureBox.TabStop = false;
            // 
            // DescriptionLabel1
            // 
            this.DescriptionLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel1.Location = new System.Drawing.Point(610, 43);
            this.DescriptionLabel1.Name = "DescriptionLabel1";
            this.DescriptionLabel1.Size = new System.Drawing.Size(137, 45);
            this.DescriptionLabel1.TabIndex = 1;
            this.DescriptionLabel1.Text = "Image";
            // 
            // ProductInformationLayoutPanel
            // 
            this.ProductInformationLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductInformationLayoutPanel.Location = new System.Drawing.Point(49, 91);
            this.ProductInformationLayoutPanel.Name = "ProductInformationLayoutPanel";
            this.ProductInformationLayoutPanel.Size = new System.Drawing.Size(456, 241);
            this.ProductInformationLayoutPanel.TabIndex = 2;
            // 
            // DescriptionLabel2
            // 
            this.DescriptionLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel2.Location = new System.Drawing.Point(42, 43);
            this.DescriptionLabel2.Name = "DescriptionLabel2";
            this.DescriptionLabel2.Size = new System.Drawing.Size(337, 45);
            this.DescriptionLabel2.TabIndex = 3;
            this.DescriptionLabel2.Text = "Product Information";
            // 
            // ProductCostLayoutPanel
            // 
            this.ProductCostLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductCostLayoutPanel.Location = new System.Drawing.Point(514, 348);
            this.ProductCostLayoutPanel.Name = "ProductCostLayoutPanel";
            this.ProductCostLayoutPanel.Size = new System.Drawing.Size(456, 127);
            this.ProductCostLayoutPanel.TabIndex = 3;
            // 
            // DescriptionLabel3
            // 
            this.DescriptionLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel3.Location = new System.Drawing.Point(205, 348);
            this.DescriptionLabel3.Name = "DescriptionLabel3";
            this.DescriptionLabel3.Size = new System.Drawing.Size(291, 45);
            this.DescriptionLabel3.TabIndex = 4;
            this.DescriptionLabel3.Text = "Cost Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Silver;
            this.CancelButton.Location = new System.Drawing.Point(617, 490);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(147, 51);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.Silver;
            this.FinishButton.Location = new System.Drawing.Point(810, 490);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(147, 51);
            this.FinishButton.TabIndex = 7;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.Location = new System.Drawing.Point(58, 490);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(147, 51);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.DescriptionLabel3);
            this.Controls.Add(this.ProductCostLayoutPanel);
            this.Controls.Add(this.DescriptionLabel2);
            this.Controls.Add(this.ProductInformationLayoutPanel);
            this.Controls.Add(this.DescriptionLabel1);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label DescriptionLabel1;
        private System.Windows.Forms.FlowLayoutPanel ProductInformationLayoutPanel;
        private System.Windows.Forms.Label DescriptionLabel2;
        private System.Windows.Forms.FlowLayoutPanel ProductCostLayoutPanel;
        private System.Windows.Forms.Label DescriptionLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BackButton;
    }
}