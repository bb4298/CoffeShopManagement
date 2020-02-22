using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        QLCFDataContext db;
        public ChiTietHoaDonBLL()
        {
            db = new QLCFDataContext();
        }
        public bool them_CTHD(ChiTietHoaDon cthd)
        {
            if (!db.ChiTietHoaDons.Contains(cthd))
            {
                db.ChiTietHoaDons.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public int layMa_CTHD_CaoNhat()
        {
            int ma = (from a in db.ChiTietHoaDons
                      orderby a.maChiTietHoaDon descending
                      select a.maChiTietHoaDon).FirstOrDefault();

            return ma;
        }

        public bool suaChiTietHoaDon(ChiTietHoaDon cthd, int maCTHD)
        {
            ChiTietHoaDon cthd1 = new ChiTietHoaDon();
            cthd1 = db.ChiTietHoaDons.Where(a => a.maChiTietHoaDon == maCTHD).SingleOrDefault();
            if (cthd1 != null)
            {
                // hd1.maHoaDon = hd.maHoaDon;
                cthd1.trangThai = cthd.trangThai;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*public decimal tinhTongHoaDon(int maHoaDon)
        {
            decimal tong = (from a in db.ChiTietHoaDons
                            where a.maHoaDon == maHoaDon
                            select Convert.ToDecimal(a.thanhTien)
                            ).Sum();
            if (tong != null)
            {
                return tong;
            }
            else
            {
                return 0;
            }
        }*/

        public string tinhTongHoaDon(int maHoaDon)
        {
            var count = (from a in db.ChiTietHoaDons
                            where a.maHoaDon == maHoaDon
                            select a).FirstOrDefault();

            if (count != null)
            {
                Decimal tong = (from a in db.ChiTietHoaDons
                                where a.maHoaDon == maHoaDon
                                select Convert.ToDecimal(a.thanhTien)
                                ).Sum();
                return tong.ToString();
            }
            else
            {
                return "0";
            }
        }

        public bool kiemTraPhaChe(int maHD)
        {
            int kt = (from a in db.ChiTietHoaDons
                      where a.maHoaDon == maHD && a.trangThai == "C"
                      select a
                      ).Count();
            if (kt >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public decimal tongTienCuaMotCTHD( int _maHD)
        {
            var tong = (from a in db.ChiTietHoaDons
                        where a.maHoaDon == _maHD
                        select a.thanhTien
                ).Sum();
            return Convert.ToDecimal(tong);
        }
    }
}
