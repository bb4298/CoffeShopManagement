using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    
    public class ThucDonBLL
    {
        QLCFDataContext db; 
        public ThucDonBLL()
        {
            db = new QLCFDataContext();
        }
        
        
        public bool themThucDon(ThucDon td)
        {
            if (!db.ThucDons.Contains(td))
            {
                db.ThucDons.InsertOnSubmit(td);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public decimal layGiaThucDon(string maThucDon)
        {
            decimal gia = (from a in db.ThucDons
                          where a.maThucDon == maThucDon
                          select Convert.ToDecimal( a.donGia)).FirstOrDefault();
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

        public bool suaThucDon(ThucDon td, string maTD)
        {
            ThucDon ct1 = new ThucDon();
            ct1 = db.ThucDons.Where(a => a.maThucDon == maTD).SingleOrDefault();
            if (ct1 != null)
            {
                //ct1.maCongTrinh = ct.maCongTrinh;
                ct1.tenThucDon = td.tenThucDon;
                ct1.donViTinh = td.donViTinh;
                ct1.donGia = td.donGia;
                ct1.maLoaiThucDon = td.maLoaiThucDon;
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
