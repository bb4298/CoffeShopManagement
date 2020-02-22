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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceNhanVIen" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceNhanVIen.svc or ServiceNhanVIen.svc.cs at the Solution Explorer and start debugging.
    public class ServiceNhanVIen : IServiceNhanVIen
    {
        QLCFDataContext db;
        public ServiceNhanVIen()
        {
            db = new QLCFDataContext();
        }
        public List<eNhanVien> DanhSachNhanVien()
        {
            List<eNhanVien> lst = new List<eNhanVien>();
            foreach (var e in db.NhanViens)
            {
                lst.Add(new eNhanVien()
                {
                    MaNhanVien = e.maNhanVien,
                    TenNhanVien = e.tenNhanVien,
                    LoaiNhanVien = e.loaiNhanVien,
                    NgaySinh = e.ngaySinh,
                    SoDienThoai = e.soDienThoai,
                    Trangthai = e.trangThai,
                    DiaChi = e.diaChi,
                    Gioitinh = e.gioiTinh
                });
            }
            return lst;
        }

        public eNhanVien kiemTraDangNhap(string tenDN, string MK)
        {
            eNhanVien env = new eNhanVien();
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK
                      select a).FirstOrDefault();
            env.MaNhanVien = nv.maNhanVien;
            return env;
        }
        public eNhanVien kiemTraDangNhapAdmin(string tenDN, string MK)
        {
            // var nv = db.NhanViens.Where(x=> x.maNhanVien == tenDn && x.matKhau == mk && x.loaiNhanVien == "AD").FirstOrDefault();
            eNhanVien env = new eNhanVien();
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK && a.loaiNhanVien == "AD"
                      select a).FirstOrDefault();
            env.MaNhanVien = nv.maNhanVien;
            return env;

        }
        public eNhanVien kiemTraDangNhapTiepNhan(string tenDN, string MK)
        {
            eNhanVien env = new eNhanVien();
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK && a.loaiNhanVien == "TN"
                      select a).FirstOrDefault();
            env.MaNhanVien = nv.maNhanVien;
            return env;

        }

        public eNhanVien kiemTraDangNhapPhaChe(string tenDN, string MK)
        {
            eNhanVien env = new eNhanVien();
            var nv = (from a in db.NhanViens
                      join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                      where b.tenTaiKhoan == tenDN && b.matKhau == MK && a.loaiNhanVien == "PC"
                      select a).FirstOrDefault();
            env.MaNhanVien = nv.maNhanVien;
            return env;
        }
        public eNhanVien loadThongTinLenTB(string tenTK)
        {
            eNhanVien env1 = new eNhanVien();
            TaiKhoan tk = db.TaiKhoans.Single(x => x.tenTaiKhoan == tenTK);
            NhanVien env = db.NhanViens.Single(x => x.maNhanVien == tk.maNhanVien);
            env1.MaNhanVien = env.maNhanVien;
            env1.TenNhanVien = env.tenNhanVien;
            env1.SoDienThoai = env.soDienThoai;
            env1.LoaiNhanVien = env.loaiNhanVien;
            env1.NgaySinh = env.ngaySinh;
            return env1;
        }
        public bool nghiViecVaLamLai(eNhanVien nv, string maNV)
        {
            eNhanVien nv1 = new eNhanVien();
            var q = db.NhanViens.Where(a => a.maNhanVien == maNV).SingleOrDefault();
            if (nv1 != null)
            {
                // nv1.maNhanVien = nv.maNhanVien;
                nv1.TenNhanVien = q.tenNhanVien;
                nv1.NgaySinh = nv.NgaySinh;
                nv1.LoaiNhanVien = nv.LoaiNhanVien;
                nv1.Trangthai = nv.Trangthai;
                nv1.Gioitinh = nv.Gioitinh;
                nv1.DiaChi = nv.DiaChi;
                nv1.SoDienThoai = nv.SoDienThoai;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool themNhanVien(eNhanVien nv)
        {

            if (!DanhSachNhanVien().Contains(nv))
            {
                NhanVien nv1 = new NhanVien();
                nv1.maNhanVien = nv.MaNhanVien;
                nv1.tenNhanVien = nv.TenNhanVien;
                nv1.loaiNhanVien = nv.LoaiNhanVien;
                nv1.ngaySinh = nv.NgaySinh;
                nv1.diaChi = nv.DiaChi;
                nv1.soDienThoai = nv.SoDienThoai;
                nv1.trangThai = nv.Trangthai;
                nv1.gioiTinh = nv.Gioitinh;
                db.NhanViens.InsertOnSubmit(nv1);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool suaNhanVien2(eNhanVien nv, string maNV)
        {
            eNhanVien nv1 = new eNhanVien();
            var q = db.NhanViens.Where(a => a.maNhanVien == maNV).SingleOrDefault();
            if (nv1 != null)
            {
                nv1.MaNhanVien = q.maNhanVien;
                nv1.TenNhanVien = q.tenNhanVien;
                nv1.NgaySinh = q.ngaySinh;
                nv1.LoaiNhanVien = q.loaiNhanVien;
                // nv1.trangThai = nv.trangThai;
                nv1.Gioitinh = q.gioiTinh;
                nv1.DiaChi = q.diaChi;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool xoaNhanVien(string maNV)
        {

            eNhanVien nv1 = new eNhanVien();
            if (nv1 != null)
            {
                var q = db.NhanViens.Single(a => a.maNhanVien == maNV);
                db.NhanViens.DeleteOnSubmit(q);
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
