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
    public partial class frmKhachHang : Form
    { 
        List<KhachHang> _khL;
        private String _maKh, _phai = "Nam";
    public frmKhachHang()
    {
        InitializeComponent();
        TaiDsKhachHang();
    }
    private void TaiDsKhachHang()
    {

        using (var dbcontext = new KhachHangModel())
        {
            _khL = dbcontext.KhachHangs.ToList();
        }
        dgvKhachHang.Rows.Clear();
        if (_khL.Count <= 0) return;
        foreach (var kh in _khL)
        {
            int indexRow = dgvKhachHang.Rows.Add();
            dgvKhachHang.Rows[indexRow].Cells[0].Value = kh.MaKhachHang;
            dgvKhachHang.Rows[indexRow].Cells[1].Value = kh.TenKhachHang;
            dgvKhachHang.Rows[indexRow].Cells[2].Value = kh.Phai;
            dgvKhachHang.Rows[indexRow].Cells[3].Value = kh.NgaySinh;
            dgvKhachHang.Rows[indexRow].Cells[4].Value = kh.DiaChi;
            dgvKhachHang.Rows[indexRow].Cells[5].Value = kh.SDT;
            dgvKhachHang.Rows[indexRow].Cells[6].Value = kh.Email;
        }

        cbPhai.Text = "Nam";

        dgvKhachHang.Rows[0].Selected = false;

    }

    private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1) return;
        if (dgvKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;

        dgvKhachHang.CurrentRow.Selected = true;
        txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        _maKh = txtMaKH.Text;
        txtHoTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        //.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        dtpNgaySinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        txtMail.Text = dgvKhachHang.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
    }
    private void btnThem_Click(object sender, EventArgs e)
    {
        string error;
        var kh = new KhachHang();
        kh.MaKhachHang = txtMaKH.Text;
        kh.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
        kh.Phai = _phai;
        kh.SDT = txtSDT.Text;
        kh.TenKhachHang = txtHoTen.Text;
        kh.Email = txtMail.Text;
        kh.DiaChi = txtDiaChi.Text;

        using (var dbcontext = new KhachHangModel())
        {
            dbcontext.KhachHangs.Add(kh);
            dbcontext.SaveChanges();
        }
        MessageBox.Show("tao khach hang thanh cong");
        TaiDsKhachHang();

    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        string error;
        using (var dbcontext = new KhachHangModel())
        {
            var ketQua = dbcontext.KhachHangs.SingleOrDefault(k => k.MaKhachHang == _maKh);
            if (ketQua == null) return;

            ketQua.MaKhachHang = txtMaKH.Text;
            ketQua.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            ketQua.Phai = _phai;
            ketQua.SDT = txtSDT.Text;
            ketQua.TenKhachHang = txtHoTen.Text;
            ketQua.Email = txtMail.Text;
            ketQua.DiaChi = txtDiaChi.Text;

            dbcontext.SaveChanges();
        }
        MessageBox.Show("cap nhat khach hang thanh cong");
        TaiDsKhachHang();
    }

    private void cbPhai_SelectedValueChanged(object sender, EventArgs e)
    {
        ComboBox cb = (ComboBox)sender;
        if (cb.SelectedValue == null) return;
        _phai = cb.Text;
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {

        using (var dbcontext = new KhachHangModel())
        {
            var kh = dbcontext.KhachHangs.SingleOrDefault(k => k.MaKhachHang == _maKh);
            if (kh == null) return;
            dbcontext.KhachHangs.Remove(kh);
            dbcontext.SaveChanges();
        }
        MessageBox.Show("xoa khach hang thanh cong");
        TaiDsKhachHang();
        }
    }
}
