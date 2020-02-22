using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BLL;
namespace Presentation.Form_PC
{
    public partial class Form_PC_DanhSachDonHang : DevExpress.XtraEditors.XtraForm
    {
        public int maCTHD;
        QLCFDataContext db;
        ChiTietHoaDon cthd1;
        ChiTietHoaDonBLL cthdbll;
        public Form_PC_DanhSachDonHang()
        {
            InitializeComponent();
            db = new QLCFDataContext();
            cthd1= new ChiTietHoaDon();
            cthdbll = new ChiTietHoaDonBLL();
        }

        public void loadData()
        {
            dataGridView1.DataSource = (from a in db.ChiTietHoaDons join b in db.HoaDons on a.maHoaDon equals b.maHoaDon
                                                                    join c in db.ThucDons on a.maThucDon equals c.maThucDon 
                                        where a.trangThai =="C"
                                        select new
                                        {
                                            a.maChiTietHoaDon,
                                            c.tenThucDon,
                                            a.soLuong,
                                            c.donGia,
                                            a.thanhTien,
                                            b.maBan
                                        });
        }


        private void Form_PC_DanhSachDonHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_PC_DSDH = true;
        }

        private void Form_PC_DanhSachDonHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            cthd1.trangThai = "R";
            if (cthd1.maChiTietHoaDon == null)
            {
                XtraMessageBox.Show("Vui lòng chọn thực đơn cần xác nhận !");
            }
            else
            {
              if(cthdbll.suaChiTietHoaDon(cthd1,maCTHD))
                {
                    XtraMessageBox.Show("Xác nhận thành công !");
                    loadData();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cthd1.maChiTietHoaDon = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            maCTHD = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cthd1.trangThai = "R";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cthd1.maChiTietHoaDon = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            maCTHD = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cthd1.trangThai = "R";
        }
    }
}