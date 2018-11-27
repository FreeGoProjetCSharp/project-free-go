namespace ProjetFreeGoWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_usr = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtBox_usr = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.grp_SignIn = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_SignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Location = new System.Drawing.Point(12, 51);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(55, 13);
            this.lbl_usr.TabIndex = 0;
            this.lbl_usr.Text = "Username";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 105);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password";
            // 
            // txtBox_usr
            // 
            this.txtBox_usr.Location = new System.Drawing.Point(94, 48);
            this.txtBox_usr.Name = "txtBox_usr";
            this.txtBox_usr.Size = new System.Drawing.Size(100, 20);
            this.txtBox_usr.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(94, 102);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 3;
            // 
            // grp_SignIn
            // 
            this.grp_SignIn.Controls.Add(this.txtBox_usr);
            this.grp_SignIn.Controls.Add(this.txt_Pass);
            this.grp_SignIn.Controls.Add(this.lbl_usr);
            this.grp_SignIn.Controls.Add(this.lbl_pass);
            this.grp_SignIn.Location = new System.Drawing.Point(12, 123);
            this.grp_SignIn.Name = "grp_SignIn";
            this.grp_SignIn.Size = new System.Drawing.Size(237, 153);
            this.grp_SignIn.TabIndex = 4;
            this.grp_SignIn.TabStop = false;
            this.grp_SignIn.Text = "Sign-in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetFreeGoWindows.Properties.Resources.User1;
            this.pictureBox1.Location = new System.Drawing.Point(106, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grp_SignIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_SignIn.ResumeLayout(false);
            this.grp_SignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtBox_usr;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.GroupBox grp_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

