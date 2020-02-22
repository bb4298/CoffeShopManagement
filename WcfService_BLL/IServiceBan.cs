using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_QF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceBan_BLL" in both code and config file together.
    [ServiceContract]
    public interface IServiceBan_BLL
    {
        [OperationContract]
        bool themBan(eBan ban);
        [OperationContract]
        List<eBan> DanhSachBan();
        [OperationContract]
        bool suaBan(eBan ban, int maBan);
        [OperationContract]
        bool xoaBan(int maBan);
        [OperationContract]
        int layMaBanCaoCaoNhat();
    }
}
