namespace ProjetFreeGoWindows
{
    partial class frm_login
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
            this.llbl_createaccount = new System.Windows.Forms.LinkLabel();
            this.llbl_passwordlost = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_SignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Location = new System.Drawing.Point(12, 41);
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
            this.lbl_pass.Size = new System.Drawing.Size(124, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password (Max. 60 char)";
            // 
            // txtBox_usr
            // 
            this.txtBox_usr.Location = new System.Drawing.Point(15, 67);
            this.txtBox_usr.MaxLength = 100;
            this.txtBox_usr.Name = "txtBox_usr";
            this.txtBox_usr.Size = new System.Drawing.Size(216, 20);
            this.txtBox_usr.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(15, 130);
            this.txt_Pass.MaxLength = 60;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(216, 20);
            this.txt_Pass.TabIndex = 3;
            // 
            // grp_SignIn
            // 
            this.grp_SignIn.Controls.Add(this.llbl_createaccount);
            this.grp_SignIn.Controls.Add(this.llbl_passwordlost);
            this.grp_SignIn.Controls.Add(this.txtBox_usr);
            this.grp_SignIn.Controls.Add(this.txt_Pass);
            this.grp_SignIn.Controls.Add(this.lbl_usr);
            this.grp_SignIn.Controls.Add(this.lbl_pass);
            this.grp_SignIn.Location = new System.Drawing.Point(12, 123);
            this.grp_SignIn.Name = "grp_SignIn";
            this.grp_SignIn.Size = new System.Drawing.Size(237, 203);
            this.grp_SignIn.TabIndex = 4;
            this.grp_SignIn.TabStop = false;
            this.grp_SignIn.Text = "Sign-in";
            // 
            // llbl_createaccount
            // 
            this.llbl_createaccount.AutoSize = true;
            this.llbl_createaccount.Location = new System.Drawing.Point(12, 174);
            this.llbl_createaccount.Name = "llbl_createaccount";
            this.llbl_createaccount.Size = new System.Drawing.Size(85, 13);
            this.llbl_createaccount.TabIndex = 5;
            this.llbl_createaccount.TabStop = true;
            this.llbl_createaccount.Text = "Créer un compte";
            this.llbl_createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_createaccount_LinkClicked);
            // 
            // llbl_passwordlost
            // 
            this.llbl_passwordlost.AutoSize = true;
            this.llbl_passwordlost.Location = new System.Drawing.Point(124, 174);
            this.llbl_passwordlost.Name = "llbl_passwordlost";
            this.llbl_passwordlost.Size = new System.Drawing.Size(107, 13);
            this.llbl_passwordlost.TabIndex = 4;
            this.llbl_passwordlost.TabStop = true;
            this.llbl_passwordlost.Text = "Mot de passe perdu?";
            this.llbl_passwordlost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_passwordlost_LinkClicked);
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
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(255, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grp_SignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_login";
            this.Text = "Formulaire de login";
            this.Load += new System.EventHandler(this.frm_login_Load);
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
        private System.Windows.Forms.LinkLabel llbl_createaccount;
        private System.Windows.Forms.LinkLabel llbl_passwordlost;
    }
}

