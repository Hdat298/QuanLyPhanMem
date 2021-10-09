
namespace QuanLyPhanMem
{
    partial class frmThongKeDoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(240, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU CÔNG TY QT";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(697, 458);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 41);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In thống kê";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tổng tiền hóa đơn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giảm giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tổng tiền";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Columm3
            // 
            this.Columm3.HeaderText = "Ngày lập";
            this.Columm3.MinimumWidth = 6;
            this.Columm3.Name = "Columm3";
            this.Columm3.Width = 125;
            // 
            // Columm2
            // 
            this.Columm2.HeaderText = "Mã đơn";
            this.Columm2.MinimumWidth = 6;
            this.Columm2.Name = "Columm2";
            this.Columm2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Columm2,
            this.Columm3,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(60, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 325);
            this.dataGridView1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tuần",
            "Theo tháng",
            "Theo năm"});
            this.comboBox1.Location = new System.Drawing.Point(60, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimeOffsetEdit1
            // 
            this.dateTimeOffsetEdit1.EditValue = new System.DateTime(2021, 10, 9, 21, 23, 20, 248);
            this.dateTimeOffsetEdit1.Location = new System.Drawing.Point(60, 98);
            this.dateTimeOffsetEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeOffsetEdit1.Name = "dateTimeOffsetEdit1";
            this.dateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit1.Size = new System.Drawing.Size(164, 22);
            this.dateTimeOffsetEdit1.TabIndex = 6;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(910, 511);
            this.Controls.Add(this.dateTimeOffsetEdit1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit1;
    }
}