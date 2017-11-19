namespace QuanLyHangHoa.GUI
{
    partial class FrmBaoCaoKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoKhoHang));
            this.dgvKhoMain = new DevExpress.XtraGrid.GridControl();
            this.dgvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.txtDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoMain
            // 
            this.dgvKhoMain.Location = new System.Drawing.Point(12, 25);
            this.dgvKhoMain.MainView = this.dgvKho;
            this.dgvKhoMain.Name = "dgvKhoMain";
            this.dgvKhoMain.Size = new System.Drawing.Size(1007, 470);
            this.dgvKhoMain.TabIndex = 18;
            this.dgvKhoMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKho});
            // 
            // dgvKho
            // 
            this.dgvKho.ColumnPanelRowHeight = 30;
            this.dgvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MatHang,
            this.SoLuong,
            this.ID});
            this.dgvKho.GridControl = this.dgvKhoMain;
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.OptionsBehavior.Editable = false;
            this.dgvKho.OptionsBehavior.ReadOnly = true;
            this.dgvKho.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvKho.PaintStyleName = "UltraFlat";
            this.dgvKho.RowHeight = 40;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 89;
            // 
            // MatHang
            // 
            this.MatHang.Caption = "Mặt hàng";
            this.MatHang.FieldName = "TenMH";
            this.MatHang.Name = "MatHang";
            this.MatHang.Visible = true;
            this.MatHang.VisibleIndex = 1;
            this.MatHang.Width = 305;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng sản phẩm";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 305;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách các mặt hàng trong kho : Ngày ";
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(771, 501);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(248, 45);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(517, 501);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(248, 45);
            this.btnXuatExcel.TabIndex = 20;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(228, 9);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(95, 13);
            this.txtDate.TabIndex = 22;
            this.txtDate.Text = "20/07/2017 08:15";
            // 
            // FrmBaoCaoKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1031, 558);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvKhoMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoCaoKhoHang";
            this.Text = "FrmBaoCaoKhoHang";
            this.Load += new System.EventHandler(this.FrmBaoCaoKhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvKhoMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKho;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
        private System.Windows.Forms.Label txtDate;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MatHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ID;

    }
}