namespace Lab11_KharakSingh_301042015
{
    partial class StartForm
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
            this.StartFormHeadingLabel = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenSaveOrderButton = new System.Windows.Forms.Button();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartFormHeadingLabel
            // 
            this.StartFormHeadingLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.StartFormHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartFormHeadingLabel.ForeColor = System.Drawing.Color.Transparent;
            this.StartFormHeadingLabel.Location = new System.Drawing.Point(241, 23);
            this.StartFormHeadingLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.StartFormHeadingLabel.Name = "StartFormHeadingLabel";
            this.StartFormHeadingLabel.Size = new System.Drawing.Size(235, 52);
            this.StartFormHeadingLabel.TabIndex = 0;
            this.StartFormHeadingLabel.Text = "Order Here";
            this.StartFormHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.Silver;
            this.NewOrderButton.Location = new System.Drawing.Point(12, 159);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(316, 51);
            this.NewOrderButton.TabIndex = 1;
            this.NewOrderButton.Text = "Start New Order";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Silver;
            this.ExitButton.Location = new System.Drawing.Point(635, 476);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(135, 51);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenSaveOrderButton
            // 
            this.OpenSaveOrderButton.BackColor = System.Drawing.Color.Silver;
            this.OpenSaveOrderButton.Location = new System.Drawing.Point(12, 256);
            this.OpenSaveOrderButton.Name = "OpenSaveOrderButton";
            this.OpenSaveOrderButton.Size = new System.Drawing.Size(316, 51);
            this.OpenSaveOrderButton.TabIndex = 3;
            this.OpenSaveOrderButton.Text = "Open Save Order";
            this.OpenSaveOrderButton.UseVisualStyleBackColor = false;
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StartFormPictureBox.Location = new System.Drawing.Point(372, 142);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(379, 305);
            this.StartFormPictureBox.TabIndex = 5;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.StartFormPictureBox);
            this.Controls.Add(this.OpenSaveOrderButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.StartFormHeadingLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start From";
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StartFormHeadingLabel;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenSaveOrderButton;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
    }
}

