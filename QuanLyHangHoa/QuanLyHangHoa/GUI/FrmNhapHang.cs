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
    public partial class FrmNhapHang : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        private int index;

        #region constructor
        public FrmNhapHang()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadControl()
        {
            /// cbxNhanVien
            cbxNhanVien.DataSource = db.NHANVIENs.ToList();
            cbxNhanVien.DisplayMember = "HOTEN";
            cbxNhanVien.ValueMember = "NHANVIENID";

            // cbx mat hang
            cbxMatHang.DataSource = db.MATHANGs.ToList();
            cbxMatHang.DisplayMember = "TENMH";
            cbxMatHang.ValueMember = "MATHANGID";
        }
        private void LoadPhieuNhap()
        {
            txtIndex.Text = (index + 1).ToString() + "/" + db.NHAPs.Count();

            try
            {
                NHAP nhap = db.NHAPs.ToList()[index];

                cbxNhanVien.SelectedValue = nhap.NHANVIENID;
                dateNgayNhap.DateTime = (DateTime)nhap.NGAY;
                txtDiaDiem.Text = nhap.DIADIEMNHAP;
                LoadDgvChiTietNhap();
            }
            catch
            {

            }
        }
        private void LoadDgvChiTietNhap()
        {
            try
            {
                NHAP nhap = db.NHAPs.ToList()[index];

                dgvChiTietNhapMain.DataSource = (from ctn in db.CHITIETNHAPs.ToList()
                                                 from mh in db.MATHANGs.ToList()
                                                 where ctn.NHAPID == nhap.NHAPID
                                                 where mh.MATHANGID == ctn.MATHANGID
                                                 select new
                                                 {
                                                     MaCTN = ctn.CHITIETNHAPID,
                                                     MatHang = mh.TENMH,
                                                     DonViTinh = mh.DONVITINH,
                                                     SoLuong = ctn.SOLUONG,
                                                     DonGia= ctn.GIANHAP,
                                                     ThanhTien = ctn.GIANHAP * ctn.SOLUONG
                                                 })
                                                 .ToList();
                txtTongTien.Text = "0";
                txtTongTien.Text = ((int)db.CHITIETNHAPs.Where(p => p.NHAPID == nhap.NHAPID).Sum(p => p.SOLUONG * p.GIANHAP)).ToString();
            }
            catch
            {

            }
        }
        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            LoadControl();
            index = db.NHAPs.Count() - 1;
            LoadPhieuNhap();
            
        }
        #endregion

        #region Sự kiện phiếu nhập

        #region đổi index
        private void btnStart_Click(object sender, EventArgs e)
        {
            index = 0;
            LoadPhieuNhap();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;
            LoadPhieuNhap();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (index < db.NHAPs.Count() - 1) index++;
            LoadPhieuNhap();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            index = db.NHAPs.Count() - 1;
            LoadPhieuNhap();
        }
        #endregion

        #region sự kiện thêm sửa xóa
        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            NHAP nhap = new NHAP();
            nhap.NHANVIENID = (int) cbxNhanVien.SelectedValue;
            nhap.NGAY = dateNgayNhap.DateTime;
            nhap.DIADIEMNHAP = txtDiaDiem.Text;

            db.NHAPs.Add(nhap);
            db.SaveChanges();

            MessageBox.Show("Thêm chi tiết nhập thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            index = db.NHAPs.Count() - 1;
            LoadPhieuNhap();
        }

        private void btnLamTrangPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NHAP nhap = db.NHAPs.ToList()[index];
                db.NHAPs.Remove(nhap);
                List<CHITIETNHAP> ct = db.CHITIETNHAPs.Where(p => p.NHAPID == nhap.NHAPID).ToList();
                foreach (var r in ct)
                {
                    db.CHITIETNHAPs.Remove(r);
                }
                db.SaveChanges();
                MessageBox.Show("xóa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuNhap();

            }
            catch
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NHAP nhap = db.NHAPs.ToList()[index];
                nhap.NHANVIENID = (int)cbxNhanVien.SelectedValue;
                nhap.NGAY = dateNgayNhap.DateTime;
                nhap.DIADIEMNHAP = txtDiaDiem.Text;

                db.SaveChanges();
                MessageBox.Show("Sửa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuNhap();

            }
            catch
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                NHAP nhap = db.NHAPs.ToList()[index];
                db.NHAPs.Remove(nhap);

                db.SaveChanges();
                MessageBox.Show("xóa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhieuNhap();

            }
            catch
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion

        #region sự kiện chi tiết nhập
        private void dgvChiTietNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int id = (int) dgvChiTietNhap.GetFocusedRowCellValue("MaCTN");

                CHITIETNHAP ctn = db.CHITIETNHAPs.ToList().Where(p => p.CHITIETNHAPID == id).First();

                cbxMatHang.SelectedValue = ctn.MATHANGID;
                txtDonViTinh.Text = db.MATHANGs.Where(p => p.MATHANGID == ctn.MATHANGID).First().DONVITINH;
                txtDonGia.Value = (int)ctn.GIANHAP;
                txtSoLuong.Value = (int)ctn.SOLUONG;
                txtThanhTien.Text = (ctn.GIANHAP * ctn.SOLUONG).ToString();
            }
            catch
            {

            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NHAP nhap = db.NHAPs.ToList()[index];
                CHITIETNHAP ctn = new CHITIETNHAP();

                ctn.NHAPID = nhap.NHAPID;
                ctn.MATHANGID = (int) cbxMatHang.SelectedValue;
                ctn.SOLUONG = (int) txtSoLuong.Value;
                ctn.GIANHAP = (int) txtDonGia.Value;

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn thêm chi tiết nhập gồm "+ctn.SOLUONG.ToString()+" mặt hàng "+cbxMatHang.Text+"?","Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;
                List<CHITIETNHAP> ct = db.CHITIETNHAPs.Where(p => p.NHAPID == nhap.NHAPID).ToList();
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
                if (i == 1)
                    db.CHITIETNHAPs.Add(ctn);

                KHO kho = null;
                try
                {
                    kho = db.KHOes.Where(p => p.MATHANGID == ctn.MATHANGID).First();
                }
                catch
                {

                }


                if (kho == null)
                {
                    kho = new KHO();
                    kho.MATHANGID = ctn.MATHANGID;
                    kho.SOLUONG = ctn.SOLUONG;
                    db.KHOes.Add(kho);
                }
                else
                {
                    kho.SOLUONG += ctn.SOLUONG;
                }

                db.SaveChanges();

                MessageBox.Show("Thêm chi tiết nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvChiTietNhap();
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvChiTietNhap.GetFocusedRowCellValue("MaCTN");
                CHITIETNHAP ctn = db.CHITIETNHAPs.Where(p => p.CHITIETNHAPID == id).First();

                db.CHITIETNHAPs.Remove(ctn);
                db.SaveChanges();

                MessageBox.Show("Xóa chi tiết nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgvChiTietNhap();
                //LoadPhieuNhap();
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
                dgvChiTietNhap.ExportToXls(FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file cần ghi lại để quá trình ghi thành công");
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region sự kiện ngầm
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
        #endregion

        
    }
}
