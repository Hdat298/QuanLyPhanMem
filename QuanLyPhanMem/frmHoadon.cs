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
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }

        private void chiTietHoaDonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietHoaDonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDA2DataSet);

        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDA2DataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.qLDA2DataSet.ChiTietHoaDon);

        }
        private void SetNull()
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
