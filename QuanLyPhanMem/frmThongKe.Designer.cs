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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maHoaDonLabel;
            System.Windows.Forms.Label maSanPhamLabel;
            System.Windows.Forms.Label tongGiaLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label ngayLapHoaDonLabel;
            this.qLDA2DataSet = new QuanLyPhanMem.QLDA2DataSet();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonTableAdapter = new QuanLyPhanMem.QLDA2DataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.tableAdapterManager = new QuanLyPhanMem.QLDA2DataSetTableAdapters.TableAdapterManager();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.tongGiaTextBox = new System.Windows.Forms.TextBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new QuanLyPhanMem.QLDA2DataSetTableAdapters.HoaDonTableAdapter();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRep = new System.Windows.Forms.Button();
            maHoaDonLabel = new System.Windows.Forms.Label();
            maSanPhamLabel = new System.Windows.Forms.Label();
            tongGiaLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            ngayLapHoaDonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDA2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Location = new System.Drawing.Point(19, 39);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(87, 17);
            maHoaDonLabel.TabIndex = 1;
            maHoaDonLabel.Text = "Mã hóa đơn:";
            // 
            // maSanPhamLabel
            // 
            maSanPhamLabel.AutoSize = true;
            maSanPhamLabel.Location = new System.Drawing.Point(19, 77);
            maSanPhamLabel.Name = "maSanPhamLabel";
            maSanPhamLabel.Size = new System.Drawing.Size(93, 17);
            maSanPhamLabel.TabIndex = 3;
            maSanPhamLabel.Text = "Mã sản phẩm";
            // 
            // tongGiaLabel
            // 
            tongGiaLabel.AutoSize = true;
            tongGiaLabel.Location = new System.Drawing.Point(19, 163);
            tongGiaLabel.Name = "tongGiaLabel";
            tongGiaLabel.Size = new System.Drawing.Size(68, 17);
            tongGiaLabel.TabIndex = 7;
            tongGiaLabel.Text = "Tổng giá:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(19, 119);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(68, 17);
            soLuongLabel.TabIndex = 8;
            soLuongLabel.Text = "Số lượng:";
            // 
            // ngayLapHoaDonLabel
            // 
            ngayLapHoaDonLabel.AutoSize = true;
            ngayLapHoaDonLabel.Location = new System.Drawing.Point(19, 210);
            ngayLapHoaDonLabel.Name = "ngayLapHoaDonLabel";
            ngayLapHoaDonLabel.Size = new System.Drawing.Size(68, 17);
            ngayLapHoaDonLabel.TabIndex = 9;
            ngayLapHoaDonLabel.Text = "Ngày lập:";
            // 
            // qLDA2DataSet
            // 
            this.qLDA2DataSet.DataSetName = "QLDA2DataSet";
            this.qLDA2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.qLDA2DataSet;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHoaDonTableAdapter = this.chiTietHoaDonTableAdapter;
            this.tableAdapterManager.ChiTietPhieuXuatKhoTableAdapter = null;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.LoaiTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuXuatKhoTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyPhanMem.QLDA2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "MaHoaDon", true));
            this.txtMaHD.Location = new System.Drawing.Point(125, 36);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(125, 22);
            this.txtMaHD.TabIndex = 2;
            // 
            // txtMaSP
            // 
            this.txtMaSP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "MaSanPham", true));
            this.txtMaSP.Location = new System.Drawing.Point(125, 74);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(125, 22);
            this.txtMaSP.TabIndex = 4;
            // 
            // tongGiaTextBox
            // 
            this.tongGiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chiTietHoaDonBindingSource, "TongGia", true));
            this.tongGiaTextBox.Location = new System.Drawing.Point(125, 160);
            this.tongGiaTextBox.Name = "tongGiaTextBox";
            this.tongGiaTextBox.Size = new System.Drawing.Size(125, 22);
            this.tongGiaTextBox.TabIndex = 8;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoGenerateColumns = false;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvThongKe.DataSource = this.chiTietHoaDonBindingSource;
            this.dgvThongKe.Location = new System.Drawing.Point(297, 22);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(860, 538);
            this.dgvThongKe.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSanPham";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaSanPham";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHoaDon";
            this.Column1.HeaderText = "NgayLap";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TongGia";
            this.dataGridViewTextBoxColumn4.HeaderText = "TongGia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // nudSL
            // 
            this.nudSL.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.chiTietHoaDonBindingSource, "SoLuong", true));
            this.nudSL.Location = new System.Drawing.Point(125, 117);
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(68, 22);
            this.nudSL.TabIndex = 9;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.qLDA2DataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoaDonBindingSource, "NgayLapHoaDon", true));
            this.dtpNgayLap.Location = new System.Drawing.Point(22, 240);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLap.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(22, 344);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 35);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRep
            // 
            this.btnRep.Location = new System.Drawing.Point(22, 401);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(90, 35);
            this.btnRep.TabIndex = 13;
            this.btnRep.Text = "Repair";
            this.btnRep.UseVisualStyleBackColor = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 580);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(ngayLapHoaDonLabel);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(soLuongLabel);
            this.Controls.Add(this.nudSL);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(maHoaDonLabel);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(maSanPhamLabel);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(tongGiaLabel);
            this.Controls.Add(this.tongGiaTextBox);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDA2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDA2DataSet qLDA2DataSet;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private QLDA2DataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private QLDA2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox tongGiaTextBox;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QLDA2DataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRep;
    }
}