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

        private string checkStudent(string studentID)
        {
            List<NhanVien> listStudents = context.NhanViens.ToList();
            foreach (var student in listStudents)
            {
                if (studentID.Equals(student.MaNhanVien))
                {
                    return student.MaNhanVien;
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
            List<SanPham> sanPhams = context.SanPhams.ToList();
            loadGridView2(sanPhams);
    }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();
        }

        #endregion

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (txtMaHD.Text == "" || txtMaKH.Text == "" || txtMaNV.Text == "")
            //    throw new Exception("Vui lòng nhập đầy đủ thông tin hóa đơn");
            //if (checkStudent(txtMaHD.Text) != null)
            //{
            //    MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    double SoLuong = Convert.ToDouble(txtSoLuong.Text);
            //    double DonGia = Convert.ToDouble(txtDonGia.Text);
            //    int index = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[index].Cells[0].Value = txtTenSP.Text;
            //    dataGridView1.Rows[index].Cells[1].Value = txtSoLuong.Text;
            //    dataGridView1.Rows[index].Cells[2].Value = Convert.ToDouble(SoLuong * DonGia);
            //}
            double SoLuong = Convert.ToDouble(txtSoLuong.Text);
            double DonGia = Convert.ToDouble(txtDonGia.Text);
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = txtTenSP.Text;
            dataGridView1.Rows[index].Cells[1].Value = txtSoLuong.Text;
            dataGridView1.Rows[index].Cells[2].Value = Convert.ToDouble(SoLuong * DonGia);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
