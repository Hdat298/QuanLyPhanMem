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
    public partial class frmNVReport : Form
    {
        QLDAEntities ProjectDB = new QLDAEntities();
        public frmNVReport()
        {
            InitializeComponent();
        }

        private void frmNVReport_Load(object sender, EventArgs e)
        {
            List<NhanVien> listNVs = ProjectDB.NhanViens.ToList();
            List<NhanVienReportClass> listRPs = new List<NhanVienReportClass>();
            foreach (var item in listNVs)
            {
                NhanVienReportClass rpnv = new NhanVienReportClass();
                rpnv.MaNV = item.MaNhanVien;
                rpnv.TenNV = item.TenNhanVien;
                rpnv.TenCV = item.ChucVu.TenChucVu;
                rpnv.Email = item.Email;
                rpnv.DiaChi = item.DiaChi;
                rpnv.Phai = item.Phai;
                rpnv.SDT = item.SDT;
                rpnv.NgaySinh = Convert.ToDateTime(item.NgaySinh);
                rpnv.TenTK = item.TenTaiKhoan;
                rpnv.LoaiTK = item.LoaiTK;
                listRPs.Add(rpnv);
            }
            NhanVienReport rp = new NhanVienReport();
            rp.SetDataSource(listRPs);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
