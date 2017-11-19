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
    public partial class FrmNhanVien : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();

        #region Constructor
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgv()
        {
            int stt = 1;
            dgvNhanVienMain.DataSource = (from nv in db.NHANVIENs.ToList()
                                          from pb in db.PHONGBANs.ToList()
                                          from cv in db.CHUCVUs.ToList()
                                          where nv.PHONGBANID == pb.PHONGBANID
                                          where nv.CHUCVUID == cv.CHUCVUID
                                          select new
                                          {
                                              STT = stt++,
                                              MaNV = nv.NHANVIENID,
                                              HoVaTen = nv.HOTEN,
                                              ChucVu = cv.TENCV,
                                              PhongBan = pb.TENPB
                                          }).ToList();
        }
        private void LoadControl()
        {
            // cbx chuc vu
            cbxChucVu.DataSource = db.CHUCVUs.ToList();
            cbxChucVu.DisplayMember = "TENCV";
            cbxChucVu.ValueMember = "CHUCVUID";

            // cbx phong ban
            cbxPhongBan.DataSource = db.PHONGBANs.ToList();
            cbxPhongBan.DisplayMember = "TENPB";
            cbxPhongBan.ValueMember = "PHONGBANID";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadControl();
        }
        #endregion

        #region sự kiện ngầm
        private void dgvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int id = (int)dgvNhanVien.GetFocusedRowCellValue("MaNV");
                NHANVIEN nv = db.NHANVIENs.Where(p => p.NHANVIENID == id).First();

                cbxChucVu.SelectedValue = nv.CHUCVUID;
                cbxPhongBan.SelectedValue = nv.PHONGBANID;
                cbxGioiTinh.SelectedIndex = (int) nv.GIOITINH;

                txtHoVaTen.Text = nv.HOTEN;
                dateNS.DateTime = (DateTime) nv.NGAYSINH;
                txtSDT.Text = nv.SDT;
                txtTaiKhoan.Text = nv.USERNAME;
                txtMatKhau.Text = nv.PASSWORD;
                txtXacNhanMatKhau.Text = "";
                txtDiaChi.Text = nv.DIACHI;

            }
            catch
            {

            }
        }
        #endregion

        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.CHUCVUID = (int)cbxChucVu.SelectedValue;
                    nv.PHONGBANID = (int)cbxPhongBan.SelectedValue;
                    nv.GIOITINH = cbxGioiTinh.SelectedIndex;

                    nv.HOTEN = txtHoVaTen.Text;
                    nv.NGAYSINH = dateNS.DateTime;
                    nv.SDT = txtSDT.Text;
                    nv.USERNAME = txtTaiKhoan.Text;
                    nv.PASSWORD = txtMatKhau.Text;
                    nv.DIACHI = txtDiaChi.Text;

                    db.NHANVIENs.Add(nv);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmNhanVien_Load(sender, e);

                }
                catch
                {

                }
            }
        }

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            cbxChucVu.SelectedIndex = 0;
            cbxGioiTinh.SelectedIndex = 0;
            cbxPhongBan.SelectedIndex = 0;

            txtHoVaTen.Text = "";
            dateNS.DateTime = DateTime.Now;
            txtSDT.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtXacNhanMatKhau.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvNhanVien.GetFocusedRowCellValue("MaNV");
                NHANVIEN nv = db.NHANVIENs.Where(p => p.NHANVIENID == id).First();
                nv.CHUCVUID = (int)cbxChucVu.SelectedValue;
                nv.PHONGBANID = (int)cbxPhongBan.SelectedValue;
                nv.GIOITINH = cbxGioiTinh.SelectedIndex;

                nv.HOTEN = txtHoVaTen.Text;
                nv.NGAYSINH = dateNS.DateTime;
                nv.SDT = txtSDT.Text;
                nv.USERNAME = txtTaiKhoan.Text;
                nv.PASSWORD = txtMatKhau.Text;
                nv.DIACHI = txtDiaChi.Text;

                db.SaveChanges();

                MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmNhanVien_Load(sender, e);

            }
            catch
            {
                MessageBox.Show("Chưa có nhân viên nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvNhanVien.GetFocusedRowCellValue("MaNV");
                NHANVIEN nv = db.NHANVIENs.Where(p => p.NHANVIENID == id).First();
                
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin của nhân viên " + nv.HOTEN + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                db.NHANVIENs.Remove(nv);
                db.SaveChanges();

                MessageBox.Show("Xóa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmNhanVien_Load(sender, e);

            }
            catch
            {
                MessageBox.Show("Chưa có nhân viên nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Hàm chức năng
        private bool Check()
        {
            return true;
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
