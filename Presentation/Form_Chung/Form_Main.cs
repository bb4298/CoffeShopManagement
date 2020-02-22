using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BLL;
using Presentation.Form_Chung;
using Presentation.Form_QL;
using Presentation.Form_PC;

//using Presentation.Form_PC;

namespace Presentation
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public static int KiemTraBan = 0;
        #region Biến ngăn mở form nhiềun lần
        //form chung
        public static bool f_TTCN = true;
        public static bool f_DMK = true;
        //Form quản lý
        public static bool f_QL_QLTD = true;
        public static bool f_QL_QLLTD = true;
        public static bool f_QL_QLB = true;
        public static bool f_QL_QLNV = true;
        public static bool f_QL_QLHD = true;
        //Form nhân viên tiếp nhận
        public static bool f_TN_DatMon = true;
        //Form nhân viên pha chế
        public static bool f_PC_DSDH = true;
        #endregion

        NhanVienBLL nvbll;
        public FormMain()
        {
            InitializeComponent();
            nvbll = new NhanVienBLL();
            f_TTCN = true;
            f_DMK = true;
            f_QL_QLTD = true;
            f_QL_QLLTD = true;
            f_QL_QLB = true;
            f_QL_QLNV = true;
            f_QL_QLHD = true;
            //Form nhân viên tiếp nhận
            f_TN_DatMon = true;
            //Form nhân viên pha chế
            f_PC_DSDH = true;
    }

        #region Load form xem thông tin và đổi mật khẩu
        public void loadFormThongTin()
        {
            Form_ThongTinCaNhan form = new Form_ThongTinCaNhan();
            if (f_TTCN == true)
            {

                form.MdiParent = this;
                form.Show();

                f_TTCN = false;
            }

            else
            {
                form.Activate();
            }
        }

        public void loadFormDoiMatKhau()
        {
            Form_DoiMatKhau form = new Form_DoiMatKhau();
            if (f_DMK == true)
            {

                form.MdiParent = this;
                form.Show();

                f_DMK = false;
            }

            else
            {
                form.Activate();
            }
        }

        public void loadFormDatMon()
        {
            Form_TN_DatMon form = new Form_TN_DatMon();
            if (f_TN_DatMon == true)
            {

                form.MdiParent = this;
                form.Show();

                f_TN_DatMon = false;
            }

            else
            {
                form.Activate();
            }
        }
        
        #endregion

        #region Load form quản lý
        public void loadFormQLTD()
        {
            Form_QL_QuanLyThucDon form = new Form_QL_QuanLyThucDon();
            if (f_QL_QLTD == true)
            {

                form.MdiParent = this;
                form.Show();

                f_QL_QLTD = false;
            }

            else
            {
                form.Activate();
            }
        }

        public void loadFormQLLTD()
        {
            Form_QL_QuanLyLoaiTD form = new Form_QL_QuanLyLoaiTD();
            if (f_QL_QLLTD == true)
            {

                form.MdiParent = this;
                form.Show();

                f_QL_QLLTD = false;
            }

            else
            {
                form.Activate();
            }
        }

        
        public void loadFormQuanLyNhanVien()
        {
            Form_QL_QuanLyNhanVien form = new Form_QL_QuanLyNhanVien();
            if (f_QL_QLNV == true)
            {

                form.MdiParent = this;
                form.Show();

                f_QL_QLNV = false;
            }

            else
            {
                form.Activate();
            }
        }

        public void loadFormQuanLyHoaDon()
        {
            Form_QL_QuanLyHoaDon form = new Form_QL_QuanLyHoaDon();
            if (f_QL_QLHD == true)
            {

                form.MdiParent = this;
                form.Show();

                f_QL_QLHD = false;
            }

            else
            {
                form.Activate();
            }
        }
        #endregion

        #region Load form tiếp nhận
        public void loadFormQuanLyBan()
        {
            Form_QL_QuanLyBan form = new Form_QL_QuanLyBan();
            if (f_QL_QLB == true)
            {

                form.MdiParent = this;
                form.Show();

                f_QL_QLB = false;
            }

            else
            {
                form.Activate();
            }
        }
        #endregion

        #region Load form pha chế
        public void loadFormDanhSachDonHang()
        {
            Form_PC_DanhSachDonHang form = new Form_PC_DanhSachDonHang();
            if (f_PC_DSDH == true)
            {

                form.MdiParent = this;
                form.Show();

                f_PC_DSDH = false;
            }

            else
            {
                form.Activate();
            }
        }
        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
           try
           {
               NhanVien kt_ad = nvbll.kiemTraDangNhapAdmin(FormLogin._tenDN, FormLogin._MK_MaHoa);
               NhanVien kt_tn = nvbll.kiemTraDangNhapTiepNhan(FormLogin._tenDN, FormLogin._MK_MaHoa);
                NhanVien kt_pc = nvbll.kiemTraDangNhapPhaChe(FormLogin._tenDN, FormLogin._MK_MaHoa);
        
               if (kt_ad != null)
               {
                    rbPageTiepNhan.Dispose();
                    rbPagePhaChe.Dispose();
               }                                           
               else if (kt_tn != null)
               {
                    rbPagePhaChe.Dispose();
                    rbPageQuanLy.Dispose();
               }                            
               if (kt_pc != null)
               {
                    rbPageQuanLy.Dispose();
                    rbPageTiepNhan.Dispose();
               }
           }
           catch(Exception ex)
           {
                XtraMessageBox.Show("Lỗi "+ex);
           }
        }

        private void btnThongTin_QL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormThongTin();
        }

        private void btnDoiMK_QL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormDoiMatKhau();
        }

        private void btnThongTin_TN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormThongTin();
        }

        private void btnDoiMK_TN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormDoiMatKhau();
        }

        private void btnThongTin_PC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormThongTin();
        }

        private void btnDoiMK_PC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormDoiMatKhau();
        }

        private void btnDatMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormDatMon();
        }

        private void btnQuanLyThucDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormQLTD();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormQLLTD();
        }

        private void btnQuanLyBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormQuanLyBan();
        }

        private void btnQuanLyNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormQuanLyNhanVien();
        }

        private void btnDanhSachDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormDanhSachDonHang();
        }

        private void btnQuanLiHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadFormQuanLyHoaDon();
        }

        
    }
}