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

namespace QuanLyPhanMem.Reports
{
    public partial class frmHDReport : Form
    {
        QLDAEntities ProjectDB = new QLDAEntities();
        public frmHDReport()
        {
            InitializeComponent();
        }

        private void frmHDReport_Load(object sender, EventArgs e)
        {
            List<HoaDon> listHDs = ProjectDB.HoaDons.ToList();
            List<HoaDonReportClass> listHDRs = new List<HoaDonReportClass>();
            foreach (var item in listHDs)
            {
                HoaDonReportClass hdrp = new HoaDonReportClass();
                hdrp.MaHD = item.MaHoaDon;
                hdrp.MaKH = item.MaKhachHang;
                hdrp.MaNV = item.MaNhanVien;
                hdrp.TongTien = Convert.ToInt32(item.TongTien);
                listHDRs.Add(hdrp);
            }
            HoaDonReport hdr = new HoaDonReport();
            hdr.SetDataSource(listHDRs);
            crystalReportViewer1.ReportSource = hdr;
        }
    }
}
