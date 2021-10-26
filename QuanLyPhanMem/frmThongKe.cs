using from_thong_ke;
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
        public frmThongKe()
        {
            InitializeComponent();
        }
        List<HoaDon> hoaDons;
        private void chiTietHoaDonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietHoaDonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDA2DataSet);

        }
        
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDA2DataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qLDA2DataSet.HoaDon);
            // TODO: This line of code loads data into the 'qLDA2DataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.qLDA2DataSet.ChiTietHoaDon);

        }
        private void TaiDanhSachHoaDon()
        {

            using (var dbcontext = new HoaDonModel())
            {
                hoaDons = dbcontext.HoaDons.ToList();
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
                dgvThongKe.Rows[indexRow].Cells[3].Value = hd.TongGia;
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
            int? tongTien = 0;
            foreach (var hd in hoaDons)
                if (hd.NgayLapHoaDon.ToString("MM-dd-yyyy") == dtpNgay.Value.ToString("MM-dd-yyyy"))
                    tongTien += hd.TongGia;
            txtTongDoanhThu.Text = tongTien.ToString();
        }

        private void btnThang_Click(object sender, System.EventArgs e)
        {
            int? tongTien = 0;
            foreach (var hd in hoaDons)
                if (hd.NgayLapHoaDon.ToString("MM-yyyy") == dtpThang.Value.ToString("MM-yyyy"))
                    tongTien += hd.TongGia;
            txtTongDoanhThu.Text = tongTien.ToString();
        }

        private void btnNam_Click(object sender, System.EventArgs e)
        {
            int? tongTien = 0;
            foreach (var hd in hoaDons)
                if (hd.NgayLapHoaDon.ToString("yyyy") == dtpNam.Value.ToString("yyyy"))
                    tongTien += hd.TongGia;
            txtTongDoanhThu.Text = tongTien.ToString();
        }
    }
}
