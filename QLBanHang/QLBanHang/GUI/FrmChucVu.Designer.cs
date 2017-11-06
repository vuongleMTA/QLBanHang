namespace QLBanHang.GUI
{
    partial class FrmChucVu
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
            this.btnLamTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCV = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvChucVuMain = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamTrang
            // 
            this.btnLamTrang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLamTrang.Location = new System.Drawing.Point(815, 384);
            this.btnLamTrang.Name = "btnLamTrang";
            this.btnLamTrang.Size = new System.Drawing.Size(199, 45);
            this.btnLamTrang.TabIndex = 38;
            this.btnLamTrang.Text = "Xóa trắng";
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Location = new System.Drawing.Point(610, 486);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(404, 45);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Location = new System.Drawing.Point(815, 435);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 45);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Location = new System.Drawing.Point(610, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 45);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Location = new System.Drawing.Point(610, 435);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(199, 45);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtMaCV);
            this.groupBox1.Controls.Add(this.txtTenCV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(610, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 156);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.AutoSize = true;
            this.txtMaCV.Location = new System.Drawing.Point(121, 53);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(13, 13);
            this.txtMaCV.TabIndex = 16;
            this.txtMaCV.Text = "1";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(124, 95);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(244, 20);
            this.txtTenCV.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên chức vụ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã chức vụ : ";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dgvChucVu.ColumnPanelRowHeight = 30;
            this.dgvChucVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaCV,
            this.TenCV});
            this.dgvChucVu.FixedLineWidth = 1;
            this.dgvChucVu.GridControl = this.dgvChucVuMain;
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.OptionsBehavior.Editable = false;
            this.dgvChucVu.OptionsBehavior.ReadOnly = true;
            this.dgvChucVu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChucVu.PaintStyleName = "UltraFlat";
            this.dgvChucVu.RowHeight = 40;
            // 
            // MaCV
            // 
            this.MaCV.Caption = "Mã chức vụ";
            this.MaCV.FieldName = "MaCV";
            this.MaCV.Name = "MaCV";
            this.MaCV.Visible = true;
            this.MaCV.VisibleIndex = 0;
            this.MaCV.Width = 164;
            // 
            // TenCV
            // 
            this.TenCV.Caption = "Tên chức vụ";
            this.TenCV.FieldName = "TenCV";
            this.TenCV.Name = "TenCV";
            this.TenCV.Visible = true;
            this.TenCV.VisibleIndex = 1;
            this.TenCV.Width = 535;
            // 
            // dgvChucVuMain
            // 
            this.dgvChucVuMain.Location = new System.Drawing.Point(20, 43);
            this.dgvChucVuMain.MainView = this.dgvChucVu;
            this.dgvChucVuMain.Name = "dgvChucVuMain";
            this.dgvChucVuMain.Size = new System.Drawing.Size(573, 488);
            this.dgvChucVuMain.TabIndex = 32;
            this.dgvChucVuMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChucVu});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Danh sách các chức vụ";
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.btnLamTrang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvChucVuMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChucVu";
            this.Text = "FrmPhongBan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVuMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLamTrang;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChucVu;
        private DevExpress.XtraGrid.GridControl dgvChucVuMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn MaCV;
        private DevExpress.XtraGrid.Columns.GridColumn TenCV;


    }
}