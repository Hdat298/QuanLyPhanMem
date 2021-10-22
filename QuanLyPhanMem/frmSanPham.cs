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
    public partial class frmSanPham : Form
    {
        QLDAEntities ProjectContext = new QLDAEntities();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                List<SanPham> listSP = ProjectContext.SanPhams.ToList();
                List<Loai> listLoai = ProjectContext.Loais.ToList();
                List<NhaCungCap> listNCC = ProjectContext.NhaCungCaps.ToList();
                loadGrid(listSP);
                loadTenLoai(listLoai);
                loadDonVi(listSP);
                loadNCC(listNCC);
                cbxLoai.Text = null;
                cbxNCC.Text = null;
                cbxDonVi.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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
        }

        private void loadDonVi(List<SanPham> listSP)
        {
            cbxDonVi.DataSource = listSP;
            cbxDonVi.DisplayMember = "DonViTinh";
            cbxDonVi.ValueMember = "DonViTinh";
        }

        private string checkNCC(string TenCTY)
        {
            List<NhaCungCap> listNCC = ProjectContext.NhaCungCaps.ToList();
            foreach (var item in listNCC)
            {
                if (TenCTY == item.TenCTY)
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
                if (TLoai == item.TenLoai)
                {
                    return item.MaLoai;
                }
            }
            return null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" && txtMaSP.Text == "" && cbxNCC.Text == "" && txtGia.Text == "" && cbxLoai.Text == "" && cbxDonVi.Text == "")
            {
                MessageBox.Show("Thông tin nhập vào thiếu!", "Thông báo!", MessageBoxButtons.OK);
                txtTenSP.Focus();
            }
            else
            {
                try
                {
                    string temp = checkNCC(cbxNCC.Text);
                    string temp1 = checkLoai(cbxLoai.Text);
                    List<SanPham> listSP = ProjectContext.SanPhams.ToList();
                    List<SanPham> listSearchSP = (from s in listSP
                                                  where s.TenSanPham == txtTenSP.Text || s.MaCTY == temp || s.MaLoai == temp1
                                                  select s).ToList();
                    loadGrid(listSearchSP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }     
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
            txtTenSP.Text = null;
            txtMaSP.Text = null;
            txtGia.Text = null;
            cbxDonVi.Text = null;
            cbxLoai.Text = null;
            cbxNCC.Text = null;
        }
    }
}
