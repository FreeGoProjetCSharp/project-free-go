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
        public frm_createaccount()
        {
            InitializeComponent();
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
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
                    string passwordcrypt = CreateMD5(txtPass.Text);
                }
                else
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas");
                }
            }
            else { MessageBox.Show("Les mots de passe ne peuvent pas être vide"); }

      
        }

    }
}
