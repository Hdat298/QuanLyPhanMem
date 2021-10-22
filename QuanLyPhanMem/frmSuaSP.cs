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
    }
}
