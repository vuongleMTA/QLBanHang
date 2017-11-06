namespace QLBanHang.GUI
{
    partial class FrmMain
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barNhanVienNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.barNhanVienBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barDanhSachKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barDMChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.barnQuanTriPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.barQuanTriNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barMatHangKinhDoanh = new DevExpress.XtraBars.BarButtonItem();
            this.barBaoCaoKhoHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBaoCaoLuongHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBaoCaoDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.barQuanTriNhaSanXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQuanTri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtChucVu = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barNhanVienNhapHang,
            this.barNhanVienBanHang,
            this.barDanhSachKhachHang,
            this.barDMChucVu,
            this.barnQuanTriPhongBan,
            this.barQuanTriNhanVien,
            this.barMatHangKinhDoanh,
            this.barBaoCaoKhoHang,
            this.barBaoCaoLuongHang,
            this.barBaoCaoDoanhThu,
            this.barQuanTriNhaSanXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbNhanVien,
            this.rbQuanTri});
            this.ribbonControl1.Size = new System.Drawing.Size(1246, 140);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng xuất";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barNhanVienNhapHang
            // 
            this.barNhanVienNhapHang.Caption = "Nhập hàng";
            this.barNhanVienNhapHang.Glyph = global::QLBanHang.Properties.Resources.slide5_downloadexport_icon;
            this.barNhanVienNhapHang.Id = 2;
            this.barNhanVienNhapHang.Name = "barNhanVienNhapHang";
            this.barNhanVienNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barNhanVienBanHang
            // 
            this.barNhanVienBanHang.Caption = "Bán hàng";
            this.barNhanVienBanHang.Glyph = global::QLBanHang.Properties.Resources.cart_upload_01_5121;
            this.barNhanVienBanHang.Id = 3;
            this.barNhanVienBanHang.Name = "barNhanVienBanHang";
            this.barNhanVienBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barDanhSachKhachHang
            // 
            this.barDanhSachKhachHang.Caption = "Danh sách khách hàng";
            this.barDanhSachKhachHang.Glyph = global::QLBanHang.Properties.Resources.Staff_icon;
            this.barDanhSachKhachHang.Id = 4;
            this.barDanhSachKhachHang.Name = "barDanhSachKhachHang";
            this.barDanhSachKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barDMChucVu
            // 
            this.barDMChucVu.Caption = "Chức vụ";
            this.barDMChucVu.Glyph = global::QLBanHang.Properties.Resources.JVS_job_fair_icon;
            this.barDMChucVu.Id = 5;
            this.barDMChucVu.Name = "barDMChucVu";
            this.barDMChucVu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barnQuanTriPhongBan
            // 
            this.barnQuanTriPhongBan.Caption = "Phòng ban";
            this.barnQuanTriPhongBan.Glyph = global::QLBanHang.Properties.Resources.department1600;
            this.barnQuanTriPhongBan.Id = 6;
            this.barnQuanTriPhongBan.Name = "barnQuanTriPhongBan";
            this.barnQuanTriPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barQuanTriNhanVien
            // 
            this.barQuanTriNhanVien.Caption = "Nhân viên";
            this.barQuanTriNhanVien.Glyph = global::QLBanHang.Properties.Resources.Customers_customer_user_male_man_people_light;
            this.barQuanTriNhanVien.Id = 7;
            this.barQuanTriNhanVien.Name = "barQuanTriNhanVien";
            this.barQuanTriNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barMatHangKinhDoanh
            // 
            this.barMatHangKinhDoanh.Caption = "Mặt hàng kinh doanh";
            this.barMatHangKinhDoanh.Glyph = global::QLBanHang.Properties.Resources.packing;
            this.barMatHangKinhDoanh.Id = 8;
            this.barMatHangKinhDoanh.Name = "barMatHangKinhDoanh";
            this.barMatHangKinhDoanh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBaoCaoKhoHang
            // 
            this.barBaoCaoKhoHang.Caption = "Báo cáo kho hàng";
            this.barBaoCaoKhoHang.Glyph = global::QLBanHang.Properties.Resources.house_icon;
            this.barBaoCaoKhoHang.Id = 9;
            this.barBaoCaoKhoHang.Name = "barBaoCaoKhoHang";
            this.barBaoCaoKhoHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBaoCaoLuongHang
            // 
            this.barBaoCaoLuongHang.Caption = "Báo cáo lượng hàng tiêu thu";
            this.barBaoCaoLuongHang.Glyph = global::QLBanHang.Properties.Resources.Data_Combo_Chart_icon;
            this.barBaoCaoLuongHang.Id = 10;
            this.barBaoCaoLuongHang.Name = "barBaoCaoLuongHang";
            this.barBaoCaoLuongHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBaoCaoDoanhThu
            // 
            this.barBaoCaoDoanhThu.Caption = "Báo cáo doanh thu";
            this.barBaoCaoDoanhThu.Glyph = global::QLBanHang.Properties.Resources._082260_green_jelly_icon_business_dollar_solid;
            this.barBaoCaoDoanhThu.Id = 11;
            this.barBaoCaoDoanhThu.Name = "barBaoCaoDoanhThu";
            this.barBaoCaoDoanhThu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barQuanTriNhaSanXuat
            // 
            this.barQuanTriNhaSanXuat.Caption = "Nhà sản xuất";
            this.barQuanTriNhaSanXuat.Glyph = global::QLBanHang.Properties.Resources.erp_manufacturing_phan_mem_quan_ly_san_xuat;
            this.barQuanTriNhaSanXuat.Id = 12;
            this.barQuanTriNhaSanXuat.Name = "barQuanTriNhaSanXuat";
            this.barQuanTriNhaSanXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Text = "Bán hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barNhanVienNhapHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barNhanVienBanHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barDanhSachKhachHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barMatHangKinhDoanh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbQuanTri
            // 
            this.rbQuanTri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rbQuanTri.Name = "rbQuanTri";
            this.rbQuanTri.Text = "Quản trị";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barDMChucVu);
            this.ribbonPageGroup2.ItemLinks.Add(this.barnQuanTriPhongBan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barQuanTriNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barQuanTriNhaSanXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBaoCaoKhoHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBaoCaoLuongHang);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBaoCaoDoanhThu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.panelControl1.Controls.Add(this.btnDangXuat);
            this.panelControl1.Controls.Add(this.btnDoiMatKhau);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 140);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(217, 593);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDangXuat.Location = new System.Drawing.Point(5, 187);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(206, 33);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(5, 148);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(206, 33);
            this.btnDoiMatKhau.TabIndex = 1;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.txtChucVu);
            this.groupControl1.Controls.Add(this.txtTaiKhoan);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(5, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(207, 118);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin tài khoản";
            // 
            // txtChucVu
            // 
            this.txtChucVu.AutoSize = true;
            this.txtChucVu.Location = new System.Drawing.Point(93, 79);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(50, 13);
            this.txtChucVu.TabIndex = 3;
            this.txtChucVu.Text = "Giám đốc";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.Location = new System.Drawing.Point(93, 41);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(35, 13);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản : ";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(217, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1029, 593);
            this.panelMain.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 733);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanTri;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private System.Windows.Forms.Label txtChucVu;
        private System.Windows.Forms.Label txtTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraBars.BarButtonItem barNhanVienNhapHang;
        private DevExpress.XtraBars.BarButtonItem barNhanVienBanHang;
        private DevExpress.XtraBars.BarButtonItem barDanhSachKhachHang;
        private DevExpress.XtraBars.BarButtonItem barDMChucVu;
        private DevExpress.XtraBars.BarButtonItem barnQuanTriPhongBan;
        private DevExpress.XtraBars.BarButtonItem barQuanTriNhanVien;
        private DevExpress.XtraBars.BarButtonItem barMatHangKinhDoanh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBaoCaoKhoHang;
        private DevExpress.XtraBars.BarButtonItem barBaoCaoLuongHang;
        private DevExpress.XtraBars.BarButtonItem barBaoCaoDoanhThu;
        private DevExpress.XtraBars.BarButtonItem barQuanTriNhaSanXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

