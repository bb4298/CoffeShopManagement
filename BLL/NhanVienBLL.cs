using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class NhanVienBLL
    {
        QLCFDataContext db;
        public NhanVienBLL()
        {
            db = new QLCFDataContext();
        }
        #region Kiểm tra đăng nhập
        public NhanVien kiemTraDangNhap(string tenDN, string MK)
        {
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK
                      select a).FirstOrDefault();

            return nv;
        }

        public NhanVien kiemTraDangNhapAdmin(string tenDN, string MK)
        {
            // var nv = db.NhanViens.Where(x=> x.maNhanVien == tenDn && x.matKhau == mk && x.loaiNhanVien == "AD").FirstOrDefault();
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK && a.loaiNhanVien == "AD"
                      select a).FirstOrDefault();

            return nv;

        }

        public NhanVien kiemTraDangNhapTiepNhan(string tenDN, string MK)
        {
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK && a.loaiNhanVien == "TN"
                      select a).FirstOrDefault();
            return nv;

        }

        public NhanVien kiemTraDangNhapPhaChe(string tenDN, string MK)
        {
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK && a.loaiNhanVien == "PC"
                      select a).FirstOrDefault();
            return nv;

        }
        #endregion

        public List<NhanVien> DanhSachNhanVien()
        {
            return db.NhanViens.ToList();
        }

        #region Load data lên tb
        public NhanVien loadThongTinLenTB(string tenTK)
        {
            TaiKhoan tk = db.TaiKhoans.Single(x => x.tenTaiKhoan == tenTK);
            NhanVien env = db.NhanViens.Single(x => x.maNhanVien == tk.maNhanVien);
            return env;
        }
        #endregion

        public bool nghiViecVaLamLai(NhanVien nv, string maNV)
        {
            NhanVien nv1 = new NhanVien();
            nv1 = db.NhanViens.Where(a => a.maNhanVien == maNV).SingleOrDefault();
            if (nv1 != null)
            {
                // nv1.maNhanVien = nv.maNhanVien;
                nv1.tenNhanVien = nv.tenNhanVien;
                nv1.ngaySinh = nv.ngaySinh;
                nv1.loaiNhanVien = nv.loaiNhanVien;
                nv1.trangThai = nv.trangThai;
                nv1.gioiTinh = nv.gioiTinh;
                nv1.diaChi = nv.diaChi;
                nv1.soDienThoai = nv.soDienThoai;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool themNhanVien(NhanVien nv)
        {
            if (!db.NhanViens.Contains(nv))
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaNhanVien2(NhanVien nv, string maNV)
        {
            NhanVien nv1 = new NhanVien();
            nv1 = db.NhanViens.Where(a => a.maNhanVien == maNV).SingleOrDefault();
            if (nv1 != null)
            {
                nv1.maNhanVien = nv.maNhanVien;
                nv1.tenNhanVien = nv.tenNhanVien;
                nv1.ngaySinh = nv.ngaySinh;
                nv1.loaiNhanVien = nv.loaiNhanVien;
                // nv1.trangThai = nv.trangThai;
                nv1.gioiTinh = nv.gioiTinh;
                nv1.diaChi = nv.diaChi;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool xoaNhanVien(string maNV)
        {

            NhanVien nv1 = new NhanVien();
            if (nv1 != null)
            {
                nv1 = db.NhanViens.Single(a => a.maNhanVien == maNV);
                db.NhanViens.DeleteOnSubmit(nv1);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public string layMaNhanVien(string tenTK)
        {
            string maNV = (from a in db.NhanViens
                           join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                           where b.tenTaiKhoan == tenTK
                           select a.maNhanVien).FirstOrDefault();
            return maNV;
        }

        public string layTenNhanVien(string tenTK)
        {
            string maNV = (from a in db.NhanViens
                           join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                           where b.tenTaiKhoan == tenTK
                           select a.tenNhanVien).FirstOrDefault();
            return maNV;
        }

    }

}


