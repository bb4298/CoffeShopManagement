using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BanBLL
    {
        QLCFDataContext db;
        public BanBLL()
        {
            db = new QLCFDataContext();
        }
        public int laySoLuongBan()
        {
            int soBan = (db.Bans.Count());

            return soBan;
        }

        public bool themBan(Ban ban)
        {
            if (!db.Bans.Contains(ban))
            {
                db.Bans.InsertOnSubmit(ban);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        /*public int layTenBanCaoNhat()
        {
            int tenBanCN = (from a in db.Bans          
                           select a.tenBan.max).FirstOrDefault();
            return tenBanCN;
        }*/

        /*public string layMaBan(string maBan)
        {
            
            string maTD = (from a in db.Bans
                           where a.maBan.ToString() == maBan 
                           select a.maBan).FirstOrDefault();
            return maTD;
        }*/

        public bool suaBan(Ban ban, string maBan)
        {
            Ban ban1 = new Ban();
            ban1 = db.Bans.Where(a => a.maBan.ToString() == maBan).SingleOrDefault();
            if (ban1 != null)
            {
                //ct1.maCongTrinh = ct.maCongTrinh;
                //ban1.tenBan = ban.tenBan;               
                ban1.trangThai = ban.trangThai;
                ban1.maHoaDon = ban.maHoaDon;
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
