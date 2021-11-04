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
    public partial class frmSignIn : Form
    {
        public static string valueText;
        QLDAEntities QLDAContext = new QLDAEntities();
        public frmSignIn()
        {
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if(QLDAContext.NhanViens.Where(p => p.TenTaiKhoan == txtUserName.Text && p.MatKhau == txtPass.Text && p.LoaiTK == "admin").Count() > 0)
                {
                    MessageBox.Show("Đăng nhập admin thành công!", "Thông báo!", MessageBoxButtons.OK);
                    frmAdmin fAdmin = new frmAdmin();
                    valueText = txtUserName.Text;
                    this.Hide();
                    fAdmin.ShowDialog();
                    return;
                }
                if (QLDAContext.NhanViens.Where(p => p.TenTaiKhoan == txtUserName.Text && p.MatKhau == txtPass.Text && p.LoaiTK == "nhanvien").Count() > 0)
                {
                    MessageBox.Show("Đăng nhập nhân viên thành công!", "Thông báo!", MessageBoxButtons.OK);
                    frmMain1 fMain = new frmMain1();
                    valueText = txtUserName.Text;
                    this.Hide();
                    fMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo!", MessageBoxButtons.OK);
                    txtUserName.Clear();
                    txtPass.Clear();
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát ? ","Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
