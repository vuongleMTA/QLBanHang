namespace QLBanHang.GUI
{
    partial class FrmMatHangKinhDoanh
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
            this.dgvMatHangMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.cbxNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamTrang = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatHangMain
            // 
            this.dgvMatHangMain.Location = new System.Drawing.Point(15, 34);
            this.dgvMatHangMain.MainView = this.dgvMatHang;
            this.dgvMatHangMain.Name = "dgvMatHangMain";
            this.dgvMatHangMain.Size = new System.Drawing.Size(573, 488);
            this.dgvMatHangMain.TabIndex = 16;
            this.dgvMatHangMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMatHang});
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dgvMatHang.ColumnPanelRowHeight = 30;
            this.dgvMatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaMH,
            this.TenMH,
            this.DonViTinh,
            this.NhaSanXuat,
            this.ThanhPhan});
            this.dgvMatHang.FixedLineWidth = 1;
            this.dgvMatHang.GridControl = this.dgvMatHangMain;
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.OptionsBehavior.Editable = false;
            this.dgvMatHang.OptionsBehavior.ReadOnly = true;
            this.dgvMatHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMatHang.PaintStyleName = "UltraFlat";
            this.dgvMatHang.RowHeight = 40;
            // 
            // MaMH
            // 
            this.MaMH.Caption = "Mã MH";
            this.MaMH.FieldName = "MaMH";
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 43;
            // 
            // TenMH
            // 
            this.TenMH.Caption = "Tên mặt hàng";
            this.TenMH.FieldName = "TenMH";
            this.TenMH.Name = "TenMH";
            this.TenMH.Visible = true;
            this.TenMH.VisibleIndex = 0;
            this.TenMH.Width = 128;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 1;
            this.DonViTinh.Width = 76;
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.Caption = "Nhà sản xuất";
            this.NhaSanXuat.FieldName = "NSX";
            this.NhaSanXuat.Name = "NhaSanXuat";
            this.NhaSanXuat.Visible = true;
            this.NhaSanXuat.VisibleIndex = 2;
            this.NhaSanXuat.Width = 129;
            // 
            // ThanhPhan
            // 
            this.ThanhPhan.Caption = "Thành phần";
            this.ThanhPhan.FieldName = "ThanhPhan";
            this.ThanhPhan.Name = "ThanhPhan";
            this.ThanhPhan.Visible = true;
            this.ThanhPhan.VisibleIndex = 3;
            this.ThanhPhan.Width = 182;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.txtThanhPhan);
            this.groupBox1.Controls.Add(this.cbxNhaSanXuat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(605, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 305);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(116, 95);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(171, 20);
            this.txtDonViTinh.TabIndex = 22;
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Location = new System.Drawing.Point(116, 220);
            this.txtThanhPhan.Multiline = true;
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(270, 61);
            this.txtThanhPhan.TabIndex = 21;
            // 
            // cbxNhaSanXuat
            // 
            this.cbxNhaSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhaSanXuat.FormattingEnabled = true;
            this.cbxNhaSanXuat.Location = new System.Drawing.Point(116, 155);
            this.cbxNhaSanXuat.Name = "cbxNhaSanXuat";
            this.cbxNhaSanXuat.Size = new System.Drawing.Size(190, 21);
            this.cbxNhaSanXuat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thành phần :";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(116, 32);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(244, 20);
            this.txtTenMH.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(28, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nhà sản xuất : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(28, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn vị tính : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên mặt hàng : ";
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Location = new System.Drawing.Point(605, 477);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(404, 45);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Location = new System.Drawing.Point(810, 426);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 45);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Location = new System.Drawing.Point(605, 375);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 45);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Location = new System.Drawing.Point(605, 426);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(199, 45);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            // 
            // btnLamTrang
            // 
            this.btnLamTrang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLamTrang.Location = new System.Drawing.Point(810, 375);
            this.btnLamTrang.Name = "btnLamTrang";
            this.btnLamTrang.Size = new System.Drawing.Size(199, 45);
            this.btnLamTrang.TabIndex = 22;
            this.btnLamTrang.Text = "Xóa trắng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(82, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "DANH SÁCH MẶT HÀNG";
            // 
            // FrmMatHangKinhDoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLamTrang);
            this.Controls.Add(this.dgvMatHangMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatHangKinhDoanh";
            this.Text = "FrmMatHangKinhDoanh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvMatHangMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.ComboBox cbxNhaSanXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn TenMH;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NhaSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhPhan;
        private DevExpress.XtraEditors.SimpleButton btnLamTrang;
        private System.Windows.Forms.Label label2;

    }
}