
namespace QuanLyPhanMem
{
    partial class frmHoadon
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
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLDA2DataSet = new QuanLyPhanMem.QLDA2DataSet();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonTableAdapter = new QuanLyPhanMem.QLDA2DataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.tableAdapterManager = new QuanLyPhanMem.QLDA2DataSetTableAdapters.TableAdapterManager();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTonggia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.qLDA2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(1273, 95);
            this.btnRepair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(100, 28);
            this.btnRepair.TabIndex = 41;
            this.btnRepair.Text = "Repair";
            this.btnRepair.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1273, 53);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1273, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(569, 52);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(213, 22);
            this.dtpNgayLap.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "NGAYLAP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(921, 14);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(303, 22);
            this.txtMaSP.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(816, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "MASP";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(921, 98);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(303, 22);
            this.txtMaHD.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(816, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "MAKH";
            // 
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(141, 52);
            this.txtTongGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(293, 22);
            this.txtTongGia.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "TONG GIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "SL";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(141, 82);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(132, 22);
            this.txtSL.TabIndex = 29;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(311, 15);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(472, 22);
            this.txtTenMH.TabIndex = 28;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(921, 55);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(303, 22);
            this.txtMaKH.TabIndex = 27;
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(141, 15);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(65, 22);
            this.txtSTT.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "TENMH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(812, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "MAHD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "STT";
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
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaHD,
            this.colNgayLap,
            this.colMaKH,
            this.colMaSP,
            this.colSL,
            this.colTonggia});
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(12, 132);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(1369, 626);
            this.lsvHoaDon.TabIndex = 42;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã hóa đơn";
            this.colMaHD.Width = 150;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã khách hàng";
            this.colMaKH.Width = 150;
            // 
            // colMaSP
            // 
            this.colMaSP.Text = "Mã sản phẩm";
            this.colMaSP.Width = 150;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Text = "Ngày lập";
            this.colNgayLap.Width = 100;
            // 
            // colSL
            // 
            this.colSL.Text = "Số lượng";
            // 
            // colTonggia
            // 
            this.colTonggia.Text = "Tổng giá";
            this.colTonggia.Width = 100;
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 770);
            this.Controls.Add(this.lsvHoaDon);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtSTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHoadon";
            this.Text = "frmHoadon";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDA2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLDA2DataSet qLDA2DataSet;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private QLDA2DataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private QLDA2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colNgayLap;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colMaSP;
        private System.Windows.Forms.ColumnHeader colSL;
        private System.Windows.Forms.ColumnHeader colTonggia;
    }
}