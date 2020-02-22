using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using DAL;

namespace Wcf_QF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBan_BLL" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceBan_BLL.svc or ServiceBan_BLL.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBan_BLL : IServiceBan_BLL
    {
        QLCFDataContext db;
        public ServiceBan_BLL()
        {
            db = new QLCFDataContext();
        }

        public List<eBan> DanhSachBan()
        {
            List<eBan> lst = new List<eBan>();
            foreach (var e in db.Bans)
            {
                lst.Add(new eBan()
                {
                    MaBan = e.maBan,
                    TrangThai = e.trangThai,
                    Mahd = e.maHoaDon
                });
            }
            return lst;
        }


        public bool themBan(eBan ban)
        {
            if (!DanhSachBan().Contains(ban))
            {
                Ban b = new Ban() { maBan = ban.MaBan, trangThai = ban.TrangThai, maHoaDon = ban.Mahd };
                db.Bans.InsertOnSubmit(b);
                db.SubmitChanges();
            }
            return false;
        }
        public bool suaBan(eBan ban, int maBan)
        {
            Ban ban1 = new Ban();
            ban1 = db.Bans.Where(a => a.maBan == maBan).SingleOrDefault();
            if (ban1 != null)
            {
                //ct1.maCongTrinh = ct.maCongTrinh;
                //ban1.tenBan = ban.tenBan;               
                ban1.trangThai = ban.TrangThai;
                ban1.maHoaDon = ban.Mahd;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool xoaBan(int maBan)
        {

            Ban b = new Ban();
            if (b != null)
            {
                b = db.Bans.Single(a => a.maBan == maBan);
                db.Bans.DeleteOnSubmit(b);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public int layMaBanCaoCaoNhat()
        {
            int ma = (from a in db.Bans
                      orderby a.maBan descending
                      select a.maBan).FirstOrDefault();

            return ma;
        }
    }
}
