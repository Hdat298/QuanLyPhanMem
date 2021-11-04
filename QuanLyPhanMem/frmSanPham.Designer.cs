
namespace QuanLyPhanMem
{
    partial class frmSanPham
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.cbxDonVi = new System.Windows.Forms.ComboBox();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.btnNew = new Guna.UI.WinForms.GunaButton();
            this.btnThemAnh = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 49);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(419, 466);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(486, 437);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhà Cung Cấp";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn Vị Tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.cbxDonVi);
            this.dataLayoutControl1.Controls.Add(this.cbxNCC);
            this.dataLayoutControl1.Controls.Add(this.cbxLoai);
            this.dataLayoutControl1.Controls.Add(this.txtGia);
            this.dataLayoutControl1.Controls.Add(this.txtMaSP);
            this.dataLayoutControl1.Controls.Add(this.txtTenSP);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(693, 95);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.Location = new System.Drawing.Point(429, 60);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(252, 21);
            this.cbxDonVi.TabIndex = 15;
            // 
            // cbxNCC
            // 
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(93, 36);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(251, 21);
            this.cbxNCC.TabIndex = 14;
            // 
            // cbxLoai
            // 
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Location = new System.Drawing.Point(93, 61);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(251, 21);
            this.cbxLoai.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(429, 36);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(252, 20);
            this.txtGia.StyleController = this.dataLayoutControl1;
            this.txtGia.TabIndex = 12;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(429, 12);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(252, 20);
            this.txtMaSP.StyleController = this.dataLayoutControl1;
            this.txtMaSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(93, 12);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(251, 20);
            this.txtTenSP.StyleController = this.dataLayoutControl1;
            this.txtTenSP.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(693, 95);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenSP;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(336, 24);
            this.layoutControlItem1.Text = "Tên Sản Phẩm";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtMaSP;
            this.layoutControlItem7.Location = new System.Drawing.Point(336, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(337, 24);
            this.layoutControlItem7.Text = "Mã Sản Phẩm";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbxLoai;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem3.Text = "Loại";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtGia;
            this.layoutControlItem2.Location = new System.Drawing.Point(336, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(337, 24);
            this.layoutControlItem2.Text = "Giá";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbxDonVi;
            this.layoutControlItem5.Location = new System.Drawing.Point(336, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(337, 27);
            this.layoutControlItem5.Text = "Đơn Vị Tính";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbxNCC;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(336, 25);
            this.layoutControlItem4.Text = "Nhà Cung Cấp";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(69, 13);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = null;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.Location = new System.Drawing.Point(551, 87);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 16;
            this.btnTimKiem.Size = new System.Drawing.Size(97, 42);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnNew
            // 
            this.btnNew.AnimationHoverSpeed = 0.07F;
            this.btnNew.AnimationSpeed = 0.03F;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNew.BorderColor = System.Drawing.Color.Black;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNew.FocusedColor = System.Drawing.Color.Empty;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = null;
            this.btnNew.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNew.Location = new System.Drawing.Point(428, 87);
            this.btnNew.Name = "btnNew";
            this.btnNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNew.OnHoverImage = null;
            this.btnNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnNew.Radius = 16;
            this.btnNew.Size = new System.Drawing.Size(100, 42);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Làm Mới";
            this.btnNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.AnimationHoverSpeed = 0.07F;
            this.btnThemAnh.AnimationSpeed = 0.03F;
            this.btnThemAnh.BackColor = System.Drawing.Color.Transparent;
            this.btnThemAnh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemAnh.BorderColor = System.Drawing.Color.Black;
            this.btnThemAnh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemAnh.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemAnh.ForeColor = System.Drawing.Color.White;
            this.btnThemAnh.Image = null;
            this.btnThemAnh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemAnh.Location = new System.Drawing.Point(603, 306);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemAnh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemAnh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemAnh.OnHoverImage = null;
            this.btnThemAnh.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemAnh.Radius = 16;
            this.btnThemAnh.Size = new System.Drawing.Size(67, 33);
            this.btnThemAnh.TabIndex = 9;
            this.btnThemAnh.Text = "Thêm Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(518, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 576);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.ComboBox cbxDonVi;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.ComboBox cbxLoai;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaButton btnNew;
        private Guna.UI.WinForms.GunaButton btnThemAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}