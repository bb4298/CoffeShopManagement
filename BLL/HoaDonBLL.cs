using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class HoaDonBLL
    {
        QLCFDataContext db;
        public HoaDonBLL()
        {
            db = new QLCFDataContext();
        }
        public bool themHoaDon(HoaDon hd)
        {
            if (!db.HoaDons.Contains(hd))
            {
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaTongTienHoaDon(HoaDon hd, int maHD)
        {
            HoaDon hd1 = new HoaDon();
            hd1 = db.HoaDons.Where(a => a.maHoaDon == maHD).SingleOrDefault();
            if (hd1 != null)
            {
               // hd1.maHoaDon = hd.maHoaDon;
                hd1.tongTienThanhToan = hd.tongTienThanhToan;                
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaTrangThaiHoaDon(HoaDon hd, int maHD)
        {
            HoaDon hd1 = new HoaDon();
            hd1 = db.HoaDons.Where(a => a.maHoaDon == maHD).SingleOrDefault();
            if (hd1 != null)
            {
                // hd1.maHoaDon = hd.maHoaDon;
                hd1.trangThai = hd.trangThai;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public int layMaHoaDonCaoNhat()
        {
            int ma = (from a in db.HoaDons
                    orderby a.maHoaDon descending
                    select a.maHoaDon).FirstOrDefault();

            return ma;
        }

        public decimal tongTienHoaDon(int maHD)
        {
            decimal tongTien = (from a in db.HoaDons
                                where a.maHoaDon == maHD
                                select Convert.ToDecimal(a.tongTienThanhToan)
                                ).FirstOrDefault();
            return tongTien;
        }
        
        public int laySoDongHoaDon()
        {
            int soDong = (from a in db.HoaDons
                          select a.maHoaDon).Count();
            return soDong;
        }

        public decimal tongTienHoaDonTrongMotTG(DateTime nbd, DateTime nkt)
        {
            var tong = (from a in db.HoaDons
                            where a.ngayThanhToan >= nbd && a.ngayThanhToan <= nkt
                            select a.tongTienThanhToan
                            ).Sum();
            return Convert.ToDecimal(tong);
        }
    }
}
