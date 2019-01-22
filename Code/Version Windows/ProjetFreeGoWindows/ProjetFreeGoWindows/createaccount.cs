using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace ProjetFreeGoWindows
{
    public partial class frm_createaccount : Form
    {
        private connectionDB conn; // Connection to database


        public frm_createaccount()
        {
            InitializeComponent();
        }

        private void llblBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_login frm_Login = new frm_login();

            frm_Login.Show();

            this.Hide();
        }

        private void cmdCreateAccount_Click(object sender, EventArgs e)
        {
            string emailaddress = txtMail.Text;
            string username = txtName.Text;

            //if (txtPass.Text != "") { string password = txtPass.Text; } else MessageBox.Show("Entrer un mot de passe");

            string regex = "^(?=.*[a - z])(?=.*[A - Z])(?=.*\\d)(?=.*[^\\da - zA - Z]).{ 8, 15 }$";

            Regex pattern = new Regex(regex);
            
            try
            {
                MailAddress mail = new MailAddress(emailaddress);
                pattern.Match(txtPass.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le message d'erreur est le suivant:"+ex.Message);
            }

            if (txtPass.Text != "" && txtPassConf.Text != "")
            {
                if (txtPass.Text == txtPassConf.Text)
                {
                   
                    string passwordcrypt = conn.CreateMD5(txtPass.Text);

                    frm_login frm_Login = new frm_login();
                    frm_Login.Show();
                    this.Hide();

                    conn.CreateAccount(username, emailaddress, passwordcrypt);
                }
                else
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas");
                }
            }
            else { MessageBox.Show("Les mots de passe ne peuvent pas être vide"); }

      
        }

        private void frm_createaccount_Load(object sender, EventArgs e)
        {
            conn = new connectionDB();
        }
    }
}
