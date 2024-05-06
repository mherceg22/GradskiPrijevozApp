﻿using GradskiPrijevozApp.Pictures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradskiPrijevozApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var logo = imgLogo.Logo;
            pcbLogo.Image = logo;
            pcbLogo.Width = logo.Width;
            pcbLogo.Height = logo.Height;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmregister = new FrmRegister();
            Hide();
            frmregister.ShowDialog();
            Close();
        }
    }
}
