
namespace QuanLyPhanMem
{
    partial class frmMain1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain1));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dockPanel1.Appearance.Options.UseBackColor = true;
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("f4392b7d-505e-464f-bb4c-eb3630541944");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 371);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 342);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.Background.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navBarControl1.Appearance.Background.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl1.Appearance.GroupBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.navBarControl1.Appearance.GroupBackground.Options.UseBackColor = true;
            this.navBarControl1.Appearance.GroupHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navBarControl1.Appearance.GroupHeader.Options.UseBackColor = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup4,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem4,
            this.navBarItem8,
            this.navBarItem3,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 342);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Bán Hàng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "SẢN PHẨM";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Help";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Doanh Số";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Lợi Nhuận";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Báo Cáo Ngày";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Khách Hàng";
            this.navBarItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem8.ImageOptions.LargeImage")));
            this.navBarItem8.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem8.ImageOptions.SmallImage")));
            this.navBarItem8.Name = "navBarItem8";
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(200, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(576, 371);
            this.groupControl1.TabIndex = 1;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "HÓA ĐƠN";
            this.navBarItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem3.ImageOptions.SvgImage")));
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "SẢN PHẨM";
            this.navBarItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem5.ImageOptions.SvgImage")));
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSP_LinkClicked);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "HƯỚNG DẪN";
            this.navBarItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem6.ImageOptions.SvgImage")));
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem6_LinkClicked);
            // 
            // frmMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 371);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmMain1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Chính Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
    }
}