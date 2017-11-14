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
    public partial class FrmDanhSachKhachHang : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();

        #region Constructor
        public FrmDanhSachKhachHang()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgv()
        {
            try
            {
                int i = 1;
                dgvKhachHangMain.DataSource = (from kh in db.KHACHHANGs.ToList()
                                               select new
                                               {
                                                   MaKH = kh.KHACHHANGID,
                                                   STT = i++,
                                                   HoVaTen = kh.HOTEN,
                                                   NgaySinh = ((DateTime)kh.NGAYSINH).ToString("dd/MM/yyyy"),
                                                   GioiTinh = kh.GIOITINH == 0 ? "Nữ" : "Nam"
                                               }).ToList();
             
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //}
        private void FrmDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        #endregion

        #region sự kiện ngầm
        private void dgvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int id = (int)dgvKhachHang.GetFocusedRowCellValue("MaKH");
                KHACHHANG kh = db.KHACHHANGs.Where(p => p.KHACHHANGID == id).First();

                txtMaKH.Text = kh.KHACHHANGID.ToString();
                txtHoTen.Text = kh.HOTEN;
                dateNS.DateTime = (DateTime) kh.NGAYSINH;
                cbxGioiTinh.SelectedIndex = (int) kh.GIOITINH;
                txtSDT.Text = kh.SDT;
                txtDiaChi.Text = kh.DIACHI;
            }
            catch
            {

            }
        }

        #endregion

        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.HOTEN = txtHoTen.Text;
                kh.NGAYSINH = dateNS.DateTime;
                kh.GIOITINH = cbxGioiTinh.SelectedIndex;
                kh.SDT = txtSDT.Text;
                kh.DIACHI = txtDiaChi.Text;

                db.KHACHHANGs.Add(kh);
                db.SaveChanges();

                MessageBox.Show("Thêm thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {

            }
        }

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            dateNS.DateTime = DateTime.Now;
            cbxGioiTinh.SelectedIndex = 0;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvKhachHang.GetFocusedRowCellValue("MaKH");
                KHACHHANG kh = db.KHACHHANGs.Where(p => p.KHACHHANGID == id).First();

                kh.HOTEN = txtHoTen.Text;
                kh.NGAYSINH = dateNS.DateTime;
                kh.GIOITINH = cbxGioiTinh.SelectedIndex;
                kh.SDT = txtSDT.Text;
                kh.DIACHI = txtDiaChi.Text;

                db.SaveChanges();

                MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có khách hàng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvKhachHang.GetFocusedRowCellValue("MaKH");
                KHACHHANG kh = db.KHACHHANGs.Where(p => p.KHACHHANGID == id).First();

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin khách hàng "+kh.HOTEN+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                db.KHACHHANGs.Remove(kh);
                db.SaveChanges();

                MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có khách hàng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHangMain_Click(object sender, EventArgs e)
        {

        }

       
    }
}
