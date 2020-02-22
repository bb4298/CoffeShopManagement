using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eChiTietHoaDon
    {
        private int maChiTietHoaDon;
        private Nullable<int> maHoaDon;
        private string tenThucUong;
        private string maThucDon;
        private Nullable<int> soLuong;
        private string trangThai;
        private float donGia;
        private Nullable<decimal> thanhTien;

        [DataMember]
        public Nullable<int> MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        [DataMember]
        public string TenThucUong { get => tenThucUong; set => tenThucUong = value; }
        [DataMember]
        public Nullable<int> SoLuong { get => soLuong; set => soLuong = value; }
        [DataMember]
        public float DonGia { get => donGia; set => donGia = value; }
        [DataMember]
        public Nullable<decimal> ThanhTien { get => thanhTien; set => thanhTien = value; }
        [DataMember]
        public int MaChiTietHoaDon { get => maChiTietHoaDon; set => maChiTietHoaDon = value; }
        [DataMember]
        public string MaThucDon { get => maThucDon; set => maThucDon = value; }
        [DataMember]
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
