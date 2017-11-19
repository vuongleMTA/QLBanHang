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
    public partial class FrmChucVu : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();

        #region constructor
        public FrmChucVu()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgv()
        {
            dgvChucVuMain.DataSource = (from pb in db.CHUCVUs
                                          select new
                                          {
                                              MaCV = pb.CHUCVUID,
                                              TenCV = pb.TENCV
                                          }).ToList();
        }
        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        #endregion

        #region sự kiện ngầm
        private void dgvPhongBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtTenCV.Text = (string)dgvChucVu.GetFocusedRowCellValue("TenCV");
                txtMaCV.Text = dgvChucVu.GetFocusedRowCellValue("MaCV").ToString();
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
                CHUCVU tg = new CHUCVU();
                tg.TENCV = txtTenCV.Text;

                db.CHUCVUs.Add(tg);
                db.SaveChanges();

                MessageBox.Show("Thêm thông tin chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {

            }
        }

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dgvChucVu.GetFocusedRowCellValue("MaCV").ToString());
                CHUCVU tg = db.CHUCVUs.Where(p => p.CHUCVUID == id).First();
                tg.TENCV = txtTenCV.Text;

                db.SaveChanges();

                MessageBox.Show("Sửa thông tin chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có chức vụ nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dgvChucVu.GetFocusedRowCellValue("MaCV").ToString());
                CHUCVU tg = db.CHUCVUs.Where(p => p.CHUCVUID == id).First();

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chức vụ " + tg.TENCV + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                db.CHUCVUs.Remove(tg);
                db.SaveChanges();

                MessageBox.Show("Xóa thông tin chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có chức vụ nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
