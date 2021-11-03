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
    public partial class frmSuaSP : Form
    {
        QLDAEntities ProjectContext = new QLDAEntities();
        public frmSuaSP()
        {
            InitializeComponent();
        }

        private void frmSuaSP_Load(object sender, EventArgs e)
        {
            try
            {
                List<SanPham> listSP = ProjectContext.SanPhams.ToList();
                List<Loai> listLoai = ProjectContext.Loais.ToList();
                List<NhaCungCap> listNCC = ProjectContext.NhaCungCaps.ToList();
                loadGrid(listSP);
                loadTenLoai(listLoai);
                loadNCC(listNCC);
                loadDonVi(listSP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void Refresh()
        {
            txtTenSP.Text = null;
            txtMaSP.Text = null;
            txtGia.Text = null;
            cbxDonVi.Text = null;
            cbxLoai.Text = null;
            cbxNCC.Text = null;
            pictureBox1.Image = null;
        }
        private void loadGrid(List<SanPham> listSP)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listSP)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaSanPham;
                dataGridView1.Rows[index].Cells[1].Value = item.TenSanPham;
                dataGridView1.Rows[index].Cells[2].Value = item.Loai.TenLoai;
                dataGridView1.Rows[index].Cells[3].Value = item.NhaCungCap.TenCTY;
                dataGridView1.Rows[index].Cells[4].Value = item.DonGia;
                dataGridView1.Rows[index].Cells[5].Value = item.DonViTinh;
            }
        }

        private void loadTenLoai(List<Loai> listLoai)
        {
            cbxLoai.DataSource = listLoai;
            cbxLoai.DisplayMember = "TenLoai";
            cbxLoai.ValueMember = "MaLoai";
            cbxLoai.Text = null;
        }

        private void loadNCC(List<NhaCungCap> listNCC)
        {
            cbxNCC.DataSource = listNCC;
            cbxNCC.DisplayMember = "TenCTY";
            cbxNCC.ValueMember = "MaCTY";
            cbxNCC.Text = null;
        }

        private void loadDonVi(List<SanPham> listSP)
        {
            cbxDonVi.DataSource = listSP;
            cbxDonVi.DisplayMember = "DonViTinh";
            cbxDonVi.ValueMember = "DonViTinh";
            cbxDonVi.Text = null;
        }

        private string checkNCC(string TenCTY)
        {
            List<NhaCungCap> listNCC = ProjectContext.NhaCungCaps.ToList();
            foreach (var item in listNCC)
            {
                if(TenCTY == item.TenCTY)
                {
                    return item.MaCTY;
                }
            }
            return null;
        }

        private string checkLoai(string TLoai)
        {
            List<Loai> listLoai = ProjectContext.Loais.ToList();
            foreach (var item in listLoai)
            {
                if(TLoai == item.TenLoai)
                {
                    return item.MaLoai;
                }
            }
            return null;
        }

        private string checkTrung(string MaSP)
        {
            List<SanPham> listSP = ProjectContext.SanPhams.ToList();
            foreach (var item in listSP)
            {
                if (MaSP.Equals(item.MaSanPham))
                {
                    return item.MaSanPham;
                }
            }
            return null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentCell.Selected = true;
                    txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    cbxLoai.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                    cbxNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                    txtGia.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    cbxDonVi.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();
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
            if (txtTenSP.Text == "" || txtMaSP.Text == "" || cbxNCC.Text == "" || txtGia.Text == "" || cbxLoai.Text == "" || cbxDonVi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                if (checkTrung(txtMaSP.Text) != null)
                {
                    MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    Image img = Image.FromFile(pictureBox1.ImageLocation);
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    string temp = checkNCC(cbxNCC.Text);
                    string temp1 = checkLoai(cbxLoai.Text);
                    SanPham sp = new SanPham() { MaSanPham = txtMaSP.Text, TenSanPham = txtTenSP.Text, DonGia = int.Parse(txtGia.Text), DonViTinh = cbxDonVi.Text, MaCTY = temp, MaLoai = temp1, HinhAnh = ms.ToArray() };
                    ProjectContext.SanPhams.Add(sp);
                    ProjectContext.SaveChanges();
                    List<SanPham> listSP = ProjectContext.SanPhams.ToList();
                    Refresh();
                    loadGrid(listSP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || txtMaSP.Text == "" || cbxNCC.Text == "" || txtGia.Text == "" || cbxLoai.Text == "" || cbxDonVi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                if (checkTrung(txtMaSP.Text) == null)
                {
                    MessageBox.Show("Không Tìm Thấy Mã Sản Phẩm!", "Thông báo!", MessageBoxButtons.OK);
                }
                else
                {
                    SanPham updateSP = ProjectContext.SanPhams.FirstOrDefault(p => p.MaSanPham == txtMaSP.Text);
                    string temp = checkNCC(cbxNCC.Text);
                    string temp1 = checkLoai(cbxLoai.Text);
                    if (updateSP != null)
                    {
                        updateSP.TenSanPham = txtTenSP.Text;
                        updateSP.DonGia = int.Parse(txtGia.Text);
                        updateSP.DonViTinh = cbxDonVi.Text;
                        updateSP.MaCTY = temp;
                        updateSP.MaLoai = temp1;
                        ProjectContext.SaveChanges();
                    }
                    List<SanPham> listStudents = ProjectContext.SanPhams.ToList();
                    Refresh();
                    loadGrid(listStudents);
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentCell.Selected = true;
                    txtMaSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].FormattedValue.ToString();
                    txtTenSP.Text = dataGridView1.Rows[e.RowIndex].Cells["Column2"].FormattedValue.ToString();
                    cbxLoai.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].FormattedValue.ToString();
                    cbxNCC.Text = dataGridView1.Rows[e.RowIndex].Cells["Column4"].FormattedValue.ToString();
                    txtGia.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].FormattedValue.ToString();
                    cbxDonVi.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].FormattedValue.ToString();

                    var item = ProjectContext.SanPhams.FirstOrDefault(p => p.TenSanPham == txtTenSP.Text);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkTrung(txtMaSP.Text) == null)
            {
                MessageBox.Show("Không tìm thấy sản phầm cần xóa!", "Thông báo!", MessageBoxButtons.OK);
            }
            else
            {
                SanPham deleteSP = ProjectContext.SanPhams.FirstOrDefault(p => p.MaSanPham == txtMaSP.Text);
                if (deleteSP != null)
                {
                    if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ProjectContext.SanPhams.Remove(deleteSP);
                        ProjectContext.SaveChanges();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<SanPham> listStudents = ProjectContext.SanPhams.ToList();
                        Refresh();
                        loadGrid(listStudents);
                    }
                }
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }
    }
}
