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
namespace Presentation.Form_QL
{
    public partial class Form_QL_QuanLyHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public static int _soTrang = 1;
        public static int _tongTrang = 1;
        public static int _soTrangLe = 1;
        public int _maHoaDonDangChon;
        QLCFDataContext db;
        HoaDonBLL hdbll;
        ChiTietHoaDonBLL cthdbll;
        public Form_QL_QuanLyHoaDon()
        {
            InitializeComponent();
            
            loadDtpThangNay();
            db = new QLCFDataContext();
            hdbll = new HoaDonBLL();
            cthdbll = new ChiTietHoaDonBLL();
        }


        public void loadHoaDon()
        {
            dataGridView1.DataSource = (from a in db.HoaDons join b in db.NhanViens on a.maNhanVien equals b.maNhanVien
                                        where a.ngayThanhToan >= dtpBatDau.Value && a.ngayThanhToan <= dtpKetThuc.Value.AddDays(1)
                                       select new
                                       {
                                            a.maHoaDon,
                                            a.maBan,
                                            a.tongTienThanhToan,
                                            a.ngayThanhToan,
                                            b.tenNhanVien,
                                       }
                                       ).Skip(0).Take(10);
        } 
        public void loadDtpThangNay()
        {
            DateTime Today = DateTime.Now;
            dtpBatDau.Value = new DateTime(Today.Year, Today.Month, 1);
            dtpKetThuc.Value = dtpBatDau.Value.AddMonths(1).AddDays(-1);

        }

        private void dtpBatDau_ValueChanged(object sender, EventArgs e)
        {
           // loadHoaDon();
        }

        private void dtpKetThuc_ValueChanged(object sender, EventArgs e)
        {
            //loadHoaDon();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Form_QL_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            lbTTcthd.Text = null;
            loadHoaDon();

            lbTongDoanhThu.Text = hdbll.tongTienHoaDonTrongMotTG(dtpBatDau.Value,dtpKetThuc.Value).ToString("###,## VND");
            
        }

        private void Form_QL_QuanLyHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_QL_QLHD = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            loadHoaDon();
            lbTongDoanhThu.Text = hdbll.tongTienHoaDonTrongMotTG(dtpBatDau.Value, dtpKetThuc.Value).ToString("###,## VND");
        }

        private void btnTrangDau_Click(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void btnTrangCuoi_Click(object sender, EventArgs e)
        {
            int soDong = hdbll.laySoDongHoaDon();
            _soTrangLe = soDong % 10;
            _tongTrang = soDong / 10;
            if(_soTrangLe != 0)
            {
                _tongTrang += 1;
            }
            dataGridView1.DataSource = (from a in db.HoaDons
                                        join b in db.NhanViens on a.maNhanVien equals b.maNhanVien
                                        where a.ngayThanhToan >= dtpBatDau.Value && a.ngayThanhToan <= dtpKetThuc.Value.AddDays(1)
                                        select new
                                        {
                                            a.maHoaDon,
                                            a.maBan,
                                            a.tongTienThanhToan,
                                            a.ngayThanhToan,
                                            b.tenNhanVien,
                                        }
                                    ).Skip((_tongTrang - 1) * 10).Take(10);

        }

        public void loadHoaDonTheoTrang()
        {
            dataGridView1.DataSource = (from a in db.HoaDons
                                        join b in db.NhanViens on a.maNhanVien equals b.maNhanVien
                                        where a.ngayThanhToan >= dtpBatDau.Value && a.ngayThanhToan <= dtpKetThuc.Value.AddDays(1)
                                        select new
                                        {
                                            a.maHoaDon,
                                            a.maBan,
                                            a.tongTienThanhToan,
                                            a.ngayThanhToan,
                                            b.tenNhanVien,
                                        }
                                     ).Skip((_soTrang - 1) * 10).Take(10);
        }
        private void btnTrangSau_Click(object sender, EventArgs e)
        {
            _soTrang += 1;
            loadHoaDonTheoTrang();
            if (dataGridView1.DataSource == null)
            {
                _soTrang -= 1;
                loadHoaDonTheoTrang();
            }
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (_soTrang == 1)
            {
                _soTrang = 1;
            }
            else
            {
                _soTrang -= 1;
            }
            loadHoaDonTheoTrang();
        }
        public void loadChiTietHD(int _maHD)
        {
            dataGridView2.DataSource = (from a in db.ChiTietHoaDons join b in db.ThucDons on a.maThucDon equals b.maThucDon
                                        where a.maHoaDon == _maHD
                                        select new
                                        {
                                            b.tenThucDon,
                                            a.soLuong,
                                            b.donGia,
                                            a.thanhTien
                                        });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _maHoaDonDangChon = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            loadChiTietHD(_maHoaDonDangChon);
            lbTTcthd.Text = cthdbll.tongTienCuaMotCTHD(_maHoaDonDangChon).ToString("###,## VND");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _maHoaDonDangChon = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            loadChiTietHD(_maHoaDonDangChon);
            lbTTcthd.Text = cthdbll.tongTienCuaMotCTHD(_maHoaDonDangChon).ToString("###,## VND");
        }
    }
}