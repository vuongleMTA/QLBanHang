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
    public partial class FrmNhaSanXuat : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();

        #region constructor
        public FrmNhaSanXuat()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgv()
        {
            dgvNSXMain.DataSource = (from nsx in db.NHASANXUATs
                                     select new
                                     {
                                         MaNSX = nsx.NHASANXUATID,
                                         TenNSX = nsx.TEN,
                                         NamThanhLap = nsx.NAMTHANHLAP
                                     }).ToList();
        }
        private void FrmNhaSanXuat_Load(object sender, EventArgs e)
        {
            LoadDgv();   
        }
        #endregion

        #region sự kiện ngầm
        private void dgvNSX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int namthanhlap = (int)dgvNSX.GetFocusedRowCellValue("NamThanhLap");
                txtTenNSX.Text = (string) dgvNSX.GetFocusedRowCellValue("TenNSX");
                txtNamThanhLap.Value = namthanhlap;
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
                NHASANXUAT nsx = new NHASANXUAT();
                nsx.TEN = txtTenNSX.Text;
                nsx.NAMTHANHLAP = (int) txtNamThanhLap.Value;

                db.NHASANXUATs.Add(nsx);
                db.SaveChanges();

                MessageBox.Show("Thêm thông tin nhà sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {

            }
        }

        private void btnLamTrang_Click(object sender, EventArgs e)
        {
            txtTenNSX.Text = "";
            txtNamThanhLap.Value = 1900;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvNSX.GetFocusedRowCellValue("MaNSX");
                NHASANXUAT nsx = db.NHASANXUATs.Where(p => p.NHASANXUATID == id).First();
                nsx.TEN = txtTenNSX.Text;
                nsx.NAMTHANHLAP = (int)txtNamThanhLap.Value;

                db.SaveChanges();

                MessageBox.Show("Sửa thông tin nhà nhà sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có nhà sản xuất nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvNSX.GetFocusedRowCellValue("MaNSX");
                NHASANXUAT nsx = db.NHASANXUATs.Where(p => p.NHASANXUATID == id).First();

                DialogResult rs = MessageBox.Show("Bạn có chắc chẵn xóa thông tin của nhà sản xuất " + nsx.TEN + "?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                db.NHASANXUATs.Remove(nsx);
                db.SaveChanges();

                MessageBox.Show("Xóa thông tin nhà nhà sản xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDgv();
            }
            catch
            {
                MessageBox.Show("Chưa có nhà sản xuất nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
