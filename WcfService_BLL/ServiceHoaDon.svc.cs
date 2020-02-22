using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService_BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceHoaDon" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceHoaDon.svc or ServiceHoaDon.svc.cs at the Solution Explorer and start debugging.
    public class ServiceHoaDon : IServiceHoaDon
    {
        QLCFDataContext db;
        public ServiceHoaDon()
        {
            db = new QLCFDataContext();
        }
        public List<eHoaDon> DanhSachHoadon()
        {
            List<eHoaDon> lst = new List<eHoaDon>();
            foreach (var e in db.HoaDons)
            {
                lst.Add(new eHoaDon()
                {
                    MaHoaDon = e.maHoaDon,
                    NgayThanhToan = e.ngayThanhToan,
                    TongTienThanhToan = e.tongTienThanhToan,
                    TrangThai = e.trangThai,
                    MaNhanVien = e.maNhanVien,
                    MaBan = e.maBan
                });
            }
            return lst;
        }
        public bool themHoaDon(eHoaDon hd)
        {
            if (!DanhSachHoadon().Contains(hd))
            {
                HoaDon hd1 = new HoaDon();
                hd1.maHoaDon = hd.MaHoaDon;
                hd1.ngayThanhToan = hd.NgayThanhToan;
                hd1.tongTienThanhToan = hd.TongTienThanhToan;
                hd1.trangThai = hd.TrangThai;
                hd1.maNhanVien = hd.MaNhanVien;
                hd1.maBan = hd.MaBan;
                db.HoaDons.InsertOnSubmit(hd1);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaTongTienHoaDon(eHoaDon hd, int maHD)
        {
            eHoaDon hd1 = new eHoaDon();
            var q = db.HoaDons.Where(a => a.maHoaDon == maHD).SingleOrDefault();
            if (hd1 != null)
            {
                // hd1.maHoaDon = hd.maHoaDon;
                hd1.TongTienThanhToan = q.tongTienThanhToan;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool suaTrangThaiHoaDon(eHoaDon hd, int maHD)
        {
            eHoaDon hd1 = new eHoaDon();
            var q = db.HoaDons.Where(a => a.maHoaDon == maHD).SingleOrDefault();
            if (hd1 != null)
            {
                // hd1.maHoaDon = hd.maHoaDon;
                hd1.TrangThai = q.trangThai;
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
