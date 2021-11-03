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


    private void gunaButton1_Click(object sender, EventArgs e)
    {
    if (txtMaHD.Text == "" || txtMaKH.Text == "" || txtMaNV.Text == "")
        throw new Exception("Vui lòng nhập đầy đủ thông tin hóa đơn");
    if (checkStudent(txtMaHD.Text) != null)
        {
            MessageBox.Show("Hóa đơn đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
        }
    else
        {
            dataGridView1.Rows.Add(txtTenSP.Text, txtSoLuong.Text, txtThanhTien.Text);
        }
    }

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

        

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentCell.Selected = true;
                    txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column7"].FormattedValue.ToString();
                    txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column8"].FormattedValue.ToString();
                    txtDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells["Column9"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text)).ToString();
        }

        #endregion
    }
}
