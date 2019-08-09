namespace Lab11_KharakSingh_301042015.Views
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProgrammerName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProgrammerName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelWebsite, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelContactNumber, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(550, 318);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.Image = global::Lab11_KharakSingh_301042015.Properties.Resources.DollarComputer;
            this.logoPictureBox.Location = new System.Drawing.Point(5, 6);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(171, 306);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgrammerName.ForeColor = System.Drawing.Color.Transparent;
            this.labelProgrammerName.Location = new System.Drawing.Point(191, 0);
            this.labelProgrammerName.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.labelProgrammerName.MaximumSize = new System.Drawing.Size(0, 29);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(354, 29);
            this.labelProgrammerName.TabIndex = 19;
            this.labelProgrammerName.Text = "Programmer Name";
            this.labelProgrammerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.ForeColor = System.Drawing.Color.Transparent;
            this.labelVersion.Location = new System.Drawing.Point(191, 31);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 29);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(354, 29);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWebsite
            // 
            this.labelWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWebsite.ForeColor = System.Drawing.Color.Transparent;
            this.labelWebsite.Location = new System.Drawing.Point(191, 62);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.labelWebsite.MaximumSize = new System.Drawing.Size(0, 29);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(354, 29);
            this.labelWebsite.TabIndex = 21;
            this.labelWebsite.Text = "Website";
            this.labelWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContactNumber.ForeColor = System.Drawing.Color.Transparent;
            this.labelContactNumber.Location = new System.Drawing.Point(191, 93);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.labelContactNumber.MaximumSize = new System.Drawing.Size(0, 29);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(354, 29);
            this.labelContactNumber.TabIndex = 22;
            this.labelContactNumber.Text = "Contact-Number";
            this.labelContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(191, 130);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(10, 6, 5, 6);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(354, 115);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(386, 271);
            this.okButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(159, 41);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(580, 348);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProgrammerName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
    }
}
