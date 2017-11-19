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
    public partial class FrmLogin : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.ToList().Where(p => p.USERNAME == txtTenDangNhap.Text && p.PASSWORD == txtMatKhau.Text).FirstOrDefault();

            if (nv == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmMain main = new FrmMain(nv);
            this.Hide();
            main.ShowDialog();
            
            db.Dispose();
            db = new QUANLYHANGHOAEntities();

            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
