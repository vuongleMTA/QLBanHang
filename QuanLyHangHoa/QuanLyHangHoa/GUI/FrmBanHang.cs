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
    public partial class FrmBanHang : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        private int index;

        #region constructor
        public FrmBanHang()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadControl()
        {
            // cbx nhan vien
            cbxNhanVien.DataSource = db.NHANVIENs.ToList();
            cbxNhanVien.DisplayMember = "HOTEN";
            cbxNhanVien.ValueMember = "NHANVIENID";

            // cbx khach hang
            cbxKhachHang.DataSource = db.KHACHHANGs.ToList();
            cbxKhachHang.DisplayMember = "HOTEN";
            cbxKhachHang.ValueMember = "KHACHHANGID";

            // cbx Mat Hang 
            cbxMatHang.DataSource = db.MATHANGs.ToList();
            cbxMatHang.DisplayMember = "TENMH";
            cbxMatHang.ValueMember = "MATHANGID";
        }
        private void LoadPhieuXuat()
        {
            txtIndex.Text = (index + 1).ToString() + "/" + db.XUATs.Count();

            try
            {
                XUAT xuat = db.XUATs.ToList()[index];

                cbxNhanVien.SelectedValue = xuat.NHANVIENID;
                dateNgayXuat.DateTime = (DateTime)xuat.NGAY;
                cbxKhachHang.SelectedValue = xuat.KHACHHANGID;
                LoadDgvChiTietXuat();
            }
            catch
            {

            }
        }
        private void LoadDgvChiTietXuat()
        {
            try
            {
                XUAT xuat = db.XUATs.ToList()[index];

                dgvChiTietXuatMain.DataSource = (from ctx in db.CHITIETXUATs.ToList()
                                                 from mh in db.MATHANGs.ToList()
                                                 where ctx.XUATID == xuat.XUATID
                                                 where mh.MATHANGID == ctx.MATHANGID
                                                 select new
                                                 {
                                                     MaCTX = ctx.CHITIETXUATID,
                                                     MatHang = mh.TENMH,
                                                     DonViTinh = mh.DONVITINH,
                                                     SoLuong = ctx.SOLUONG,
                                                     DonGia = ctx.GIABAN,
                                                     ThanhTien = ctx.GIABAN * ctx.SOLUONG
                                                 })
                                                 .ToList();
                txtTongTien.Text = "0";
                txtTongTien.Text = ((int)db.CHITIETXUATs.Where(p => p.XUATID == xuat.XUATID).Sum(p => p.SOLUONG * p.GIABAN)).ToString();
            }
            catch
            {

            }
        }
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            LoadControl();
            index = db.XUATs.Count() - 1;
            LoadPhieuXuat();
        }
        #endregion

        #region sự kiện phiếu xuất
        private void btnStart_Click(object sender, EventArgs e)
        {
            index = 0;
            LoadPhieuXuat();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;
            LoadPhieuXuat();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < db.XUATs.Count() - 1) index++;
            LoadPhieuXuat();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            index = db.XUATs.Count() - 1;
            LoadPhieuXuat();
        }
        #endregion

        #region sự kiện thêm sửa xóa phiếu xuất
        private void btnThemPhieuXuat_Click(object sender, EventArgs e)
        {
           
            XUAT xuat = new XUAT();
            xuat.NHANVIENID = (int) cbxNhanVien.SelectedValue;
            xuat.NGAY = dateNgayXuat.DateTime;
            xuat.KHACHHANGID = (int)cbxKhachHang.SelectedValue;

            try
            {
                db.XUATs.Add(xuat);
                db.SaveChanges();

                MessageBox.Show("Thêm thông tin phiếu xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                index = db.XUATs.Count() - 1;
                LoadPhieuXuat();

            }

            catch {

                MessageBox.Show("Mời nhập ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
               
               
           
        }

        private void btnSuaPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                XUAT xuat = db.XUATs.ToList()[index];
                xuat.NHANVIENID = (int)cbxNhanVien.SelectedValue;
                xuat.NGAY = dateNgayXuat.DateTime;
                xuat.KHACHHANGID = (int)cbxKhachHang.SelectedValue;

                db.SaveChanges();
                MessageBox.Show("Sửa phiếu xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuXuat();

            }
            catch
            {
                MessageBox.Show("Chưa có phiếu xuất nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamTrangPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                XUAT xuat = db.XUATs.ToList()[index];
                db.XUATs.Remove(xuat);
                List<CHITIETXUAT> ct = db.CHITIETXUATs.Where(p => p.XUATID == xuat.XUATID).ToList();
                foreach (var r in ct)
                {
                    db.CHITIETXUATs.Remove(r);
                }

                db.SaveChanges();
                MessageBox.Show("xóa phiếu xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuXuat();

            }
            catch
            {
                MessageBox.Show("Chưa có phiếu xuất nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region sự kiện chi tiết xuất
        private void dgvChiTietXuat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int id = (int)dgvChiTietXuat.GetFocusedRowCellValue("MaCTX");

                CHITIETXUAT ctn = db.CHITIETXUATs.ToList().Where(p => p.CHITIETXUATID == id).First();

                cbxMatHang.SelectedValue = ctn.MATHANGID;
                txtDonViTinh.Text = db.MATHANGs.Where(p => p.MATHANGID == ctn.MATHANGID).First().DONVITINH;
                txtDonGia.Value = (int)ctn.GIABAN;
                txtSoLuong.Value = (int)ctn.SOLUONG;
                txtThanhTien.Text = (ctn.GIABAN * ctn.SOLUONG).ToString();
            }
            catch
            {

            }
        }

        private void cbxMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbxMatHang.SelectedValue;
                txtDonViTinh.Text = db.MATHANGs.Where(p => p.MATHANGID == id).First().DONVITINH;
            }
            catch
            {

            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KHO kho = null;
               
                XUAT xuat = db.XUATs.ToList()[index];
                CHITIETXUAT ctx = new CHITIETXUAT();

                ctx.XUATID = xuat.XUATID;
                ctx.MATHANGID = (int)cbxMatHang.SelectedValue;
                ctx.SOLUONG = (int)txtSoLuong.Value;
                ctx.GIABAN = (int)txtDonGia.Value;

                try
                {
                    kho = db.KHOes.Where(p => p.MATHANGID == ctx.MATHANGID).First();
                }
                catch
                {

                }

                if (kho == null || kho.SOLUONG < ctx.SOLUONG)
                {
                    MessageBox.Show("Số lượng hàng trong kho của mặt hàng " + cbxMatHang.Text + " không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                kho.SOLUONG -= ctx.SOLUONG;
                List<CHITIETXUAT> ct = db.CHITIETXUATs.Where(p => p.XUATID == xuat.XUATID).ToList();
                int i = 1;
                foreach (var r in ct)
                {
                    if (r.MATHANGID == (int)cbxMatHang.SelectedValue)
                    {
                        r.SOLUONG += (int)txtSoLuong.Value;
                        db.SaveChanges();
                        i = 0;
                        break;
                    }
                }
                if(i==1)
                db.CHITIETXUATs.Add(ctx);
                db.SaveChanges();

                MessageBox.Show("Thêm chi tiết xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvChiTietXuat();
            }
            catch
            {

            }
        }

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            cbxMatHang.SelectedIndex = 0;
            int id = (int)cbxMatHang.SelectedValue;

            txtDonViTinh.Text = db.MATHANGs.Where(p => p.MATHANGID == id).First().DONVITINH;
            txtDonGia.Value = 0;
            txtSoLuong.Value = 1;
            txtThanhTien.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvChiTietXuat.GetFocusedRowCellValue("MaCTX");
                CHITIETXUAT ctx = db.CHITIETXUATs.Where(p => p.CHITIETXUATID == id).First();

                db.CHITIETXUATs.Remove(ctx);
                db.SaveChanges();

                MessageBox.Show("Xóa chi tiết xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvChiTietXuat();
              
            }
            catch
            {

            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // lam sau
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xls";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            string FileName = saveFileDialog1.FileName.ToString();
            try
            {
                dgvChiTietXuat.ExportToXls(FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file cần ghi lại để quá trình ghi thành công");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvChiTietXuatMain_Click(object sender, EventArgs e)
        {

        }
        
    }
}
