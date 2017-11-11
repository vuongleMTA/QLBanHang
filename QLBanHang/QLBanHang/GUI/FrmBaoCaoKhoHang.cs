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
    public partial class FrmBaoCaoKhoHang : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        public FrmBaoCaoKhoHang()
        {
            InitializeComponent();
        }

        #region LoadForm
        private void FrmBaoCaoKhoHang_Load(object sender, EventArgs e)
        {
            int i = 0;
            dgvKhoMain.DataSource = (from kho in db.KHOes.ToList()
                                     from mh in db.MATHANGs.ToList()
                                     where kho.MATHANGID == mh.MATHANGID
                                     select new
                                     {
                                         STT = ++i,
                                         ID = kho.ID,
                                         TenMH = mh.TENMH,
                                         SoLuong = kho.SOLUONG
                                     }).ToList();
        }
        #endregion

        #region sự kiện
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xls";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            string FileName = saveFileDialog1.FileName.ToString();
            try
            {
                dgvKhoMain.ExportToXls(FileName);
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
    }
}
