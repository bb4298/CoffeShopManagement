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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDrink" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDrink.svc or ServiceDrink.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDrink : IServiceDrink
    {
        QLCFDataContext db;
        public ServiceDrink()
        {
            db = new QLCFDataContext();
        }
        public List<eThucUong> DanhSachDrink()
        {
            List<eThucUong> lst = new List<eThucUong>();
            foreach (var e in db.ThucDons)
            {
                lst.Add(new eThucUong()
                {
                    TenThucUong=e.tenThucDon,
                    DonGia=e.donGia,
                    DonViTinh=e.donViTinh,
                    MaThucUong=e.maThucDon

                });
            }
            return lst;
        }
        public bool themThucDon(eThucUong td)
        {
            if (!DanhSachDrink().Contains(td))
            {
                ThucDon td1 = new ThucDon();
                td1.tenThucDon = td.TenThucUong;
                td1.maThucDon = td.MaThucUong;
                td1.donGia = td.DonGia;
                td1.donViTinh = td.DonViTinh;
                db.ThucDons.InsertOnSubmit(td1);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public decimal layGiaThucDon(string maThucDon)
        {
            decimal gia = (from a in db.ThucDons
                           where a.maThucDon == maThucDon
                           select Convert.ToDecimal(a.donGia)).FirstOrDefault();
            //select a.donGia).FirstOrDefault();
            return gia;
        }

        public string layMaThucDon(string tenTD)
        {
            string maTD = (from a in db.ThucDons
                           where a.tenThucDon == tenTD
                           select a.maThucDon).FirstOrDefault();
            return maTD;
        }

        public bool suaThucDon(eThucUong td, string maTD)
        {
            ThucDon ct1 = new ThucDon();
            ct1 = db.ThucDons.Where(a => a.maThucDon == maTD).SingleOrDefault();
            if (ct1 != null)
            {
                //ct1.maCongTrinh = ct.maCongTrinh;
                ct1.tenThucDon = td.TenThucUong;
                ct1.donViTinh = td.DonViTinh;
                ct1.donGia = td.DonGia;
                ct1.maLoaiThucDon = td.MaLoaiThucDon;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool xoaThucDon(string maTD)
        {

            ThucDon td = new ThucDon();
            if (td != null)
            {
                td = db.ThucDons.Single(a => a.maThucDon == maTD);
                db.ThucDons.DeleteOnSubmit(td);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
