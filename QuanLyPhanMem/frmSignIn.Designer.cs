namespace QuanLyPhanMem
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.btnSignIn = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BaseColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(336, 181);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.Radius = 16;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(250, 34);
            this.txtUserName.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(330, 103);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(231, 28);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Phần Mềm Quản Lý";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(332, 155);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 19);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Tên truy cập";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(332, 225);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(79, 19);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Mật Khẩu";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.Silver;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(336, 247);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.Radius = 16;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(250, 34);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BaseColor = System.Drawing.Color.MediumVioletRed;
            this.btnSignIn.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIn.Location = new System.Drawing.Point(336, 328);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Radius = 18;
            this.btnSignIn.Size = new System.Drawing.Size(250, 42);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyPhanMem.Properties.Resources._6bc7d0953fc1428e95d56a8a8e47f5f9;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 457);
            this.panel1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(653, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(37, 31);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmSignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::QuanLyPhanMem.Properties.Resources._2ebbe5b169bfb9b99e54cb0b1aae6e83;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.simpleButton1;
            this.ClientSize = new System.Drawing.Size(702, 455);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtPass;
        private Guna.UI.WinForms.GunaButton btnSignIn;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}