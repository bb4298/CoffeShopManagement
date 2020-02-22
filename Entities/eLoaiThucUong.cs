using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eLoaiThucUong
    {
        private string maLoaiThucUong;
        private string tenLoaiThucUong;
        [DataMember]
        public string MaLoaiThucUong { get => maLoaiThucUong; set => maLoaiThucUong = value; }
        [DataMember]
        public string TenLoaiThucUong { get => tenLoaiThucUong; set => tenLoaiThucUong = value; } 
    }
}
