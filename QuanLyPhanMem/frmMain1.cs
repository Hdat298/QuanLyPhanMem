using System;
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

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, @"C:\Users\Administrator\source\repos\QuanLyPhanMem\QuanLyPhanMem\Resources\FileHelpDoAn.chm"));
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKhachHang fKH = new frmKhachHang();
            fKH.ShowDialog();
        }
    }
}
