
namespace QuanLyPhanMem
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtTongGia = new System.Windows.Forms.TextBox();
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
            label2.Location = new System.Drawing.Point(29, 337);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 13);
            label2.TabIndex = 34;
            label2.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(128, 334);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(95, 20);
            this.txtTongDoanhThu.TabIndex = 35;
            // 
            // dtpNam
            // 
            this.dtpNam.CustomFormat = "yyyy";
            this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNam.Location = new System.Drawing.Point(128, 271);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Size = new System.Drawing.Size(83, 20);
            this.dtpNam.TabIndex = 33;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(128, 238);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(83, 20);
            this.dtpThang.TabIndex = 32;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(128, 206);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(83, 20);
            this.dtpNgay.TabIndex = 31;
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(29, 269);
            this.btnNam.Margin = new System.Windows.Forms.Padding(2);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(94, 28);
            this.btnNam.TabIndex = 30;
            this.btnNam.Text = "Theo năm";
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(29, 236);
            this.btnThang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(94, 28);
            this.btnThang.TabIndex = 29;
            this.btnThang.Text = "Theo tháng";
            this.btnThang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tính tổng doanh thu";
            // 
            // btnNgay
            // 
            this.btnNgay.Location = new System.Drawing.Point(29, 204);
            this.btnNgay.Margin = new System.Windows.Forms.Padding(2);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(94, 28);
            this.btnNgay.TabIndex = 27;
            this.btnNgay.Text = "Theo ngày";
            this.btnNgay.UseVisualStyleBackColor = true;
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
            this.dgvThongKe.Location = new System.Drawing.Point(340, 31);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(545, 437);
            this.dgvThongKe.TabIndex = 25;
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
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Location = new System.Drawing.Point(27, 52);
            maHoaDonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(68, 13);
            maHoaDonLabel.TabIndex = 20;
            maHoaDonLabel.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(107, 49);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(95, 20);
            this.txtMaHD.TabIndex = 21;
            // 
            // ngaylaplb
            // 
            ngaylaplb.AutoSize = true;
            ngaylaplb.Location = new System.Drawing.Point(27, 83);
            ngaylaplb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngaylaplb.Name = "ngaylaplb";
            ngaylaplb.Size = new System.Drawing.Size(49, 13);
            ngaylaplb.TabIndex = 22;
            ngaylaplb.Text = "Ngày lập";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(107, 80);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(95, 20);
            this.txtNgayLap.TabIndex = 23;
            // 
            // tongGiaLabel
            // 
            tongGiaLabel.AutoSize = true;
            tongGiaLabel.Location = new System.Drawing.Point(27, 152);
            tongGiaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tongGiaLabel.Name = "tongGiaLabel";
            tongGiaLabel.Size = new System.Drawing.Size(52, 13);
            tongGiaLabel.TabIndex = 24;
            tongGiaLabel.Text = "Tổng giá:";
            // 
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(107, 150);
            this.txtTongGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(95, 20);
            this.txtTongGia.TabIndex = 26;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 514);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.dtpNam);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNgay);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(maHoaDonLabel);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(ngaylaplb);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(tongGiaLabel);
            this.Controls.Add(this.txtTongGia);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpNam;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGia;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtTongGia;
    }
}