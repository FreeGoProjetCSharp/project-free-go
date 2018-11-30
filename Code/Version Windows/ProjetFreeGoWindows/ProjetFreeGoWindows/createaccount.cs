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

namespace ProjetFreeGoWindows
{
    public partial class frm_createaccount : Form
    {
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
            

            try
            {


                MailAddress mail = new MailAddress(emailaddress);
                string password = txtPass.Text;

                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'adresse mail n'est pas valide");
            }
        }
    }
}
