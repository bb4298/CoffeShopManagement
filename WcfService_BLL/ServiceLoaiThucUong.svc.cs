using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using Entities;

namespace WcfService_BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLoaiThucUong" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceLoaiThucUong.svc or ServiceLoaiThucUong.svc.cs at the Solution Explorer and start debugging.
    public class ServiceLoaiThucUong : IServiceLoaiThucUong
    {
        QLCFDataContext db;
        public ServiceLoaiThucUong()
        {
            db = new QLCFDataContext();
        }
        public List<eLoaiThucUong> DanhSachLoai()
        {
            List<eLoaiThucUong> lst = new List<eLoaiThucUong>();
            foreach (var e in db.LoaiThucDons)
            {
                lst.Add(new eLoaiThucUong()
                {
                    TenLoaiThucUong = e.tenLoaiThucDon,
                    MaLoaiThucUong=e.maLoaiThucDon

                });
            }
            return lst;
        }
        public string layMaLoaiThucDon(string tenLoaiTD)
        {
            string maTD = (from a in db.LoaiThucDons
                           where a.tenLoaiThucDon == tenLoaiTD
                           select a.maLoaiThucDon).FirstOrDefault();
            return maTD;
        }

        public bool themLoaiThucDon(eLoaiThucUong ltd)
        {
            if (!DanhSachLoai().Contains(ltd))
            {
                LoaiThucDon ltd1 = new LoaiThucDon();
                ltd1.tenLoaiThucDon =ltd.TenLoaiThucUong;
                ltd1.maLoaiThucDon = ltd.MaLoaiThucUong;
                db.LoaiThucDons.InsertOnSubmit(ltd1);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaLoaiThucDon(string maTD)
        {

            eLoaiThucUong ltd = new eLoaiThucUong();
            if (ltd != null)
            {
                var q = db.LoaiThucDons.Single(a => a.maLoaiThucDon == maTD);
                db.LoaiThucDons.DeleteOnSubmit(q);
                db.SubmitChanges();
                return true;
            }
            return false;
        }


        public bool suaLoaiThucDon(eLoaiThucUong ltd, string maLTD)
        {
            LoaiThucDon ltd1 = new LoaiThucDon();
            ltd1 = db.LoaiThucDons.Where(a => a.maLoaiThucDon == maLTD).SingleOrDefault();
            if (ltd1 != null)
            {
                //ct1.maCongTrinh = ct.maCongTrinh;
                ltd1.tenLoaiThucDon = ltd.TenLoaiThucUong;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
