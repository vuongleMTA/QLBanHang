namespace QLBanHang.GUI
{
    partial class FrmBaoCaoDoanhThu
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
            this.dgvDoanhThuMain = new DevExpress.XtraGrid.GridControl();
            this.dgvDoanhThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDongChucNang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongThu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThuMain
            // 
            this.dgvDoanhThuMain.Location = new System.Drawing.Point(12, 177);
            this.dgvDoanhThuMain.MainView = this.dgvDoanhThu;
            this.dgvDoanhThuMain.Name = "dgvDoanhThuMain";
            this.dgvDoanhThuMain.Size = new System.Drawing.Size(1007, 344);
            this.dgvDoanhThuMain.TabIndex = 18;
            this.dgvDoanhThuMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDoanhThu});
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnPanelRowHeight = 30;
            this.dgvDoanhThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ngay,
            this.STT,
            this.TenMH,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvDoanhThu.GridControl = this.dgvDoanhThuMain;
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.OptionsBehavior.Editable = false;
            this.dgvDoanhThu.OptionsBehavior.ReadOnly = true;
            this.dgvDoanhThu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvDoanhThu.PaintStyleName = "UltraFlat";
            this.dgvDoanhThu.RowHeight = 40;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày bán";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 109;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 36;
            // 
            // TenMH
            // 
            this.TenMH.Caption = "Tên mặt hàng";
            this.TenMH.FieldName = "TenMH";
            this.TenMH.Name = "TenMH";
            this.TenMH.Visible = true;
            this.TenMH.VisibleIndex = 2;
            this.TenMH.Width = 179;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 114;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            this.DonGia.Width = 114;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 5;
            this.ThanhTien.Width = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Doanh Thu";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateKetThuc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateBatDau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 114);
            this.panel1.TabIndex = 19;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = new System.DateTime(2017, 12, 31, 17, 43, 56, 0);
            this.dateKetThuc.Location = new System.Drawing.Point(554, 57);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateKetThuc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateKetThuc.Size = new System.Drawing.Size(172, 22);
            this.dateKetThuc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến ngày ";
            // 
            // dateBatDau
            // 
            this.dateBatDau.EditValue = new System.DateTime(2017, 1, 1, 17, 43, 49, 0);
            this.dateBatDau.Location = new System.Drawing.Point(299, 57);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateBatDau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateBatDau.Size = new System.Drawing.Size(172, 22);
            this.dateBatDau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ ngày ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(22, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 1);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian";
            // 
            // btnDongChucNang
            // 
            this.btnDongChucNang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDongChucNang.Location = new System.Drawing.Point(849, 133);
            this.btnDongChucNang.Name = "btnDongChucNang";
            this.btnDongChucNang.Size = new System.Drawing.Size(170, 41);
            this.btnDongChucNang.TabIndex = 20;
            this.btnDongChucNang.Text = "Đóng chức năng";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuatExcel.Location = new System.Drawing.Point(673, 133);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(170, 41);
            this.btnXuatExcel.TabIndex = 21;
            this.btnXuatExcel.Text = "Xuất Excel";
            // 
            // btnThongKe
            // 
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(497, 133);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(170, 41);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Thống kê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng thu : ";
            // 
            // txtTongThu
            // 
            this.txtTongThu.AutoSize = true;
            this.txtTongThu.Location = new System.Drawing.Point(77, 536);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(55, 13);
            this.txtTongThu.TabIndex = 24;
            this.txtTongThu.Text = "10000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "VNĐ";
            // 
            // FrmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnDongChucNang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDoanhThuMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoDoanhThu";
            this.Text = "FrmBaoCaoHangTieuThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvDoanhThuMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateKetThuc;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dateBatDau;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnDongChucNang;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TenMH;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtTongThu;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;

    }
}