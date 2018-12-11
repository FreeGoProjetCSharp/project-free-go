namespace ProjetFreeGoWindows
{
    partial class frm_createaccount
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
            this.grp_CreateAccount = new System.Windows.Forms.GroupBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCreateAccount = new System.Windows.Forms.Button();
            this.lblPassConf = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPassConf = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llblBackLogin = new System.Windows.Forms.LinkLabel();
            this.grp_CreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_CreateAccount
            // 
            this.grp_CreateAccount.Controls.Add(this.cmdClear);
            this.grp_CreateAccount.Controls.Add(this.cmdCreateAccount);
            this.grp_CreateAccount.Controls.Add(this.lblPassConf);
            this.grp_CreateAccount.Controls.Add(this.lblPass);
            this.grp_CreateAccount.Controls.Add(this.lblMail);
            this.grp_CreateAccount.Controls.Add(this.lblName);
            this.grp_CreateAccount.Controls.Add(this.txtPassConf);
            this.grp_CreateAccount.Controls.Add(this.txtPass);
            this.grp_CreateAccount.Controls.Add(this.pictureBox4);
            this.grp_CreateAccount.Controls.Add(this.txtMail);
            this.grp_CreateAccount.Controls.Add(this.txtName);
            this.grp_CreateAccount.Controls.Add(this.pictureBox3);
            this.grp_CreateAccount.Controls.Add(this.pictureBox2);
            this.grp_CreateAccount.Location = new System.Drawing.Point(23, 103);
            this.grp_CreateAccount.Name = "grp_CreateAccount";
            this.grp_CreateAccount.Size = new System.Drawing.Size(313, 338);
            this.grp_CreateAccount.TabIndex = 1;
            this.grp_CreateAccount.TabStop = false;
            this.grp_CreateAccount.Text = "Create account";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(110, 293);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 12;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // cmdCreateAccount
            // 
            this.cmdCreateAccount.Location = new System.Drawing.Point(198, 293);
            this.cmdCreateAccount.Name = "cmdCreateAccount";
            this.cmdCreateAccount.Size = new System.Drawing.Size(97, 23);
            this.cmdCreateAccount.TabIndex = 11;
            this.cmdCreateAccount.Text = "Create account";
            this.cmdCreateAccount.UseVisualStyleBackColor = true;
            this.cmdCreateAccount.Click += new System.EventHandler(this.cmdCreateAccount_Click);
            // 
            // lblPassConf
            // 
            this.lblPassConf.AutoSize = true;
            this.lblPassConf.Location = new System.Drawing.Point(130, 213);
            this.lblPassConf.Name = "lblPassConf";
            this.lblPassConf.Size = new System.Drawing.Size(90, 13);
            this.lblPassConf.TabIndex = 10;
            this.lblPassConf.Text = "Confirm password";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(107, 157);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(124, 13);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password (Max. 60 char)";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(162, 85);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Username (Max. 100 char)";
            // 
            // txtPassConf
            // 
            this.txtPassConf.Location = new System.Drawing.Point(71, 237);
            this.txtPassConf.MaxLength = 60;
            this.txtPassConf.Name = "txtPassConf";
            this.txtPassConf.PasswordChar = '*';
            this.txtPassConf.Size = new System.Drawing.Size(207, 20);
            this.txtPassConf.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(71, 173);
            this.txtPass.MaxLength = 60;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(207, 20);
            this.txtPass.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjetFreeGoWindows.Properties.Resources.password;
            this.pictureBox4.Location = new System.Drawing.Point(12, 170);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 25);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(71, 111);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(207, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 48);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjetFreeGoWindows.Properties.Resources.name;
            this.pictureBox3.Location = new System.Drawing.Point(12, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 25);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetFreeGoWindows.Properties.Resources.mail1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetFreeGoWindows.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(133, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // llblBackLogin
            // 
            this.llblBackLogin.AutoSize = true;
            this.llblBackLogin.Location = new System.Drawing.Point(7, 9);
            this.llblBackLogin.Name = "llblBackLogin";
            this.llblBackLogin.Size = new System.Drawing.Size(81, 13);
            this.llblBackLogin.TabIndex = 2;
            this.llblBackLogin.TabStop = true;
            this.llblBackLogin.Text = "<- Back to login";
            this.llblBackLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBackLogin_LinkClicked);
            // 
            // frm_createaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 447);
            this.Controls.Add(this.llblBackLogin);
            this.Controls.Add(this.grp_CreateAccount);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_createaccount";
            this.Text = "Form create account";
            this.grp_CreateAccount.ResumeLayout(false);
            this.grp_CreateAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grp_CreateAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassConf;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPassConf;
        private System.Windows.Forms.Button cmdCreateAccount;
        private System.Windows.Forms.LinkLabel llblBackLogin;
        private System.Windows.Forms.Button cmdClear;
    }
}