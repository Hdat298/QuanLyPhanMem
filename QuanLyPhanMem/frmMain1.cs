﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhanMem
{
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();
        }

        private void navBarSP_ItemChanged(object sender, EventArgs e)
        {

        }

        private void navBarSP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSanPham frmSP = new frmSanPham();
            frmSP.ShowDialog();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHoaDon fHD = new frmHoaDon();
            fHD.ShowDialog();
        }
    }
}
