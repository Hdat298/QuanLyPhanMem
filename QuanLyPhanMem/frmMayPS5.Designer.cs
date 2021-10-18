
namespace QuanLyPhanMem
{
    partial class frmMayPS5
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 332);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunaButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(36, 203);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 8;
            this.gunaButton1.Size = new System.Drawing.Size(125, 29);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "19.000.000";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Máy PS5";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 118);
            this.gunaPanel1.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(322, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Máy PS5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyPhanMem.Properties.Resources.may_ps5_ban_dia_825gb;
            this.pictureBox1.Location = new System.Drawing.Point(37, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMayPS5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "frmMayPS5";
            this.Text = "frmMayPS5";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}