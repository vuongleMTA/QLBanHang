using QuanLyHangHoa.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoa.GUI
{
    public partial class FrmMain : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        NHANVIEN nhanvien = new NHANVIEN();

        #region Constructor
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(NHANVIEN nv)
        {
            InitializeComponent();
            nhanvien = nv;
        }
        #endregion

        #region sự kiện mở các form
        private void barNhanVienNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapHang tg = new FrmNhapHang();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barNhanVienBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBanHang tg = new FrmBanHang();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barDanhSachKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDanhSachKhachHang tg = new FrmDanhSachKhachHang();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barMatHangKinhDoanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMatHangKinhDoanh tg = new FrmMatHangKinhDoanh();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barDMChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChucVu tg = new FrmChucVu();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barnQuanTriPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhongBan tg = new FrmPhongBan();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barQuanTriNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhanVien tg = new FrmNhanVien();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barQuanTriNhaSanXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhaSanXuat tg = new FrmNhaSanXuat();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barBaoCaoKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBaoCaoKhoHang tg = new FrmBaoCaoKhoHang();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barBaoCaoLuongHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //dua 1 form vao phai qua cac buoc nay
            FrmBaoCaoHangTieuThu tg = new FrmBaoCaoHangTieuThu();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void barBaoCaoDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBaoCaoDoanhThu tg = new FrmBaoCaoDoanhThu();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tg);
            tg.Show();
            
        }
        #endregion

        #region sự kiện
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel) return;

            this.Close();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau tg = new FrmDoiMatKhau(nhanvien);
            tg.ShowDialog();
        }
        #endregion

        #region LoadForm
        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = nhanvien.HOTEN;
            txtChucVu.Text = (string) db.CHUCVUs.Where(p => p.CHUCVUID == nhanvien.CHUCVUID).FirstOrDefault().TENCV;

            if (txtChucVu.Text != "Nhân viên") return;
            rbQuanTri.Visible = false;
        }
        #endregion
    }
}
