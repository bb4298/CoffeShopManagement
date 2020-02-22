using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        QLCFDataContext db;
        public TaiKhoanBLL()
        {
            db = new QLCFDataContext();
        }
        public bool themTaiKhoan(TaiKhoan tk)
        {
            if (!db.TaiKhoans.Contains(tk))
            {
                db.TaiKhoans.InsertOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

    }
}
