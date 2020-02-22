using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService_BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceDrink" in both code and config file together.
    [ServiceContract]
    public interface IServiceDrink
    {
        [OperationContract]
        bool themThucDon(eThucUong td);
        [OperationContract]
        decimal layGiaThucDon(string maThucDon);
        [OperationContract]
        string layMaThucDon(string tenTD);
        [OperationContract]
        bool suaThucDon(eThucUong td, string maTD);
        [OperationContract]
        bool xoaThucDon(string maTD);
    }
}
