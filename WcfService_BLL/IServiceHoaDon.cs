using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService_BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceHoaDon" in both code and config file together.
    [ServiceContract]
    public interface IServiceHoaDon
    {
        [OperationContract]
        bool themHoaDon(eHoaDon hd);
        [OperationContract]
        bool suaTongTienHoaDon(eHoaDon hd, int maHD);
        [OperationContract]
        bool suaTrangThaiHoaDon(eHoaDon hd, int maHD);
        [OperationContract]
        decimal tongTienHoaDon(int maHD);
        [OperationContract]
        int laySoDongHoaDon();
        [OperationContract]
        decimal tongTienHoaDonTrongMotTG(DateTime nbd, DateTime nkt);
    }
}
