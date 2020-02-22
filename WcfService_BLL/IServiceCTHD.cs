using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_QF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChitiethoadon_BLL" in both code and config file together.
    [ServiceContract]
    public interface IChitiethoadon_BLL
    {
        [OperationContract]
        bool them_CTHD(eChiTietHoaDon cthd);
        [OperationContract]
        int layMa_CTHD_CaoNhat();
        [OperationContract]
        bool suaChiTietHoaDon(eChiTietHoaDon cthd, int maCTHD);
        [OperationContract]
        string tinhTongHoaDon(int maHoaDon);
        [OperationContract]
        bool kiemTraPhaChe(int maHD);
    }
}

