namespace ProjetFreeGoWindows
{
    partial class frm_addAlim
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
            this.lblAddAlim = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdAddAliment = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cldrExpiration = new System.Windows.Forms.MonthCalendar();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUnit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdUploadFile = new System.Windows.Forms.Button();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddAlim
            // 
            this.lblAddAlim.AutoSize = true;
            this.lblAddAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAlim.Location = new System.Drawing.Point(13, 13);
            this.lblAddAlim.Name = "lblAddAlim";
            this.lblAddAlim.Size = new System.Drawing.Size(230, 20);
            this.lblAddAlim.TabIndex = 0;
            this.lblAddAlim.Text = "Formulaire d\'ajout d\'aliment";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom:";
            // 
            // cmdAddAliment
            // 
            this.cmdAddAliment.Location = new System.Drawing.Point(301, 364);
            this.cmdAddAliment.Name = "cmdAddAliment";
            this.cmdAddAliment.Size = new System.Drawing.Size(103, 23);
            this.cmdAddAliment.TabIndex = 2;
            this.cmdAddAliment.Text = "Ajouter un aliment";
            this.cmdAddAliment.UseVisualStyleBackColor = true;
            this.cmdAddAliment.Click += new System.EventHandler(this.cmdAddAliment_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(14, 157);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(89, 13);
            this.lblExpirationDate.TabIndex = 4;
            this.lblExpirationDate.Text = "Date d\'expiration:";
            // 
            // cldrExpiration
            // 
            this.cldrExpiration.Location = new System.Drawing.Point(18, 179);
            this.cldrExpiration.Name = "cldrExpiration";
            this.cldrExpiration.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(274, 67);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(50, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantité:";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(277, 83);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericQuantity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unité:";
            // 
            // numericUnit
            // 
            this.numericUnit.Location = new System.Drawing.Point(277, 148);
            this.numericUnit.Name = "numericUnit";
            this.numericUnit.Size = new System.Drawing.Size(120, 20);
            this.numericUnit.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Image:";
            // 
            // cmdUploadFile
            // 
            this.cmdUploadFile.Location = new System.Drawing.Point(277, 302);
            this.cmdUploadFile.Name = "cmdUploadFile";
            this.cmdUploadFile.Size = new System.Drawing.Size(120, 39);
            this.cmdUploadFile.TabIndex = 11;
            this.cmdUploadFile.Text = "Upload Image";
            this.cmdUploadFile.UseVisualStyleBackColor = true;
            this.cmdUploadFile.Click += new System.EventHandler(this.cmdUploadFile_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(275, 195);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(122, 101);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 12;
            this.pcbImage.TabStop = false;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(17, 366);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(228, 20);
            this.txtPathFile.TabIndex = 13;
            // 
            // frm_addAlim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 399);
            this.Controls.Add(this.txtPathFile);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.cmdUploadFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cldrExpiration);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdAddAliment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddAlim);
            this.Name = "frm_addAlim";
            this.Text = "addAlim";
            this.Load += new System.EventHandler(this.frm_addAlim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddAlim;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cmdAddAliment;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.MonthCalendar cldrExpiration;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdUploadFile;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.TextBox txtPathFile;
    }
}