﻿using System;
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
    public partial class frm_fridgeview : Form
    {
        private connectionDB conn = new connectionDB();
        string[] informations = new string[2];


        public frm_fridgeview(string username)
        {
            InitializeComponent();
            lblName.Text = username;
            this.informations = conn.GetUserInfo(username);
        }

        private void frm_fridgeview_Load(object sender, EventArgs e)
        {
            

            
            
            
        }
    }
}