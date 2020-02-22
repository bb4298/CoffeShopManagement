using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_QF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Chitiethoadon_BLL" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Chitiethoadon_BLL.svc or Chitiethoadon_BLL.svc.cs at the Solution Explorer and start debugging.
    public class Chitiethoadon_BLL : IChitiethoadon_BLL
    {
        QLCFDataContext db;
        public Chitiethoadon_BLL()
        {
            db = new QLCFDataContext();
        }
        public List<eChiTietHoaDon> DanhSachCTHD()
        {
            List<eChiTietHoaDon> lst = new List<eChiTietHoaDon>();
            foreach (var e in db.ChiTietHoaDons)
            {
                lst.Add(new eChiTietHoaDon()
                {
                    MaHoaDon = e.maHoaDon,
                    MaChiTietHoaDon = e.maChiTietHoaDon,
                    MaThucDon = e.maThucDon,
                    SoLuong = e.soLuong,
                    ThanhTien = e.thanhTien,
                    TrangThai = e.trangThai

                });
            }
            return lst;
        }
        public bool them_CTHD(eChiTietHoaDon cthd)
        {
            if (!DanhSachCTHD().Contains(cthd))
            {
                ChiTietHoaDon nv1 = new ChiTietHoaDon();
                nv1.maHoaDon = cthd.MaHoaDon;
                nv1.maChiTietHoaDon = cthd.MaChiTietHoaDon;
                nv1.maThucDon = cthd.MaThucDon;
                nv1.soLuong = cthd.SoLuong;
                nv1.thanhTien = cthd.ThanhTien;
                nv1.trangThai = cthd.TrangThai;
                db.ChiTietHoaDons.InsertOnSubmit(nv1);
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
        public bool suaChiTietHoaDon(eChiTietHoaDon cthd, int maCTHD)
        {
            eChiTietHoaDon cthd1 = new eChiTietHoaDon();
            var q= db.ChiTietHoaDons.Where(a => a.maChiTietHoaDon == maCTHD).SingleOrDefault();
            if (cthd1 != null)
            {
                cthd1.TrangThai = q.trangThai;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
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
            var kt = (from a in db.ChiTietHoaDons
                      where a.maHoaDon == maHD && a.trangThai == "C"
                      select a
                      ).Count();
            if (kt >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

