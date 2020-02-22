using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eThucUong
    {
        private string maThucUong;
        private string tenThucUong;
        private string donViTinh;
        private Nullable<decimal> donGia;
        private string maLoaiThucDon;
        [DataMember]
        public string MaThucUong { get => maThucUong; set => maThucUong = value; }
        [DataMember]
        public string TenThucUong { get => tenThucUong; set => tenThucUong = value; }
        [DataMember]
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        [DataMember]
        public Nullable<decimal> DonGia { get => donGia; set => donGia = value; }
        [DataMember]
        public string MaLoaiThucDon { get => maLoaiThucDon; set => maLoaiThucDon = value; }
    }
}
