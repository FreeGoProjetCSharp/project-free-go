namespace ProjetFreeGoWindows
{
    partial class frm_fridgeview
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsrName = new System.Windows.Forms.Label();
            this.cmdAddAlim = new System.Windows.Forms.Button();
            this.cmdRemoveAlim = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetFreeGoWindows.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // flp
            // 
            this.flp.Controls.Add(this.pictureBox4);
            this.flp.Location = new System.Drawing.Point(3, 89);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(446, 512);
            this.flp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frigo de:";
            // 
            // lblUsrName
            // 
            this.lblUsrName.AutoSize = true;
            this.lblUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrName.Location = new System.Drawing.Point(221, 29);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(0, 20);
            this.lblUsrName.TabIndex = 4;
            // 
            // cmdAddAlim
            // 
            this.cmdAddAlim.Location = new System.Drawing.Point(317, 12);
            this.cmdAddAlim.Name = "cmdAddAlim";
            this.cmdAddAlim.Size = new System.Drawing.Size(119, 23);
            this.cmdAddAlim.TabIndex = 5;
            this.cmdAddAlim.Text = "Ajouter un aliment";
            this.cmdAddAlim.UseVisualStyleBackColor = true;
            this.cmdAddAlim.Click += new System.EventHandler(this.cmdAddAlim_Click);
            // 
            // cmdRemoveAlim
            // 
            this.cmdRemoveAlim.Location = new System.Drawing.Point(317, 39);
            this.cmdRemoveAlim.Name = "cmdRemoveAlim";
            this.cmdRemoveAlim.Size = new System.Drawing.Size(119, 23);
            this.cmdRemoveAlim.TabIndex = 6;
            this.cmdRemoveAlim.Text = "Retirer un aliment";
            this.cmdRemoveAlim.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(0, 0);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // frm_fridgeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 606);
            this.Controls.Add(this.cmdRemoveAlim);
            this.Controls.Add(this.cmdAddAlim);
            this.Controls.Add(this.lblUsrName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_fridgeview";
            this.Text = "fridgeview";
            this.Load += new System.EventHandler(this.frm_fridgeview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.Button cmdAddAlim;
        private System.Windows.Forms.Button cmdRemoveAlim;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}