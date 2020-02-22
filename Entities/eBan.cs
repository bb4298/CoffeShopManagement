using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eBan
    {
        private int maBan;
        private string trangThai;
        private Nullable<int> mahd;
        [DataMember]
        public int MaBan { get => maBan; set => maBan = value; }
        [DataMember]
        public string TrangThai { get => trangThai; set => trangThai = value; }
        [DataMember]
        public Nullable<int> Mahd { get => mahd; set => mahd = value; }
    }
}
