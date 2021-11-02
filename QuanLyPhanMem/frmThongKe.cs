using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace from_thong_ke
{
    public partial class frmThongKe : Form
    {
        private TextBox txtTongDoanhThu;
        private DateTimePicker dtpNam;
        private DateTimePicker dtpThang;
        private DateTimePicker dtpNgay;
        private Button btnNam;
        private Button btnThang;
        private Label label1;
        private Button btnNgay;
        private TextBox txtMaHD;
        private TextBox txtNgayLap;
        private TextBox txtTongGia;
        private DataGridView dgvThongKe;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maHD;
        private DataGridViewTextBoxColumn ngayLap;
        private DataGridViewTextBoxColumn tongGia;
        List<HoaDon> hoaDons;
        public frmThongKe()
        {
            InitializeComponent();
            TaiDanhSachHoaDon();
        }

        private void TaiDanhSachHoaDon()
        {
           
            using (var dbcontext = new HoaDonModel())
            {
                 hoaDons = dbcontext.HoaDons.ToList();
            }

            int soThuTu = 1;
            dgvThongKe.Rows.Clear();
            if (hoaDons.Count <= 0) return;
            foreach (var hd in hoaDons)
            {
                int indexRow = dgvThongKe.Rows.Add();
                dgvThongKe.Rows[indexRow].Cells[0].Value = soThuTu++;
                dgvThongKe.Rows[indexRow].Cells[1].Value = hd.MaHoaDon;
                dgvThongKe.Rows[indexRow].Cells[2].Value = hd.NgayLapHoaDon;
                dgvThongKe.Rows[indexRow].Cells[3].Value = hd.TongGia;
            }
            dgvThongKe.Rows[0].Selected = false;

        }

        private void btnNgay_Click(object sender, System.EventArgs e)
        {

        }

        private void btnThang_Click(object sender, System.EventArgs e)
        {

        }

        private void btnNam_Click(object sender, System.EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label maHoaDonLabel;
            System.Windows.Forms.Label ngaylaplb;
            System.Windows.Forms.Label tongGiaLabel;
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dtpNam = new System.Windows.Forms.DateTimePicker();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNgay = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            maHoaDonLabel = new System.Windows.Forms.Label();
            ngaylaplb = new System.Windows.Forms.Label();
            tongGiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 387);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 17);
            label2.TabIndex = 34;
            label2.Text = "Tổng doanh thu";
            // 
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Location = new System.Drawing.Point(25, 36);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(87, 17);
            maHoaDonLabel.TabIndex = 20;
            maHoaDonLabel.Text = "Mã hóa đơn:";
            // 
            // ngaylaplb
            // 
            ngaylaplb.AutoSize = true;
            ngaylaplb.Location = new System.Drawing.Point(25, 75);
            ngaylaplb.Name = "ngaylaplb";
            ngaylaplb.Size = new System.Drawing.Size(64, 17);
            ngaylaplb.TabIndex = 22;
            ngaylaplb.Text = "Ngày lập";
            // 
            // tongGiaLabel
            // 
            tongGiaLabel.AutoSize = true;
            tongGiaLabel.Location = new System.Drawing.Point(25, 159);
            tongGiaLabel.Name = "tongGiaLabel";
            tongGiaLabel.Size = new System.Drawing.Size(68, 17);
            tongGiaLabel.TabIndex = 24;
            tongGiaLabel.Text = "Tổng giá:";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(141, 379);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(125, 22);
            this.txtTongDoanhThu.TabIndex = 35;
            // 
            // dtpNam
            // 
            this.dtpNam.CustomFormat = "yyyy";
            this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNam.Location = new System.Drawing.Point(159, 306);
            this.dtpNam.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Size = new System.Drawing.Size(109, 22);
            this.dtpNam.TabIndex = 33;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(159, 265);
            this.dtpThang.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(109, 22);
            this.dtpThang.TabIndex = 32;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(159, 226);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(109, 22);
            this.dtpNgay.TabIndex = 31;
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(27, 303);
            this.btnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(125, 34);
            this.btnNam.TabIndex = 30;
            this.btnNam.Text = "Theo năm";
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(27, 263);
            this.btnThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(125, 34);
            this.btnThang.TabIndex = 29;
            this.btnThang.Text = "Theo tháng";
            this.btnThang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tính tổng doanh thu";
            // 
            // btnNgay
            // 
            this.btnNgay.Location = new System.Drawing.Point(27, 223);
            this.btnNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(125, 34);
            this.btnNgay.TabIndex = 27;
            this.btnNgay.Text = "Theo ngày";
            this.btnNgay.UseVisualStyleBackColor = true;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(131, 33);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(125, 22);
            this.txtMaHD.TabIndex = 21;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(131, 71);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(125, 22);
            this.txtNgayLap.TabIndex = 23;
            // 
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(131, 157);
            this.txtTongGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(125, 22);
            this.txtTongGia.TabIndex = 26;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maHD,
            this.ngayLap,
            this.tongGia});
            this.dgvThongKe.Location = new System.Drawing.Point(449, 11);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(727, 538);
            this.dgvThongKe.TabIndex = 36;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // maHD
            // 
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            // 
            // ngayLap
            // 
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            // 
            // tongGia
            // 
            this.tongGia.HeaderText = "Tổng giá";
            this.tongGia.MinimumWidth = 6;
            this.tongGia.Name = "tongGia";
            // 
            // frmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(1188, 556);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.dtpNam);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNgay);
            this.Controls.Add(maHoaDonLabel);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(ngaylaplb);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(tongGiaLabel);
            this.Controls.Add(this.txtTongGia);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
