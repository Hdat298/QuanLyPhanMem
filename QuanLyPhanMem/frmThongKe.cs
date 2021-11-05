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
        QLDAEntities context = new QLDAEntities();
        private List<ChiTietHoaDon> tk, _temp;

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            tk = context.ChiTietHoaDons.ToList();
            _temp = new List<ChiTietHoaDon>();
            loadGridView(tk);
        }

        private void loadGridView(List<ChiTietHoaDon> listStudents)
        {
            dgvThongKe.Rows.Clear();
            var List = from q in listStudents
                       group q by new { q.MaHoaDon, q.NgayLapHoaDon } into p
                       select new { MaHD = p.Key.MaHoaDon, NgayLap = p.Key.NgayLapHoaDon, TongTien = p.Sum(o => o.ThanhTien) };
            foreach (var item in List)
            {
                int index = dgvThongKe.Rows.Add();
                dgvThongKe.Rows[index].Cells[0].Value = item.MaHD;
                dgvThongKe.Rows[index].Cells[1].Value = item.NgayLap;
                dgvThongKe.Rows[index].Cells[2].Value = item.TongTien;
            }
        }

        private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvThongKe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvThongKe.CurrentCell.Selected = true;
                    txtMaHD.Text = dgvThongKe.Rows[e.RowIndex].Cells["maHD"].FormattedValue.ToString();
                    txtNgayLap.Text = dgvThongKe.Rows[e.RowIndex].Cells["ngayLap"].FormattedValue.ToString();
                    txtTongGia.Text = dgvThongKe.Rows[e.RowIndex].Cells["tongGia"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnNgay_Click(object sender, System.EventArgs e)
        {
            double? tongTien = 0;
            foreach (var hd in tk)
                if (hd.NgayLapHoaDon?.ToString("MM-dd-yyyy") == dtpNgay.Value.ToString("MM-dd-yyyy"))
                {
                    _temp.Add(hd);
                    tongTien += hd.ThanhTien;
                }

            txtTongDoanhThu.Text = tongTien.ToString();

            loadGridView(_temp);
            _temp.Clear();
        }
        private void btnThang_Click(object sender, System.EventArgs e)
        {
            double? tongTien = 0;
            foreach (var hd in tk)
                if (hd.NgayLapHoaDon?.ToString("MM-yyyy") == dtpThang.Value.ToString("MM-yyyy"))
                {
                    _temp.Add(hd);
                    tongTien += hd.ThanhTien;
                }
            txtTongDoanhThu.Text = tongTien.ToString();

            loadGridView(_temp);
            _temp.Clear();

        }

        private void btnNam_Click(object sender, System.EventArgs e)
        {
            double? tongTien = 0;
            foreach (var hd in tk)
                if (hd.NgayLapHoaDon?.ToString("yyyy") == dtpNam.Value.ToString("yyyy"))
                {
                    _temp.Add(hd);
                    tongTien += hd.ThanhTien;
                }
            txtTongDoanhThu.Text = tongTien.ToString();

            loadGridView(_temp);
            _temp.Clear();

        }
    }
}
