using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService_BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceNhanVIen" in both code and config file together.
    [ServiceContract]
    public interface IServiceNhanVIen
    {
        [OperationContract]
        eNhanVien kiemTraDangNhap(string tenDN, string MK);
        [OperationContract]
        eNhanVien kiemTraDangNhapAdmin(string tenDN, string MK);
        [OperationContract]
        eNhanVien kiemTraDangNhapTiepNhan(string tenDN, string MK);
        [OperationContract]
        eNhanVien kiemTraDangNhapPhaChe(string tenDN, string MK);
        [OperationContract]
        eNhanVien loadThongTinLenTB(string tenTK);
        [OperationContract]
        bool nghiViecVaLamLai(eNhanVien nv, string maNV);
        [OperationContract]
        bool themNhanVien(eNhanVien nv);
        [OperationContract]
        bool suaNhanVien2(eNhanVien nv, string maNV);
        [OperationContract]
        bool xoaNhanVien(string maNV);
        [OperationContract]
        string layMaNhanVien(string tenTK);
        [OperationContract]
        string layTenNhanVien(string tenTK);
    }
}
