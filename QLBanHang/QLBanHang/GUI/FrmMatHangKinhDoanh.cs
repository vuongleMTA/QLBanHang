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
    public partial class FrmMatHangKinhDoanh : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();

        #region constructor
        public FrmMatHangKinhDoanh()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgv()
        {
            dgvMatHangMain.DataSource = (from mh in db.MATHANGs.ToList()
                                         from nsx in db.NHASANXUATs.ToList()
                                         where mh.NHASANXUATID == nsx.NHASANXUATID
                                         select new
                                         {
                                             MaMH = mh.MATHANGID,
                                             TenMH = mh.TENMH,
                                             ThanhPhan = mh.THANHPHAN,
                                             DonViTinh = mh.DONVITINH,
                                             NSX = nsx.TEN,
                                             NhaSanXuatID = nsx.NHASANXUATID
                                         })
                                    .ToList();
        }

        private void InitControl()
        {
            cbxNhaSanXuat.DataSource = db.NHASANXUATs.ToList();
            cbxNhaSanXuat.DisplayMember = "TEN";
            cbxNhaSanXuat.ValueMember = "NHASANXUATID";
        }
        private void FrmMatHangKinhDoanh_Load(object sender, EventArgs e)
        {
            InitControl();
            LoadDgv();
            
        }
        #endregion

        #region sự kiện ngầm
        private void dgvMatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int mhID = (int) dgvMatHang.GetFocusedRowCellValue("MaMH");
                txtTenMH.Text = (string)dgvMatHang.GetFocusedRowCellValue("TenMH");
                txtDonViTinh.Text = (string)dgvMatHang.GetFocusedRowCellValue("DonViTinh");
                txtThanhPhan.Text = (string)dgvMatHang.GetFocusedRowCellValue("ThanhPhan");
                cbxNhaSanXuat.SelectedValue = (int)dgvMatHang.GetFocusedRowCellValue("NhaSanXuatID");
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
                MATHANG mh = new MATHANG();
                mh.TENMH = txtTenMH.Text;
                mh.DONVITINH = txtDonViTinh.Text;
                mh.THANHPHAN = txtThanhPhan.Text;
                int sx = int.Parse(cbxNhaSanXuat.SelectedValue.ToString());
                
                mh.NHASANXUATID = sx;


              //  mh.MATHANGID = 100;

                db.MATHANGs.Add(mh);
                db.SaveChanges();

                MessageBox.Show("Thêm mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();

            }
            catch
            {
               
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvMatHang.GetFocusedRowCellValue("MaMH");
                MATHANG mh = db.MATHANGs.Where(p => p.MATHANGID == id).First();
                mh.TENMH = txtTenMH.Text;
                mh.DONVITINH = txtDonViTinh.Text;
                mh.THANHPHAN = txtThanhPhan.Text;
                mh.NHASANXUATID = (int)cbxNhaSanXuat.SelectedValue;

                db.SaveChanges();

                MessageBox.Show("Sửa thông tin mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvMatHang.GetFocusedRowCellValue("MaMH");
                MATHANG mh = db.MATHANGs.Where(p => p.MATHANGID == id).First();

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng " + mh.TENMH + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                db.MATHANGs.Remove(mh);
                db.SaveChanges();

                MessageBox.Show("Sửa thông tin mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtDonViTinh.Text = "";
            txtThanhPhan.Text = "";
            cbxNhaSanXuat.SelectedIndex = 0;
        }
        #endregion

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
