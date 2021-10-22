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
    public partial class Register2 : Form
    {
        QLDAEntities1 context = new QLDAEntities1();
        public Register2()
        {
            InitializeComponent();
        }
        #region method

        private void LoadGridView(List<NhanVien> nhanViens)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in nhanViens)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaNhanVien;
                dataGridView1.Rows[index].Cells[1].Value = item.TenNhanVien;
                dataGridView1.Rows[index].Cells[2].Value = item.ChucVu.TenChucVu;
                dataGridView1.Rows[index].Cells[3].Value = item.Email;
                dataGridView1.Rows[index].Cells[4].Value = item.Phai;
                dataGridView1.Rows[index].Cells[5].Value = item.SDT;
                dataGridView1.Rows[index].Cells[6].Value = item.NgaySinh;
                dataGridView1.Rows[index].Cells[7].Value = item.DiaChi;
                dataGridView1.Rows[index].Cells[8].Value = item.TenTaiKhoan;
                dataGridView1.Rows[index].Cells[9].Value = item.MatKhau;
                dataGridView1.Rows[index].Cells[10].Value = item.LoaiTK;
            }
        }

        private string checkNhanvien(string studentID)
        {
            List<NhanVien> nhanViens = context.NhanViens.ToList();
            foreach (var student in nhanViens)
            {
                if (studentID.Equals(student.MaNhanVien))
                {
                    return student.MaNhanVien;
                }
            }
            return null;
        }
        private string checkFaculty(string facultyName)
        {
            List<ChucVu> listFaculties = context.ChucVus.ToList();
            foreach (var faculty in listFaculties)
            {
                if (facultyName == faculty.TenChucVu)
                {
                    return faculty.MaChucVu;
                }
            }
            return null;
        }

        #endregion


        #region event
        private void Register2_Load(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = context.NhanViens.ToList();
            LoadGridView(nhanViens);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNhanvien(txtMa.Text) != null)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    string temp = checkFaculty(cmbChucVu.Text);
                    NhanVien stu = new NhanVien() { MaNhanVien = txtMa.Text, 
                                                    TenNhanVien = txtTen.Text, 
                                                    MaChucVu = temp,
                                                    DiaChi = txtDiachi.Text,
                                                    Email = txtemail.Text,
                                                    Phai = cmbPhai.Text,
                                                    SDT = txtSDT.Text,
                                                    NgaySinh = dtpNgaysinh.Value,
                                                    TenTaiKhoan = txtTenTK.Text,
                                                    MatKhau = txtTenMK.Text,
                                                    LoaiTK = cmbLoai.Text,
                    };
                    context.NhanViens.Add(stu);
                    context.SaveChanges();
                    List<NhanVien> nhanViens = context.NhanViens.ToList();
                    LoadGridView(nhanViens);

                    MessageBox.Show("thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkNhanvien(txtMa.Text) == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên cần xóa!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                NhanVien deleteStuDB = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == txtMa.Text);
                if (deleteStuDB != null)
                {
                    if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.NhanViens.Remove(deleteStuDB);
                        context.SaveChanges();
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<NhanVien> listStudents = context.NhanViens.ToList();
                        LoadGridView(listStudents);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentCell.Selected = true;
                    txtMa.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    cmbChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                    txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                    cmbPhai.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();
                    dtpNgaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells["Column7"].FormattedValue.ToString();
                    txtDiachi.Text = dataGridView1.Rows[e.RowIndex].Cells["Column8"].FormattedValue.ToString();
                    txtTenTK.Text = dataGridView1.Rows[e.RowIndex].Cells["Column9"].FormattedValue.ToString();
                    txtTenMK.Text = dataGridView1.Rows[e.RowIndex].Cells["Column10"].FormattedValue.ToString();
                    cmbLoai.Text = dataGridView1.Rows[e.RowIndex].Cells["Column11"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (checkNhanvien(txtMa.Text) == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    NhanVien updateSTu = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == txtMa.Text);
                    string temp = checkFaculty(cmbChucVu.Text);
                    if (updateSTu != null)
                    {
                        updateSTu.TenNhanVien = txtTen.Text;
                        updateSTu.MaNhanVien = txtMa.Text;
                        updateSTu.DiaChi = txtDiachi.Text;
                        updateSTu.Email = txtemail.Text;
                        updateSTu.Phai = cmbPhai.Text;
                        updateSTu.SDT = txtSDT.Text;
                        updateSTu.NgaySinh = dtpNgaysinh.Value;
                        updateSTu.TenTaiKhoan = txtTenTK.Text;
                        updateSTu.MatKhau = txtTenMK.Text;
                        updateSTu.LoaiTK = cmbLoai.Text;
                        updateSTu.MaChucVu = temp;
                        context.SaveChanges();
                    }
                    List<NhanVien> listStudents = context.NhanViens.ToList();
                    LoadGridView(listStudents);
                }
            }
        }
    }
}
