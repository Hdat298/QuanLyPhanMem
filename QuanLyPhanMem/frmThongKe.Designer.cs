namespace from_thong_ke
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maHoaDonLabel;
            System.Windows.Forms.Label tongGiaLabel;
            System.Windows.Forms.Label ngaylaplb;
            System.Windows.Forms.Label label2;
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNgay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.dtpNam = new System.Windows.Forms.DateTimePicker();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            maHoaDonLabel = new System.Windows.Forms.Label();
            tongGiaLabel = new System.Windows.Forms.Label();
            ngaylaplb = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Location = new System.Drawing.Point(14, 32);
            maHoaDonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(68, 13);
            maHoaDonLabel.TabIndex = 1;
            maHoaDonLabel.Text = "Mã hóa đơn:";
            // 
            // tongGiaLabel
            // 
            tongGiaLabel.AutoSize = true;
            tongGiaLabel.Location = new System.Drawing.Point(14, 132);
            tongGiaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tongGiaLabel.Name = "tongGiaLabel";
            tongGiaLabel.Size = new System.Drawing.Size(52, 13);
            tongGiaLabel.TabIndex = 7;
            tongGiaLabel.Text = "Tổng giá:";
            // 
            // ngaylaplb
            // 
            ngaylaplb.AutoSize = true;
            ngaylaplb.Location = new System.Drawing.Point(14, 63);
            ngaylaplb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngaylaplb.Name = "ngaylaplb";
            ngaylaplb.Size = new System.Drawing.Size(49, 13);
            ngaylaplb.TabIndex = 3;
            ngaylaplb.Text = "Ngày lập";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(94, 29);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(95, 20);
            this.txtMaHD.TabIndex = 2;
            // 
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(94, 130);
            this.txtTongGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(95, 20);
            this.txtTongGia.TabIndex = 8;
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
            this.dgvThongKe.Location = new System.Drawing.Point(327, 11);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(545, 437);
            this.dgvThongKe.TabIndex = 8;
            this.dgvThongKe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongKe_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // maHD
            // 
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.Name = "maHD";
            // 
            // ngayLap
            // 
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.Name = "ngayLap";
            // 
            // tongGia
            // 
            this.tongGia.HeaderText = "Tổng giá";
            this.tongGia.Name = "tongGia";
            // 
            // btnNgay
            // 
            this.btnNgay.Location = new System.Drawing.Point(16, 184);
            this.btnNgay.Margin = new System.Windows.Forms.Padding(2);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(94, 28);
            this.btnNgay.TabIndex = 11;
            this.btnNgay.Text = "Theo ngày";
            this.btnNgay.UseVisualStyleBackColor = true;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tính tổng doanh thu";
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(16, 216);
            this.btnThang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(94, 28);
            this.btnThang.TabIndex = 13;
            this.btnThang.Text = "Theo tháng";
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(16, 249);
            this.btnNam.Margin = new System.Windows.Forms.Padding(2);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(94, 28);
            this.btnNam.TabIndex = 14;
            this.btnNam.Text = "Theo năm";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(94, 60);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(95, 20);
            this.txtNgayLap.TabIndex = 4;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(115, 186);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(83, 20);
            this.dtpNgay.TabIndex = 15;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(115, 218);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(83, 20);
            this.dtpThang.TabIndex = 16;
            // 
            // dtpNam
            // 
            this.dtpNam.CustomFormat = "yyyy";
            this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNam.Location = new System.Drawing.Point(115, 251);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Size = new System.Drawing.Size(83, 20);
            this.dtpNam.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 317);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 13);
            label2.TabIndex = 18;
            label2.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(101, 310);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(95, 20);
            this.txtTongDoanhThu.TabIndex = 19;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 471);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
  
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTongGia;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGia;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.DateTimePicker dtpNam;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
    }
}