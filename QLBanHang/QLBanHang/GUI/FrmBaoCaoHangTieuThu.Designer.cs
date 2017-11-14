namespace QuanLyHangHoa.GUI
{
    partial class FrmBaoCaoHangTieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoHangTieuThu));
            this.dgvHangTieuThuMain = new DevExpress.XtraGrid.GridControl();
            this.dgvHangTieuThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxThongKe = new System.Windows.Forms.ComboBox();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDongChucNang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTieuThuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTieuThu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangTieuThuMain
            // 
            this.dgvHangTieuThuMain.Location = new System.Drawing.Point(12, 177);
            this.dgvHangTieuThuMain.MainView = this.dgvHangTieuThu;
            this.dgvHangTieuThuMain.Name = "dgvHangTieuThuMain";
            this.dgvHangTieuThuMain.Size = new System.Drawing.Size(1007, 369);
            this.dgvHangTieuThuMain.TabIndex = 18;
            this.dgvHangTieuThuMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHangTieuThu});
            // 
            // dgvHangTieuThu
            // 
            this.dgvHangTieuThu.ColumnPanelRowHeight = 30;
            this.dgvHangTieuThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoLuong});
            this.dgvHangTieuThu.GridControl = this.dgvHangTieuThuMain;
            this.dgvHangTieuThu.Name = "dgvHangTieuThu";
            this.dgvHangTieuThu.OptionsBehavior.Editable = false;
            this.dgvHangTieuThu.OptionsBehavior.ReadOnly = true;
            this.dgvHangTieuThu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvHangTieuThu.PaintStyleName = "UltraFlat";
            this.dgvHangTieuThu.RowHeight = 40;
            // 
            // MaMH
            // 
            this.MaMH.Caption = "Mã mặt hàng";
            this.MaMH.FieldName = "MaMH";
            this.MaMH.Name = "MaMH";
            this.MaMH.Visible = true;
            this.MaMH.VisibleIndex = 0;
            this.MaMH.Width = 174;
            // 
            // TenMH
            // 
            this.TenMH.Caption = "Tên mặt hàng";
            this.TenMH.FieldName = "TenMH";
            this.TenMH.Name = "TenMH";
            this.TenMH.Visible = true;
            this.TenMH.VisibleIndex = 1;
            this.TenMH.Width = 407;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 411;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách mặt hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxThongKe);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại thống kê";
            // 
            // cbxThongKe
            // 
            this.cbxThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThongKe.FormattingEnabled = true;
            this.cbxThongKe.Items.AddRange(new object[] {
            "Thống kê hàng đã nhập",
            "Thống kê hàng đã xuất"});
            this.cbxThongKe.Location = new System.Drawing.Point(129, 60);
            this.cbxThongKe.Name = "cbxThongKe";
            this.cbxThongKe.Size = new System.Drawing.Size(241, 21);
            this.cbxThongKe.TabIndex = 6;
            this.cbxThongKe.SelectedIndexChanged += new System.EventHandler(this.cbxThongKe_SelectedIndexChanged);
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = new System.DateTime(2017, 12, 31, 17, 43, 56, 0);
            this.dateKetThuc.Location = new System.Drawing.Point(710, 60);
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
            this.label4.Location = new System.Drawing.Point(648, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến ngày ";
            // 
            // dateBatDau
            // 
            this.dateBatDau.EditValue = new System.DateTime(2017, 1, 1, 17, 43, 49, 0);
            this.dateBatDau.Location = new System.Drawing.Point(455, 60);
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
            this.label3.Location = new System.Drawing.Point(400, 63);
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
            this.btnDongChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnDongChucNang.Image")));
            this.btnDongChucNang.Location = new System.Drawing.Point(849, 133);
            this.btnDongChucNang.Name = "btnDongChucNang";
            this.btnDongChucNang.Size = new System.Drawing.Size(170, 41);
            this.btnDongChucNang.TabIndex = 20;
            this.btnDongChucNang.Text = "Đóng chức năng";
            this.btnDongChucNang.Click += new System.EventHandler(this.btnDongChucNang_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(673, 133);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(170, 41);
            this.btnXuatExcel.TabIndex = 21;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(497, 133);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(170, 41);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // FrmBaoCaoHangTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnDongChucNang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHangTieuThuMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoHangTieuThu";
            this.Text = "FrmBaoCaoHangTieuThu";
            this.Load += new System.EventHandler(this.FrmBaoCaoHangTieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTieuThuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTieuThu)).EndInit();
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

        private DevExpress.XtraGrid.GridControl dgvHangTieuThuMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHangTieuThu;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxThongKe;
        private DevExpress.XtraGrid.Columns.GridColumn MaMH;
        private DevExpress.XtraGrid.Columns.GridColumn TenMH;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;

    }
}