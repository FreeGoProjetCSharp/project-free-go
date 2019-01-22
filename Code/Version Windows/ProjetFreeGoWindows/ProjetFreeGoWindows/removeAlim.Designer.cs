namespace ProjetFreeGoWindows
{
    partial class frmremoveAlim
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlim = new System.Windows.Forms.ComboBox();
            this.cmdRetire = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(27, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(249, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Formulaire de retrait d\'aliment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quel aliment souhaitez vous retirer?";
            // 
            // cmbAlim
            // 
            this.cmbAlim.FormattingEnabled = true;
            this.cmbAlim.Location = new System.Drawing.Point(31, 100);
            this.cmbAlim.Name = "cmbAlim";
            this.cmbAlim.Size = new System.Drawing.Size(245, 21);
            this.cmbAlim.TabIndex = 2;
            // 
            // cmdRetire
            // 
            this.cmdRetire.Location = new System.Drawing.Point(215, 167);
            this.cmdRetire.Name = "cmdRetire";
            this.cmdRetire.Size = new System.Drawing.Size(75, 23);
            this.cmdRetire.TabIndex = 3;
            this.cmdRetire.Text = "Retirer";
            this.cmdRetire.UseVisualStyleBackColor = true;
            this.cmdRetire.Click += new System.EventHandler(this.cmdRetire_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(134, 167);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmremoveAlim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 201);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdRetire);
            this.Controls.Add(this.cmbAlim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmremoveAlim";
            this.Text = "removeAlim";
            this.Load += new System.EventHandler(this.frmremoveAlim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlim;
        private System.Windows.Forms.Button cmdRetire;
        private System.Windows.Forms.Button cmdCancel;
    }
}