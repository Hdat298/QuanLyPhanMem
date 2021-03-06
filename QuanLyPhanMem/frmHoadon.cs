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
        private string checkHD(string ID)
        {
            List<ChiTietHoaDon> list = context.ChiTietHoaDons.ToList();
            foreach (var item in list)
            {
                if (ID.Equals(item.MaHoaDon))
                {
                    return item.MaHoaDon;
                }
            }
            return null;
        }

        private string checkSP(string ID)
        {
            List<ChiTietHoaDon> list = context.ChiTietHoaDons.ToList();
            foreach (var item in list)
            {
                if (ID.Equals(item.MaSanPham))
                {
                    return item.MaSanPham;
                }
            }
            return null;
        }

        #endregion

        #region event

        private void loadGridHD(List<HoaDon> listHDs)
        {
            dataGridView3.Rows.Clear();
            foreach (var item in listHDs)
            {
                int index = dataGridView3.Rows.Add();
                dataGridView3.Rows[index].Cells[0].Value = item.MaHoaDon;
                dataGridView3.Rows[index].Cells[1].Value = item.MaKhachHang;
                dataGridView3.Rows[index].Cells[2].Value = item.MaNhanVien;
                dataGridView3.Rows[index].Cells[3].Value = item.TongTien;
            }
        }

        private void loadGridCTHD(List<ChiTietHoaDon> listCTHD)
        {
            List<ChiTietHoaDon> cthd = context.ChiTietHoaDons.Where(p => p.MaHoaDon == txtMaHD.Text).ToList();
            dataGridView1.Rows.Clear();
            foreach (var item in cthd)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.SanPham.TenSanPham;
                dataGridView1.Rows[index].Cells[1].Value = item.SoLuong;
                dataGridView1.Rows[index].Cells[2].Value = item.SanPham.DonGia;
                dataGridView1.Rows[index].Cells[3].Value = item.ThanhTien;
                dataGridView1.Rows[index].Cells[4].Value = item.MaHoaDon;
                dataGridView1.Rows[index].Cells[5].Value = item.MaSanPham;
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string temp = checkNV(frmSignIn.valueText);
            List<SanPham> sanPhams = context.SanPhams.ToList();
            List<KhachHang> KH = context.KhachHangs.ToList();
            List<HoaDon> HD = context.HoaDons.ToList();
            loadGridHD(HD);
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
        private void btnThem1_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cbxMaKH.Text == "" || txtMaNV.Text == "")
                throw new Exception("Vui lòng nhập đầy đủ thông tin hóa đơn");
            HoaDon hd = new HoaDon() { MaHoaDon = txtMaHD.Text, TongTien = 0, MaNhanVien = txtMaNV.Text, MaKhachHang = cbxMaKH.Text };
            context.HoaDons.Add(hd);
            context.SaveChanges();
            MessageBox.Show("Thêm Hóa Đơn Thành Công!", "Thông Báo!");
            dataGridView3.Rows.Clear();
            List<HoaDon> listHDs = context.HoaDons.ToList();
            loadGridHD(listHDs);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = txtTenSP.Text;
            dataGridView1.Rows[index].Cells[1].Value = txtSoLuong.Text;
            dataGridView1.Rows[index].Cells[2].Value = txtDonGia.Text;
            dataGridView1.Rows[index].Cells[3].Value = txtThanhTien.Text;
            dataGridView1.Rows[index].Cells[4].Value = txtMaHD2.Text;
            dataGridView1.Rows[index].Cells[5].Value = txtMaSP.Text;
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            txtTongTien.Text = sum.ToString();

            HoaDon listHD = context.HoaDons.FirstOrDefault(p => p.MaHoaDon == txtMaHD2.Text);
            if(listHD != null)
            {
                listHD.TongTien = Convert.ToDouble(txtTongTien.Text);
            }
            ChiTietHoaDon cthd = new ChiTietHoaDon() { MaHoaDon = txtMaHD2.Text, MaSanPham = txtMaSP.Text, SoLuong = Convert.ToInt32(txtSoLuong.Text), ThanhTien = Convert.ToInt32(txtThanhTien.Text), NgayLapHoaDon = dateTimePicker1.Value };
            context.ChiTietHoaDons.Add(cthd);
            context.SaveChanges();


            
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
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);

            if (checkHD(txtMaHD.Text) == null || checkSP(txtMaSP.Text) == null)
            {
                MessageBox.Show("Không tìm thấy vật phẩm cần xóa!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                ChiTietHoaDon delete = context.ChiTietHoaDons.FirstOrDefault(p => p.MaHoaDon == txtMaHD.Text && p.MaSanPham == txtMaSP.Text);
                if (delete != null)
                {
                    if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.ChiTietHoaDons.Remove(delete);
                        context.SaveChanges();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<ChiTietHoaDon> list = context.ChiTietHoaDons.ToList();
                        loadGridCTHD(list);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên cần xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {                
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView3.CurrentCell.Selected = true;
                    txtMaHD.Text = dataGridView3.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    List<ChiTietHoaDon> cthd = context.ChiTietHoaDons.Where(p => p.MaHoaDon == txtMaHD.Text).ToList();
                    dataGridView1.Rows.Clear();
                    foreach (var item in cthd)
                    {
                        int index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = item.SanPham.TenSanPham;
                        dataGridView1.Rows[index].Cells[1].Value = item.SoLuong;
                        dataGridView1.Rows[index].Cells[2].Value = item.SanPham.DonGia;
                        dataGridView1.Rows[index].Cells[3].Value = item.ThanhTien;
                        dataGridView1.Rows[index].Cells[4].Value = item.MaHoaDon;
                        dataGridView1.Rows[index].Cells[5].Value = item.MaSanPham;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                throw;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            List<HoaDon> list = context.HoaDons.ToList();
            loadGridHD(list);
            dataGridView1.Rows.Clear();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = context.ChiTietHoaDons.FirstOrDefault(p => p.MaHoaDon == txtMaHD.Text);
            if(cthd != null)
            {
                MessageBox.Show("Hãy Xóa Chi Tiết Hóa Đơn Trước Khi Xóa Hóa Đơn!", "Thông Báo");
            }
            else
            {
                HoaDon hd = context.HoaDons.FirstOrDefault(p => p.MaHoaDon == txtMaHD.Text);
                context.HoaDons.Remove(hd);
                context.SaveChanges();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<HoaDon> list = context.HoaDons.ToList();
                loadGridHD(list);
            }
        }
    }
}
