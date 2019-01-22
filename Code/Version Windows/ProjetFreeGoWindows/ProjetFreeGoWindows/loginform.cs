using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFreeGoWindows
{
    public partial class frm_login : Form
    {
        private connectionDB conn = new connectionDB();

        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            
        }

        private void llbl_createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_createaccount frm_Createaccount = new frm_createaccount();

            frm_Createaccount.Show();

            this.Hide();

        }
 
        private void llbl_passwordlost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_lostpassword frm_Lostpassword = new frm_lostpassword();

            frm_Lostpassword.Show();

            this.Hide();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string username="";
            string password="1";

            try
            {
                if(txtUsr.Text != "")
                {
                    username = txtUsr.Text;
                }

                password = conn.CreateMD5(txtPass.Text);

            }catch(Exception ex)
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect");
            }

            if(conn.Login(username,password))
            {
                frm_fridgeview frm_Fridgeview = new frm_fridgeview(username);
                frm_Fridgeview.Show();
                this.Hide();
            }
            
        }
    }
}
