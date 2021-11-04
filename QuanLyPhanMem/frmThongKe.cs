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
    public partial class frmThongKe : Form
    {
        List<ChiTietVaHoaDon> hoaDons;
        public frmThongKe()
        {
            InitializeComponent();
            TaiDanhSachHoaDon();
        }

        private void TaiDanhSachHoaDon()
        {

            using (var dbcontext = new HoaDonModel())
            {
                hoaDons = (from hd in dbcontext.HoaDons
                           join cthd in dbcontext.ChiTietHoaDons on hd.MaHoaDon equals cthd.MaHoaDon

                           select new ChiTietVaHoaDon()
                           {
                               MaHoaDon = hd.MaHoaDon,
                               TongTien = hd.TongTien,
                               NgayLapHoaDon = cthd.NgayLapHoaDon
                           }).ToList();


            }

            int soThuTu = 1;
            dgvThongKe.Rows.Clear();
            if (hoaDons.Count <= 0) return;
            foreach (var hd in hoaDons)
            {
                int indexRow = dgvThongKe.Rows.Add();
                dgvThongKe.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvThongKe.Rows[indexRow].Cells[1].Value = hd.MaHoaDon;
                dgvThongKe.Rows[indexRow].Cells[2].Value = hd.NgayLapHoaDon;
                dgvThongKe.Rows[indexRow].Cells[3].Value = hd.TongTien;
            }
            dgvThongKe.Rows[0].Selected = false;

        }

        private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dgvThongKe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;

            dgvThongKe.CurrentRow.Selected = true;
            txtMaHD.Text = dgvThongKe.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtNgayLap.Text = dgvThongKe.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtTongGia.Text = dgvThongKe.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        }

        private void btnNgay_Click(object sender, System.EventArgs e)
        {
            double? tongTien = 0;
            foreach (var hd in hoaDons)
                if (hd.NgayLapHoaDon?.ToString("MM-dd-yyyy") == dtpNgay.Value.ToString("MM-dd-yyyy"))
                    tongTien += hd.TongTien;
            txtTongDoanhThu.Text = tongTien.ToString();
        }

        private void btnThang_Click(object sender, System.EventArgs e)
        {
            double? tongTien = 0;
            foreach (var hd in hoaDons)
                if (hd.NgayLapHoaDon?.ToString("MM-yyyy") == dtpThang.Value.ToString("MM-yyyy"))
                    tongTien += hd.TongTien;
            txtTongDoanhThu.Text = tongTien.ToString();
        }

        private void btnNam_Click(object sender, System.EventArgs e)
        {
            double? tongTien = 0;
            foreach (var hd in hoaDons)
                if (hd.NgayLapHoaDon?.ToString("yyyy") == dtpNam.Value.ToString("yyyy"))
                    tongTien += hd.TongTien;
            txtTongDoanhThu.Text = tongTien.ToString();
        }
    }
}
