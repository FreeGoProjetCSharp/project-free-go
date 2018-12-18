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
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.grp_SignIn = new System.Windows.Forms.GroupBox();
            this.cmdLogin = new System.Windows.Forms.Button();
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
            this.lbl_usr.Size = new System.Drawing.Size(129, 13);
            this.lbl_usr.TabIndex = 0;
            this.lbl_usr.Text = "Username(Case sensitive)";
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
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(15, 67);
            this.txtUsr.MaxLength = 100;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(216, 20);
            this.txtUsr.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(15, 130);
            this.txtPass.MaxLength = 60;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(216, 20);
            this.txtPass.TabIndex = 3;
            // 
            // grp_SignIn
            // 
            this.grp_SignIn.Controls.Add(this.cmdLogin);
            this.grp_SignIn.Controls.Add(this.llbl_createaccount);
            this.grp_SignIn.Controls.Add(this.llbl_passwordlost);
            this.grp_SignIn.Controls.Add(this.txtUsr);
            this.grp_SignIn.Controls.Add(this.txtPass);
            this.grp_SignIn.Controls.Add(this.lbl_usr);
            this.grp_SignIn.Controls.Add(this.lbl_pass);
            this.grp_SignIn.Location = new System.Drawing.Point(12, 123);
            this.grp_SignIn.Name = "grp_SignIn";
            this.grp_SignIn.Size = new System.Drawing.Size(237, 230);
            this.grp_SignIn.TabIndex = 4;
            this.grp_SignIn.TabStop = false;
            this.grp_SignIn.Text = "Sign-in";
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(156, 170);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 23);
            this.cmdLogin.TabIndex = 6;
            this.cmdLogin.Text = "login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // llbl_createaccount
            // 
            this.llbl_createaccount.AutoSize = true;
            this.llbl_createaccount.Location = new System.Drawing.Point(12, 207);
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
            this.llbl_passwordlost.Location = new System.Drawing.Point(124, 207);
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
            this.ClientSize = new System.Drawing.Size(255, 361);
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
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox grp_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llbl_createaccount;
        private System.Windows.Forms.LinkLabel llbl_passwordlost;
        private System.Windows.Forms.Button cmdLogin;
    }
}

