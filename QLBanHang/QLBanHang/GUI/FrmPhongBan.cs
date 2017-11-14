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
    public partial class FrmPhongBan : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();

        #region constructor
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgv()
        {
            dgvPhongBanMain.DataSource = (from pb in db.PHONGBANs
                                          select new
                                          {
                                              MaPB = pb.PHONGBANID,
                                              TenPB = pb.TENPB
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
                txtTenPB.Text = (string)dgvPhongBan.GetFocusedRowCellValue("TenPB");
                txtMaPB.Text = dgvPhongBan.GetFocusedRowCellValue("MaPB").ToString();
                
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
                PHONGBAN pb = new PHONGBAN();
                pb.TENPB = txtTenPB.Text;

                db.PHONGBANs.Add(pb);
                db.SaveChanges();

                MessageBox.Show("Thêm thông tin phòng ban thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {

            }
        }

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dgvPhongBan.GetFocusedRowCellValue("MaPB").ToString());
                PHONGBAN pb = db.PHONGBANs.Where(p => p.PHONGBANID == id).First();
                pb.TENPB = txtTenPB.Text;

                db.SaveChanges();

                MessageBox.Show("Sửa thông tin phòng ban thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có phòng ban nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dgvPhongBan.GetFocusedRowCellValue("MaPB").ToString());
                PHONGBAN pb = db.PHONGBANs.Where(p => p.PHONGBANID == id).First();

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa phòng ban " + pb.TENPB + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                db.PHONGBANs.Remove(pb);
                db.SaveChanges();

                MessageBox.Show("Xóa thông tin phòng ban thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có phòng ban nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
