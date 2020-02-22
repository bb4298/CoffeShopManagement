using System;
using DevExpress.Xpo;

namespace DAL
{

    public class DataKetNoi : XPObject
    {
       // string CS = "Data Source=DESKTOP-PTT6BR4\SQLEXPRESS;Initial Catalog=QuanLyCF;Integrated Security=True";
        public string chuoiKetNoi()
        {
            string cs = @"Data Source=HP\SQLEXPRESS;Initial Catalog=QuanLyCF;Integrated Security=True";
            return cs;
        }
    }

}