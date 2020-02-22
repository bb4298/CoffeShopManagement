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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceLoaiThucUong" in both code and config file together.
    [ServiceContract]
    public interface IServiceLoaiThucUong
    {
        [OperationContract]
        string layMaLoaiThucDon(string tenLoaiTD);
        [OperationContract]
        bool themLoaiThucDon(eLoaiThucUong ltd);
        [OperationContract]
        bool xoaLoaiThucDon(string maTD);
        [OperationContract]
        bool suaLoaiThucDon(eLoaiThucUong ltd, string maLTD);
    }
}
