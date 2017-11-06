namespace QLBanHang.GUI
{
    partial class FrmBanHang
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
            this.txtTongTien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.txtIndex = new System.Windows.Forms.Label();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonViTinh = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.btnSuaPhieuXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamTrangPhieuXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamTrang = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMatHang = new System.Windows.Forms.ComboBox();
            this.btnLeft = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayXuat = new DevExpress.XtraEditors.DateEdit();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChiTietXuatMain = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCTX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThemPhieuXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxKhachHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXuat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXuatMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Location = new System.Drawing.Point(122, 110);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(43, 13);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.Text = "120000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tổng tiền : ";
            // 
            // btnEnd
            // 
            this.btnEnd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnEnd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEnd.Location = new System.Drawing.Point(409, 143);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(58, 29);
            this.btnEnd.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnStart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStart.Location = new System.Drawing.Point(141, 143);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(58, 29);
            this.btnStart.TabIndex = 9;
            // 
            // txtIndex
            // 
            this.txtIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndex.Location = new System.Drawing.Point(269, 143);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(70, 29);
            this.txtIndex.TabIndex = 8;
            this.txtIndex.Text = "1/30";
            this.txtIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnRight.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRight.Location = new System.Drawing.Point(345, 143);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 29);
            this.btnRight.TabIndex = 7;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.AutoSize = true;
            this.txtDonViTinh.Location = new System.Drawing.Point(142, 94);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(34, 13);
            this.txtDonViTinh.TabIndex = 17;
            this.txtDonViTinh.Text = "Chiếc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "VNĐ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoSize = true;
            this.txtThanhTien.Location = new System.Drawing.Point(142, 271);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(13, 13);
            this.txtThanhTien.TabIndex = 14;
            this.txtThanhTien.Text = "0";
            // 
            // btnSuaPhieuXuat
            // 
            this.btnSuaPhieuXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSuaPhieuXuat.Location = new System.Drawing.Point(342, 203);
            this.btnSuaPhieuXuat.Name = "btnSuaPhieuXuat";
            this.btnSuaPhieuXuat.Size = new System.Drawing.Size(124, 31);
            this.btnSuaPhieuXuat.TabIndex = 23;
            this.btnSuaPhieuXuat.Text = "Sửa phiếu xuất";
            // 
            // btnLamTrangPhieuXuat
            // 
            this.btnLamTrangPhieuXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLamTrangPhieuXuat.Location = new System.Drawing.Point(472, 203);
            this.btnLamTrangPhieuXuat.Name = "btnLamTrangPhieuXuat";
            this.btnLamTrangPhieuXuat.Size = new System.Drawing.Size(124, 31);
            this.btnLamTrangPhieuXuat.TabIndex = 22;
            this.btnLamTrangPhieuXuat.Text = "Xóa phiếu";
            // 
            // btnLamTrang
            // 
            this.btnLamTrang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLamTrang.Location = new System.Drawing.Point(815, 399);
            this.btnLamTrang.Name = "btnLamTrang";
            this.btnLamTrang.Size = new System.Drawing.Size(199, 45);
            this.btnLamTrang.TabIndex = 20;
            this.btnLamTrang.Text = "Làm trắng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên nhập : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thành tiền : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(41, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 1);
            this.panel1.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(145, 203);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(66, 20);
            this.txtSoLuong.TabIndex = 11;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số lượng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán : ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(145, 142);
            this.txtDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn vị tính : ";
            // 
            // cbxMatHang
            // 
            this.cbxMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatHang.FormattingEnabled = true;
            this.cbxMatHang.Location = new System.Drawing.Point(145, 40);
            this.cbxMatHang.Name = "cbxMatHang";
            this.cbxMatHang.Size = new System.Drawing.Size(212, 21);
            this.cbxMatHang.TabIndex = 5;
            // 
            // btnLeft
            // 
            this.btnLeft.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLeft.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLeft.Location = new System.Drawing.Point(205, 143);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 29);
            this.btnLeft.TabIndex = 6;
            // 
            // dateNgayXuat
            // 
            this.dateNgayXuat.EditValue = null;
            this.dateNgayXuat.Location = new System.Drawing.Point(429, 34);
            this.dateNgayXuat.Name = "dateNgayXuat";
            this.dateNgayXuat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgayXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayXuat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayXuat.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayXuat.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNgayXuat.Size = new System.Drawing.Size(125, 22);
            this.dateNgayXuat.TabIndex = 4;
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(125, 35);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(171, 21);
            this.cbxNhanVien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khách hàng : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn giá : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mặt hàng : ";
            // 
            // dgvChiTietXuatMain
            // 
            this.dgvChiTietXuatMain.Location = new System.Drawing.Point(20, 240);
            this.dgvChiTietXuatMain.MainView = this.dgvChiTietXuat;
            this.dgvChiTietXuatMain.Name = "dgvChiTietXuatMain";
            this.dgvChiTietXuatMain.Size = new System.Drawing.Size(576, 306);
            this.dgvChiTietXuatMain.TabIndex = 13;
            this.dgvChiTietXuatMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietXuat});
            // 
            // dgvChiTietXuat
            // 
            this.dgvChiTietXuat.Appearance.ColumnFilterButton.Options.UseImage = true;
            this.dgvChiTietXuat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dgvChiTietXuat.ColumnPanelRowHeight = 30;
            this.dgvChiTietXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCTX,
            this.MatHang,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTietXuat.FixedLineWidth = 1;
            this.dgvChiTietXuat.GridControl = this.dgvChiTietXuatMain;
            this.dgvChiTietXuat.Name = "dgvChiTietXuat";
            this.dgvChiTietXuat.OptionsBehavior.Editable = false;
            this.dgvChiTietXuat.OptionsBehavior.ReadOnly = true;
            this.dgvChiTietXuat.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChiTietXuat.PaintStyleName = "UltraFlat";
            this.dgvChiTietXuat.RowHeight = 40;
            // 
            // MaCTX
            // 
            this.MaCTX.Caption = "Mã chi tiết xuất";
            this.MaCTX.FieldName = "MaCTX";
            this.MaCTX.Name = "MaCTX";
            // 
            // MatHang
            // 
            this.MatHang.Caption = "Mặt hàng";
            this.MatHang.FieldName = "MatHang";
            this.MatHang.Name = "MatHang";
            this.MatHang.Visible = true;
            this.MatHang.VisibleIndex = 0;
            this.MatHang.Width = 173;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 1;
            this.DonViTinh.Width = 121;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 124;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            this.DonGia.Width = 135;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách chi tiết xuất";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "VNĐ";
            // 
            // btnThemPhieuXuat
            // 
            this.btnThemPhieuXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemPhieuXuat.Location = new System.Drawing.Point(212, 203);
            this.btnThemPhieuXuat.Name = "btnThemPhieuXuat";
            this.btnThemPhieuXuat.Size = new System.Drawing.Size(124, 31);
            this.btnThemPhieuXuat.TabIndex = 21;
            this.btnThemPhieuXuat.Text = "Thêm phiếu xuất";
            // 
            // btnXuat
            // 
            this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuat.Location = new System.Drawing.Point(815, 450);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(199, 45);
            this.btnXuat.TabIndex = 18;
            this.btnXuat.Text = "Xuất phiếu xuất";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Location = new System.Drawing.Point(610, 450);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 45);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa chi tiết xuất";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Location = new System.Drawing.Point(610, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 45);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm chi tiết xuất";
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Location = new System.Drawing.Point(610, 501);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(404, 45);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxMatHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(610, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 311);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cbxKhachHang);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.txtIndex);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Controls.Add(this.dateNgayXuat);
            this.groupBox2.Controls.Add(this.cbxNhanVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(20, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 185);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu xuất";
            // 
            // cbxKhachHang
            // 
            this.cbxKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKhachHang.FormattingEnabled = true;
            this.cbxKhachHang.Location = new System.Drawing.Point(125, 68);
            this.cbxKhachHang.Name = "cbxKhachHang";
            this.cbxKhachHang.Size = new System.Drawing.Size(191, 21);
            this.cbxKhachHang.TabIndex = 18;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.btnSuaPhieuXuat);
            this.Controls.Add(this.btnLamTrangPhieuXuat);
            this.Controls.Add(this.btnLamTrang);
            this.Controls.Add(this.dgvChiTietXuatMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemPhieuXuat);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXuat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXuatMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.Label txtIndex;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private System.Windows.Forms.Label txtDonViTinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnSuaPhieuXuat;
        private DevExpress.XtraEditors.SimpleButton btnLamTrangPhieuXuat;
        private DevExpress.XtraEditors.SimpleButton btnLamTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMatHang;
        private DevExpress.XtraEditors.SimpleButton btnLeft;
        private DevExpress.XtraEditors.DateEdit dateNgayXuat;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl dgvChiTietXuatMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietXuat;
        private DevExpress.XtraGrid.Columns.GridColumn MaCTX;
        private DevExpress.XtraGrid.Columns.GridColumn MatHang;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuXuat;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxKhachHang;


    }
}