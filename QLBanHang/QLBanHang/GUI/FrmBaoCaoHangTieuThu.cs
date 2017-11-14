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
    public partial class FrmBaoCaoHangTieuThu : Form
    {
        private QUANLYHANGHOAEntities db = new QUANLYHANGHOAEntities();
        #region constructor
        public FrmBaoCaoHangTieuThu()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadDgvThongKe()
        {
            try
            {
                if (cbxThongKe.SelectedIndex == 0)
                {
                    /// nhập
                    dgvHangTieuThuMain.DataSource = db.CHITIETNHAPs.ToList().
                        Where(p => db.NHAPs.Where(nhap => nhap.NHAPID == p.NHAPID).First().NGAY >= dateBatDau.DateTime).
                        Where(p => db.NHAPs.Where(nhap => nhap.NHAPID == p.NHAPID).First().NGAY <= dateKetThuc.DateTime).
                        GroupBy(p => p.MATHANGID).Select(cl => new
                            {
                                MaMh = (int)cl.Select(p => p.MATHANGID).First().Value,
                                SoLuong = cl.Sum(p => p.SOLUONG)
                            })
                       .Select(p => new
                            {
                                MaMH = p.MaMh,
                                TenMH = db.MATHANGs.Where(p1 => p1.MATHANGID == p.MaMh).First().TENMH,
                                SoLuong = p.SoLuong
                            }
                        ).ToList();
                    return;
                }

                if (cbxThongKe.SelectedIndex == 1)
                {
                    /// xuất
                    dgvHangTieuThuMain.DataSource = db.CHITIETXUATs.ToList().
                        Where(p => db.XUATs.Where(xuat => xuat.XUATID == p.XUATID).First().NGAY >= dateBatDau.DateTime).
                        Where(p => db.XUATs.Where(xuat => xuat.XUATID == p.XUATID).First().NGAY <= dateKetThuc.DateTime).
                        GroupBy(p => p.MATHANGID).Select(cl => new
                        {
                            MaMh = (int)cl.Select(p => p.MATHANGID).First().Value,
                            SoLuong = cl.Sum(p => p.SOLUONG)
                        })
                       .Select(p => new
                       {
                           MaMH = p.MaMh,
                           TenMH = db.MATHANGs.Where(p1 => p1.MATHANGID == p.MaMh).First().TENMH,
                           SoLuong = p.SoLuong
                       }
                        ).ToList();
                    return;
                }
            }
            catch
            {
            }
        }
        private void FrmBaoCaoHangTieuThu_Load(object sender, EventArgs e)
        {
            cbxThongKe.SelectedIndex = 0;
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
            // lam sau
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xls";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            string FileName = saveFileDialog1.FileName.ToString();
            try
            {
                dgvHangTieuThu.ExportToXls(FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file cần ghi lại để quá trình ghi thành công");
            }
        }
        #endregion

        private void cbxThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
