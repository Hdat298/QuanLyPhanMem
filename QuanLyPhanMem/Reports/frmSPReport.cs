using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhanMem.Models;
using QuanLyPhanMem.Reports;

namespace QuanLyPhanMem.Reports
{
    public partial class frmSPReport : Form
    {
        QLDAEntities ProjectDB = new QLDAEntities();
        public frmSPReport()
        {
            InitializeComponent();
        }

        private void frmSPReport_Load(object sender, EventArgs e)
        {
            List<SanPham> listSPs = ProjectDB.SanPhams.ToList();
            List<SanPhamReportClass> listSPReports = new List<SanPhamReportClass>();
            foreach (var item in listSPs)
            {
                SanPhamReportClass SPReport = new SanPhamReportClass();
                SPReport.MaSP = item.MaSanPham;
                SPReport.TenSP = item.TenSanPham;
                SPReport.TenLoai = item.Loai.TenLoai;
                SPReport.TenNCC = item.NhaCungCap.TenCTY;
                SPReport.DonGia = item.DonGia;
                SPReport.DonViTinh = item.DonViTinh;
                listSPReports.Add(SPReport);
            }
            SanPhamReport rp = new SanPhamReport();
            rp.SetDataSource(listSPReports);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
