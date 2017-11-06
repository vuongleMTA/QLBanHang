namespace QLBanHang.GUI
{
    partial class FrmNhaSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaSanXuat));
            this.btnLamTrang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNamThanhLap = new System.Windows.Forms.NumericUpDown();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvNSX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamThanhLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvNSXMain = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamThanhLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSXMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamTrang
            // 
            this.btnLamTrang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLamTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnLamTrang.Image")));
            this.btnLamTrang.Location = new System.Drawing.Point(815, 384);
            this.btnLamTrang.Name = "btnLamTrang";
            this.btnLamTrang.Size = new System.Drawing.Size(199, 45);
            this.btnLamTrang.TabIndex = 30;
            this.btnLamTrang.Text = "Xóa trắng";
          //  this.btnLamTrang.Click += new System.EventHandler(this.btnLamTrang_Click);
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(610, 486);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(404, 45);
            this.btnDong.TabIndex = 26;
            this.btnDong.Text = "Đóng chức năng";
          //  this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(815, 435);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 45);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
          //  this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(610, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 45);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
          //  this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(610, 435);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(199, 45);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
          //  this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtNamThanhLap);
            this.groupBox1.Controls.Add(this.txtTenNSX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(610, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà sản xuất";
            // 
            // txtNamThanhLap
            // 
            this.txtNamThanhLap.Location = new System.Drawing.Point(124, 96);
            this.txtNamThanhLap.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txtNamThanhLap.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txtNamThanhLap.Name = "txtNamThanhLap";
            this.txtNamThanhLap.Size = new System.Drawing.Size(123, 20);
            this.txtNamThanhLap.TabIndex = 16;
            this.txtNamThanhLap.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Location = new System.Drawing.Point(124, 50);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(244, 20);
            this.txtTenNSX.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Năm thành lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên nhà sản xuất";
            // 
            // dgvNSX
            // 
            this.dgvNSX.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dgvNSX.ColumnPanelRowHeight = 30;
            this.dgvNSX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNSX,
            this.TenNSX,
            this.NamThanhLap});
            this.dgvNSX.FixedLineWidth = 1;
            this.dgvNSX.GridControl = this.dgvNSXMain;
            this.dgvNSX.Name = "dgvNSX";
            this.dgvNSX.OptionsBehavior.Editable = false;
            this.dgvNSX.OptionsBehavior.ReadOnly = true;
            this.dgvNSX.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvNSX.PaintStyleName = "UltraFlat";
            this.dgvNSX.RowHeight = 40;
           // this.dgvNSX.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvNSX_FocusedRowChanged);
            // 
            // MaNSX
            // 
            this.MaNSX.Caption = "Mã NSX";
            this.MaNSX.FieldName = "MaNSX";
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.Visible = true;
            this.MaNSX.VisibleIndex = 0;
            this.MaNSX.Width = 130;
            // 
            // TenNSX
            // 
            this.TenNSX.Caption = "Tên nhà sản xuất";
            this.TenNSX.FieldName = "TenNSX";
            this.TenNSX.Name = "TenNSX";
            this.TenNSX.Visible = true;
            this.TenNSX.VisibleIndex = 1;
            this.TenNSX.Width = 359;
            // 
            // NamThanhLap
            // 
            this.NamThanhLap.Caption = "Năm thành lập";
            this.NamThanhLap.FieldName = "NamThanhLap";
            this.NamThanhLap.Name = "NamThanhLap";
            this.NamThanhLap.Visible = true;
            this.NamThanhLap.VisibleIndex = 2;
            this.NamThanhLap.Width = 210;
            // 
            // dgvNSXMain
            // 
            this.dgvNSXMain.Location = new System.Drawing.Point(20, 43);
            this.dgvNSXMain.MainView = this.dgvNSX;
            this.dgvNSXMain.Name = "dgvNSXMain";
            this.dgvNSXMain.Size = new System.Drawing.Size(573, 488);
            this.dgvNSXMain.TabIndex = 24;
            this.dgvNSXMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNSX});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Danh sách nhà sản xuất";
            // 
            // FrmNhaSanXuat
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
            this.Controls.Add(this.dgvNSXMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhaSanXuat";
            this.Text = "FrmNhaSanXuat";
           // this.Load += new System.EventHandler(this.FrmNhaSanXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamThanhLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSXMain)).EndInit();
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
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNSX;
        private DevExpress.XtraGrid.GridControl dgvNSXMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtNamThanhLap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNSX;
        private DevExpress.XtraGrid.Columns.GridColumn TenNSX;
        private DevExpress.XtraGrid.Columns.GridColumn NamThanhLap;


    }
}