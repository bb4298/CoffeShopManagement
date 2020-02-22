using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eHoaDon
    {
        private int maHoaDon;
        private Nullable<DateTime> ngayThanhToan;
        private decimal tongTienThanhToan;
        private string trangThai;
        private Nullable<int> maBan;
        private string maNhanVien;
        [DataMember]
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        [DataMember]
        public Nullable<DateTime> NgayThanhToan { get => ngayThanhToan; set => ngayThanhToan = value; }
        [DataMember]
        public decimal TongTienThanhToan { get => tongTienThanhToan; set => tongTienThanhToan = value; }
        [DataMember]
        public string TrangThai { get => trangThai; set => trangThai = value; }
        [DataMember]
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        [DataMember]
        public Nullable<int> MaBan { get => maBan; set => maBan = value; }
    }
}
