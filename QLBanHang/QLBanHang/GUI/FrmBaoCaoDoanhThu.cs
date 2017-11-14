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
    public partial class FrmBaoCaoDoanhThu : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        #region constructor
        public FrmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvThongKe()
        {
            Int64 sum = 0;
            int i = 0;
            var query = db.CHITIETXUATs.ToList().
                        Where(p => db.XUATs.Where(xuat => xuat.XUATID == p.XUATID).First().NGAY >= dateBatDau.DateTime).
                        Where(p => db.XUATs.Where(xuat => xuat.XUATID == p.XUATID).First().NGAY <= dateKetThuc.DateTime).
                        Select(p => new
                        {
                            Ngay = ((DateTime)db.XUATs.Where(p1=>p1.XUATID == p.XUATID).First().NGAY).ToString("dd/MM/yyyy"),
                            STT = 0,
                            MaMh = (int)p.MATHANGID,
                            TenMH = (string) db.MATHANGs.Where(p1=>p1.MATHANGID == p.MATHANGID).First().TENMH,
                            SoLuong = p.SOLUONG,
                            DonGia = p.GIABAN,
                            ThanhTien = p.SOLUONG * p.GIABAN
                        });

            sum = query.ToList().Sum(p => p.ThanhTien).Value;

            dgvDoanhThuMain.DataSource =
                                        query.ToList().Select(p => new
                                        {
                                            Ngay = p.Ngay,
                                            STT = ++i,
                                            TenMH = p.TenMH,
                                            SoLuong = p.SoLuong,
                                            DonGia = p.DonGia,
                                            ThanhTien = p.ThanhTien
                                        }).ToList();

            txtTongThu.Text = sum.ToString();
        }
        private void FrmBaoCaoHangTieuThu_Load(object sender, EventArgs e)
        {
            LoadDgvThongKe();         
        }
        #endregion

        #region sự kiện
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDgvThongKe();
        }
        

        private void btnDongChucNang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            /// lam sau
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xls";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            string FileName = saveFileDialog1.FileName.ToString();
            try
            {
                dgvDoanhThu.ExportToXls(FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file cần ghi lại để quá trình ghi thành công");
            }
        }
        #endregion
    }
}
