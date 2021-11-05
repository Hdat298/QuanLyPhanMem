using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhanMem
{
    public partial class frmHoaDon : Form
    {
        frmAdmin fAd = new frmAdmin();
        QLDAEntities context = new QLDAEntities();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void loadKH(List<KhachHang> listKHs)
        {
            cbxMaKH.DataSource = listKHs;
            cbxMaKH.DisplayMember = "MaKhachHang";
            cbxMaKH.ValueMember = "MaKhachHang";
        }

        private void LamMoi()
        {
            txtMaHD.Clear();
            txtMaHD2.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
        }
    #region method
        private void loadGridView2(List<SanPham> listStudents)
        {
            dataGridView2.Rows.Clear();
            foreach (var item in listStudents)
            {
                int index = dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells[0].Value = item.MaSanPham;
                dataGridView2.Rows[index].Cells[1].Value = item.TenSanPham;
                dataGridView2.Rows[index].Cells[2].Value = item.DonGia;
            }
        }   

        private string checkNV(string TenTruyCap)
        {
            List<NhanVien> listNVs = context.NhanViens.ToList();
            foreach (var item in listNVs)
            {
                if (TenTruyCap == item.TenTaiKhoan)
                {
                    return item.MaNhanVien;
                }
            }
            return null;
        }
        private string check(string ID)
        {
            List<HoaDon> list = context.HoaDons.ToList();
            foreach (var item in list)
            {
                if (ID.Equals(item.MaHoaDon))
                {
                    return item.MaHoaDon;
                }
            }
            return null;
        }

        #endregion

        #region event

        //Không tìm thấy gunabutton 1   
        //private void gunaButton1_Click(object sender, EventArgs e)
        //{
        //    if (txtMaHD.Text == "" || txtMaKH.Text == "" || txtMaNV.Text == "")
        //        throw new Exception("Vui lòng nhập đầy đủ thông tin hóa đơn");
        //    if (checkStudent(txtMaHD.Text) != null)
        //    {
        //        MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
        //    }
        //    else
        //    {
        //        dataGridView1.Rows.Add(txtTenSP.Text, txtSoLuong.Text, txtThanhTien.Text);
        //    }
        //}

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string temp = checkNV(frmSignIn.valueText);
            List<SanPham> sanPhams = context.SanPhams.ToList();
            List<KhachHang> KH = context.KhachHangs.ToList();
            loadKH(KH);
            loadGridView2(sanPhams);
            txtMaNV.Text = temp;
        }



        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            txtMaHD2.Text = txtMaHD.Text;
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView2.CurrentCell.Selected = true;
                    txtMaSP.Text = dataGridView2.Rows[e.RowIndex].Cells["Column7"].FormattedValue.ToString();
                    txtTenSP.Text = dataGridView2.Rows[e.RowIndex].Cells["Column8"].FormattedValue.ToString();
                    txtDonGia.Text = dataGridView2.Rows[e.RowIndex].Cells["Column9"].FormattedValue.ToString();
                    var item = context.SanPhams.FirstOrDefault(p => p.MaSanPham == txtMaSP.Text);
                    byte[] arr = item.HinhAnh;
                    MemoryStream ms = new MemoryStream(arr);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentCell.Selected = true;
                    txtMaHD2.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                    txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    txtDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();
                    txtSoLuong.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    txtThanhTien.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = txtTenSP.Text;
            dataGridView1.Rows[index].Cells[1].Value = txtSoLuong.Text;
            dataGridView1.Rows[index].Cells[2].Value = txtDonGia.Text;
            dataGridView1.Rows[index].Cells[3].Value = txtThanhTien.Text;
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            txtTongTien.Text = sum.ToString();
            LamMoi();

            //HoaDon hd = new HoaDon() { MaHoaDon = txtMaHD.Text, TongTien = Convert.ToInt32(txtTongTien.Text), MaNhanVien = txtMaNV.Text, MaKhachHang = cbxMaKH.Text };
            //context.HoaDons.Add(hd);
            //context.SaveChanges();

            //ChiTietHoaDon cthd = new ChiTietHoaDon() { MaHoaDon = txtMaHD2.Text, MaSanPham = txtMaSP.Text, SoLuong = Convert.ToInt32(txtSoLuong.Text), ThanhTien = Convert.ToInt32(txtThanhTien.Text), NgayLapHoaDon = dateTimePicker1.Value };
            //context.ChiTietHoaDons.Add(cthd);
            //context.SaveChanges();


            //if (txtMaHD.Text == "" || cbxMaKH.Text == "" || txtMaNV.Text == "")
            //    throw new Exception("Vui lòng nhập đầy đủ thông tin hóa đơn");
            //if (check(txtMaHD.Text) != null)
            //{
            //    HoaDon update = context.HoaDons.FirstOrDefault(p => p.MaHoaDon == txtMaHD.Text);
            //    if (update != null)
            //    {
            //        update.TongTien = Convert.ToInt32(txtTongTien.Text);
            //    }
            //}
            //else
            //{
            //    double sum = 0;
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            //    }
            //    txtTongTien.Text = sum.ToString();
            //    HoaDon stu = new HoaDon()
            //    {
            //        MaHoaDon = txtMaHD.Text,
            //        MaKhachHang = cbxMaKH.Text,
            //        MaNhanVien = txtMaNV.Text,
            //        TongTien = Convert.ToDouble(txtTongTien.Text)
            //    };
            //    context.HoaDons.Add(stu);
            //    context.SaveChanges();

            //    ChiTietHoaDon stu1 = new ChiTietHoaDon()
            //    {
            //        MaHoaDon = txtMaHD2.Text,
            //        MaSanPham = txtMaSP.Text,
            //        SoLuong = Convert.ToInt32(txtSoLuong.Text),
            //        ThanhTien = Convert.ToDouble(txtThanhTien.Text),
            //        NgayLapHoaDon = dateTimePicker1.Value
            //    };
            //    context.ChiTietHoaDons.Add(stu1);
            //    context.SaveChanges();

            //    double SoLuong = Convert.ToDouble(txtSoLuong.Text);
            //    double DonGia = Convert.ToDouble(txtDonGia.Text);
            //    int index = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[index].Cells[0].Value = txtTenSP.Text;
            //    dataGridView1.Rows[index].Cells[1].Value = txtSoLuong.Text;
            //    dataGridView1.Rows[index].Cells[2].Value = Convert.ToDouble(SoLuong * DonGia);

            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        txtTongTien.Text += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
            //    }
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            LamMoi();

            //if (check(txtMaHD.Text) == null || check(txtMaSP.Text) == null)
            //{
            //    MessageBox.Show("Không tìm thấy vật phẩm cần xóa!", "Thông báo!", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    ChiTietHoaDon delete = context.ChiTietHoaDons.FirstOrDefault(p => p.MaHoaDon == txtMaHD.Text && p.MaSanPham == txtMaSP.Text);
            //    if (delete != null)
            //    {
            //        if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            context.ChiTietHoaDons.Remove(delete);
            //            context.SaveChanges();
            //            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            List<ChiTietHoaDon> list = context.ChiTietHoaDons.ToList();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy mã nhân viên cần xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hd = new HoaDon() { MaHoaDon = txtMaHD.Text, TongTien = Convert.ToInt32(txtTongTien.Text), MaNhanVien = txtMaNV.Text, MaKhachHang = cbxMaKH.Text };
                context.HoaDons.Add(hd);
                context.SaveChanges();

                ChiTietHoaDon cthd = new ChiTietHoaDon() { MaHoaDon = txtMaHD2.Text, MaSanPham = txtMaSP.Text, SoLuong = Convert.ToInt32(txtSoLuong.Text), ThanhTien = Convert.ToInt32(txtThanhTien.Text), NgayLapHoaDon = dateTimePicker1.Value };
                context.ChiTietHoaDons.Add(cthd);
                context.SaveChanges();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
