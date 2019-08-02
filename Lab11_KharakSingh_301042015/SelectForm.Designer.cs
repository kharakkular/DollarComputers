namespace Lab11_KharakSingh_301042015
{
    partial class SelectForm
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
            this.SelectFormDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectComputerDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedComputerInformationLabel = new System.Windows.Forms.Label();
            this.SelectComputerLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectComputerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormDescriptionLabel
            // 
            this.SelectFormDescriptionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SelectFormDescriptionLabel.Location = new System.Drawing.Point(5, 45);
            this.SelectFormDescriptionLabel.Name = "SelectFormDescriptionLabel";
            this.SelectFormDescriptionLabel.Size = new System.Drawing.Size(364, 49);
            this.SelectFormDescriptionLabel.TabIndex = 0;
            this.SelectFormDescriptionLabel.Text = "Select Your Computer";
            // 
            // SelectComputerDataGridView
            // 
            this.SelectComputerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectComputerDataGridView.Location = new System.Drawing.Point(12, 97);
            this.SelectComputerDataGridView.Name = "SelectComputerDataGridView";
            this.SelectComputerDataGridView.RowTemplate.Height = 24;
            this.SelectComputerDataGridView.Size = new System.Drawing.Size(958, 277);
            this.SelectComputerDataGridView.TabIndex = 1;
            // 
            // SelectedComputerInformationLabel
            // 
            this.SelectedComputerInformationLabel.BackColor = System.Drawing.Color.White;
            this.SelectedComputerInformationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectedComputerInformationLabel.Location = new System.Drawing.Point(343, 377);
            this.SelectedComputerInformationLabel.Name = "SelectedComputerInformationLabel";
            this.SelectedComputerInformationLabel.Size = new System.Drawing.Size(627, 56);
            this.SelectedComputerInformationLabel.TabIndex = 2;
            this.SelectedComputerInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectComputerLabel
            // 
            this.SelectComputerLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SelectComputerLabel.Location = new System.Drawing.Point(12, 377);
            this.SelectComputerLabel.Name = "SelectComputerLabel";
            this.SelectComputerLabel.Size = new System.Drawing.Size(299, 49);
            this.SelectComputerLabel.TabIndex = 3;
            this.SelectComputerLabel.Text = "Your Selection :";
            this.SelectComputerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Silver;
            this.NextButton.Location = new System.Drawing.Point(823, 475);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(147, 51);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Silver;
            this.CancelButton.Location = new System.Drawing.Point(642, 475);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(147, 51);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectComputerLabel);
            this.Controls.Add(this.SelectedComputerInformationLabel);
            this.Controls.Add(this.SelectComputerDataGridView);
            this.Controls.Add(this.SelectFormDescriptionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form";
            ((System.ComponentModel.ISupportInitialize)(this.SelectComputerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SelectFormDescriptionLabel;
        private System.Windows.Forms.DataGridView SelectComputerDataGridView;
        private System.Windows.Forms.Label SelectedComputerInformationLabel;
        private System.Windows.Forms.Label SelectComputerLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
    }
}