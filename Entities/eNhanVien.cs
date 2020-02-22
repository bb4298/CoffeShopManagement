using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eNhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string loaiNhanVien;
        private Nullable<DateTime> ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string trangthai;
        private string gioitinh;
        [DataMember]
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        [DataMember]
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        [DataMember]
        public string LoaiNhanVien { get => loaiNhanVien; set => loaiNhanVien = value; }
        [DataMember]
        public Nullable<DateTime> NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        [DataMember]
        public string DiaChi { get => diaChi; set => diaChi = value; }
        [DataMember]
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        [DataMember]
        public string Trangthai { get => trangthai; set => trangthai = value; }
        [DataMember]
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
    }
}
