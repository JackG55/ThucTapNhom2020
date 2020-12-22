namespace QUAN_LY_THU_VIEN
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bt_doi_mat_khau = new DevExpress.XtraBars.BarButtonItem();
            this.bt_dang_xuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bt_sach = new DevExpress.XtraBars.BarButtonItem();
            this.bt_nguoi_doc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panel_main = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bt_doi_mat_khau,
            this.bt_dang_xuat,
            this.barButtonItem1,
            this.bt_sach,
            this.bt_nguoi_doc,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1471, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bt_doi_mat_khau
            // 
            this.bt_doi_mat_khau.Caption = "Đổi mật khẩu";
            this.bt_doi_mat_khau.Hint = "Dùng để đổi mật khẩu";
            this.bt_doi_mat_khau.Id = 1;
            this.bt_doi_mat_khau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_doi_mat_khau.ImageOptions.Image")));
            this.bt_doi_mat_khau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bt_doi_mat_khau.ImageOptions.LargeImage")));
            this.bt_doi_mat_khau.Name = "bt_doi_mat_khau";
            this.bt_doi_mat_khau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_doi_mat_khau_ItemClick);
            // 
            // bt_dang_xuat
            // 
            this.bt_dang_xuat.ActAsDropDown = true;
            this.bt_dang_xuat.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bt_dang_xuat.Caption = "Đăng xuất";
            this.bt_dang_xuat.Hint = "Dùng để đăng xuất tài khoản";
            this.bt_dang_xuat.Id = 2;
            this.bt_dang_xuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_dang_xuat.ImageOptions.Image")));
            this.bt_dang_xuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bt_dang_xuat.ImageOptions.LargeImage")));
            this.bt_dang_xuat.Name = "bt_dang_xuat";
            this.bt_dang_xuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_dang_xuat_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bt_sach
            // 
            this.bt_sach.Caption = "Sách";
            this.bt_sach.Id = 4;
            this.bt_sach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_sach.ImageOptions.Image")));
            this.bt_sach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bt_sach.ImageOptions.LargeImage")));
            this.bt_sach.Name = "bt_sach";
            this.bt_sach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_sach_ItemClick);
            // 
            // bt_nguoi_doc
            // 
            this.bt_nguoi_doc.Caption = "Người đọc";
            this.bt_nguoi_doc.Id = 5;
            this.bt_nguoi_doc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_nguoi_doc.ImageOptions.Image")));
            this.bt_nguoi_doc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bt_nguoi_doc.ImageOptions.LargeImage")));
            this.bt_nguoi_doc.Name = "bt_nguoi_doc";
            this.bt_nguoi_doc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_nguoi_doc_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lý mượn trả";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_doi_mat_khau);
            this.ribbonPageGroup1.ItemLinks.Add(this.bt_dang_xuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài Khoản";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý nghiệp vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.bt_sach);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý sách";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bt_nguoi_doc);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý người đọc";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup4.ImageOptions.Image")));
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý mượn trả";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tài liệu hướng dẫn";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 701);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1471, 37);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 178);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1471, 523);
            this.panel_main.TabIndex = 2;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 738);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "TrangChu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "TrangChu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bt_doi_mat_khau;
        private DevExpress.XtraBars.BarButtonItem bt_dang_xuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Panel panel_main;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem bt_sach;
        private DevExpress.XtraBars.BarButtonItem bt_nguoi_doc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}