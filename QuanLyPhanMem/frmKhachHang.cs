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
        QLDAEntities context = new QLDAEntities();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private string check(string ID)
        {
            List<KhachHang> list = context.KhachHangs.ToList();
            foreach (var student in list)
            {
                if (ID.Equals(student.MaKhachHang))
                {
                    return student.MaKhachHang;
                }
            }
            return null;
        }
        private void loadGridView(List<KhachHang> listStudents)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in listStudents)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.MaKhachHang;
                dgvKhachHang.Rows[index].Cells[1].Value = item.TenKhachHang;
                dgvKhachHang.Rows[index].Cells[2].Value = item.Phai;
                dgvKhachHang.Rows[index].Cells[3].Value = item.NgaySinh;
                dgvKhachHang.Rows[index].Cells[4].Value = item.DiaChi;
                dgvKhachHang.Rows[index].Cells[5].Value = item.SDT;
                dgvKhachHang.Rows[index].Cells[6].Value = item.Email;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || cbPhai.Text == "" || dtpNgaySinh.Text == "" || txtSDT.Text == "" || txtMail.Text == "")
                throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng");
            try
            {
                if (check(txtMaKH.Text) != null)
                {
                    MessageBox.Show("Tài khoản khách hàng đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    KhachHang kh = new KhachHang() { MaKhachHang = txtMaKH.Text, TenKhachHang = txtHoTen.Text, Phai = cbPhai.Text, SDT = txtSDT.Text, NgaySinh = dtpNgaySinh.Value, Email = txtMail.Text, DiaChi = txtDiaChi.Text };
                    context.KhachHangs.Add(kh);
                    context.SaveChanges();
                    List<KhachHang> a = context.KhachHangs.ToList();
                    loadGridView(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "" || cbPhai.Text == "" || dtpNgaySinh.Text == "" || txtSDT.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (check(txtMaKH.Text) == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    KhachHang updateSTu = context.KhachHangs.FirstOrDefault(p => p.MaKhachHang == txtMaKH.Text);
                    
                    if (updateSTu != null)
                    {
                        updateSTu.MaKhachHang = txtMaKH.Text;
                        updateSTu.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                        updateSTu.Phai = cbPhai.Text;
                        updateSTu.SDT = txtSDT.Text;
                        updateSTu.TenKhachHang = txtHoTen.Text;
                        updateSTu.Email = txtMail.Text;
                        updateSTu.DiaChi = txtDiaChi.Text;
                        context.SaveChanges();
                    }
                    List<KhachHang> listStudents = context.KhachHangs.ToList();
                    loadGridView(listStudents);
                }
            }
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (check(txtMaKH.Text) == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng cần xóa!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                KhachHang deleteStuDB = context.KhachHangs.FirstOrDefault(p => p.MaKhachHang == txtMaKH.Text);
                if (deleteStuDB != null)
                {
                    if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.KhachHangs.Remove(deleteStuDB);
                        context.SaveChanges();
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<KhachHang> listStudents = context.KhachHangs.ToList();
                        loadGridView(listStudents);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng cần xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvKhachHang.CurrentCell.Selected = true;
                    txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column0"].FormattedValue.ToString();
                    txtHoTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    cbPhai.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    dtpNgaySinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                    txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();                    
                    txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    txtMail.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            List<KhachHang> kh = context.KhachHangs.ToList();
            loadGridView(kh);
        }
    }
}
