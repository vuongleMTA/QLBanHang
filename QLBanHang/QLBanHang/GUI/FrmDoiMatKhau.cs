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
    public partial class FrmDoiMatKhau : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        NHANVIEN nhanvien = new NHANVIEN();

        #region constructor
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        public FrmDoiMatKhau(NHANVIEN nv)
        {
            InitializeComponent();
            nhanvien = nv;
        }

        #endregion

        #region sự kiện
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.Where(p => p.NHANVIENID == nhanvien.NHANVIENID).FirstOrDefault();

            if (txtMatKhauCu.Text != nv.PASSWORD)
            {
                MessageBox.Show("Mật khẩu cũ chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhanMatKhauMoi.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nv.PASSWORD = txtMatKhauMoi.Text;
            db.SaveChanges();

            MessageBox.Show("Mật khẩu đã được thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion
    }
}
