using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LoaiThucDonBLL
    {
        QLCFDataContext db;
        public LoaiThucDonBLL()
        {
            db = new QLCFDataContext();
        }


        public string layMaLoaiThucDon(string tenLoaiTD)
        {
            string maTD = (from a in db.LoaiThucDons
                           where a.tenLoaiThucDon == tenLoaiTD
                           select a.maLoaiThucDon).FirstOrDefault();
            return maTD;
        }

        public bool themLoaiThucDon(LoaiThucDon ltd)
        {
            if (!db.LoaiThucDons.Contains(ltd))
            {
                db.LoaiThucDons.InsertOnSubmit(ltd);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaLoaiThucDon(string maTD)
        {

            LoaiThucDon ltd = new LoaiThucDon();
            if (ltd != null)
            {
                ltd = db.LoaiThucDons.Single(a => a.maLoaiThucDon == maTD);
                db.LoaiThucDons.DeleteOnSubmit(ltd);
                db.SubmitChanges();
                return true;
            }
            return false;
        }


        public bool suaLoaiThucDon(LoaiThucDon ltd, string maLTD)
        {
            LoaiThucDon ltd1 = new LoaiThucDon();
            ltd1 = db.LoaiThucDons.Where(a => a.maLoaiThucDon == maLTD).SingleOrDefault();
            if (ltd1 != null)
            {
                //ct1.maCongTrinh = ct.maCongTrinh;
                ltd1.tenLoaiThucDon = ltd.tenLoaiThucDon;              
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
