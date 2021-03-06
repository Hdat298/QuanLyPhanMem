using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyPhanMem.Reports;

namespace QuanLyPhanMem
{
    public partial class frmAdmin : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frmSuaSP fSuaSP = new frmSuaSP();
            fSuaSP.ShowDialog();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Register2 fNV = new Register2();
            fNV.ShowDialog();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            var rp = new frmNVReport();
            rp.ShowDialog();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            var rp = new frmSPReport();
            rp.ShowDialog();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            frmHoaDon fHD = new frmHoaDon();
            fHD.ShowDialog();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, @"C:\Users\Administrator\source\repos\QuanLyPhanMem\QuanLyPhanMem\Resources\FileHelpDoAn.chm"));
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            frmThongKe fTK = new frmThongKe();
            fTK.ShowDialog();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            frmKhachHang fKH = new frmKhachHang();
            fKH.ShowDialog();
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            var rp = new frmHDReport();
            rp.ShowDialog();
        }
    }
}
