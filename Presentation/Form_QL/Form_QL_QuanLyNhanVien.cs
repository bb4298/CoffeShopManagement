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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Presentation.Form_QL
{
    public partial class Form_QL_QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public int _key = 0;
        public string _maNhanVien;
        public string _maTuTang;
        QLCFDataContext db;
        NhanVienBLL nvbll;
        TaiKhoanBLL tkbll;
        public Form_QL_QuanLyNhanVien()
        {
            InitializeComponent();
            db = new QLCFDataContext();
            nvbll = new NhanVienBLL();
            tkbll = new TaiKhoanBLL();
        }

        public void loadDsNhanVienDangLamLenDtgv()
        {
            dataGridView1.DataSource = (from a in db.NhanViens join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                                        where a.trangThai == "L" && b.tenTaiKhoan != FormLogin._tenDN
                                        select new
                                        {
                                            a.maNhanVien,
                                            a.tenNhanVien,
                                            a.ngaySinh,
                                            a.gioiTinh,
                                            a.diaChi,
                                            a.soDienThoai,
                                            a.loaiNhanVien
                                        });
        }

        public void loadDsNhanVienDaNghiLenDtgv()
        {
            dataGridView1.DataSource = (from a in db.NhanViens
                                        join b in db.TaiKhoans on a.maNhanVien equals b.maNhanVien
                                        where a.trangThai == "N" && b.tenTaiKhoan != FormLogin._tenDN
                                        select new
                                        {
                                            a.maNhanVien,
                                            a.tenNhanVien,
                                            a.ngaySinh,
                                            a.gioiTinh,
                                            a.diaChi,
                                            a.soDienThoai,
                                            a.loaiNhanVien
                                        });
        }

        public void loadDataLenTB()
        {
            tbMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            tbTenNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            dtpNgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbbGioiTinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbDiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbSoDienThoai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbbLoaiNhanVien.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private string loadMaNV()
        {
//            //#region Lấy mã NV bằng Connection String 
//            SqlConnection myCon = new SqlConnection();
//            myCon.ConnectionString = @"Data Source=DESKTOP-PTT6BR4\SQLEXPRESS;Initial Catalog=QuanLyCF;Integrated Security=True";
//            myCon.Open();//không có dòng này thì adapter sẽ tự open

//            string sqlMaPB = @"select top(1) *
//                               from dbo.NhanVien
//                               order by maNhanVien desc";


//            SqlDataAdapter myAdapter = new SqlDataAdapter(sqlMaPB, myCon);
//            DataTable myTable = new DataTable();
//            myAdapter.Fill(myTable);
//            _maTuTang = myTable.Rows[0]["maNhanVien"].ToString().Trim();
//#endregion
            return new NhanVienBLL().DanhSachNhanVien().Max(x => x.maNhanVien.Substring(2));
        }

        // Hàm tăng mã nhân viên khi add thêm NV
        private string NextID(string maTuTang, string prefixID)
        {
            if (maTuTang == "")
            {
                return prefixID + "0001";  // fixwidth default
            }
            int nextID = int.Parse(loadMaNV()) + 1;
            //int lengthNumerID = maTuTang.Length - prefixID.Length;
            //string zeroNumber = "";
            //for (int i = 1; i <= lengthNumerID; i++)
            //{
            //    if (nextID < Math.Pow(10, i))
            //    {
            //        for (int j = 1; j <= lengthNumerID - i; i++)
            //        {
            //            zeroNumber += "0";
            //        }
            //        return prefixID + zeroNumber + nextID.ToString();
            //    }
            //}
            return prefixID + nextID;

        }

        private void voHieuTB()
        {
            tbMaNV.Enabled = false;
            tbTenNV.Enabled = false;
            dtpNgaySinh.Enabled = false;
            // cbbLoaiNV.Enabled = false;
            cbbGioiTinh.Enabled = false;
            tbDiaChi.Enabled = false;
            tbSoDienThoai.Enabled = false;
            cbbLoaiNhanVien.Enabled = false;
        }
        private void kichHoatTB()
        {
            tbMaNV.Enabled = true;
            tbTenNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            //  cbbLoaiNV.Enabled = true;
            tbDiaChi.Enabled = true;
            cbbGioiTinh.Enabled = true;
            tbSoDienThoai.Enabled = true;
            cbbLoaiNhanVien.Enabled = true;
        }

        private void xoaAllTB()
        {
            tbMaNV.Text = null;
            tbTenNV.Text = null;
            dtpNgaySinh.Text = null;
            cbbGioiTinh.Text = null;
            tbDiaChi.Text = null;
            tbSoDienThoai.Text = null;
            cbbLoaiNhanVien.Text = null;
            // cbbLoaiNV.Text = null;
        }

        private void Form_QL_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            btnDSNhanVienLam.Enabled = false;
            loadDsNhanVienDangLamLenDtgv();
            pnTK.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnDSNhanVienLam.Enabled = false;
            loadDataLenTB();
            btnSua.Enabled = true;
            btnNghiViec.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            loadDataLenTB();
            btnNghiViec.Enabled = true;
        }

        private void Form_QL_QuanLyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_QL_QLNV = true;
        }

        private void btnDSNhanVienLam_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            loadDsNhanVienDangLamLenDtgv();
            btnDSNhanVienLam.Enabled = false;
            btnDSNhanVienNghi.Enabled = true;
            btnNghiViec.Text = "Nghỉ việc";
        }

        private void btnDSNhanVienNghi_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            loadDsNhanVienDaNghiLenDtgv();
            btnDSNhanVienLam.Enabled = true;
            btnDSNhanVienNghi.Enabled = false;
            btnNghiViec.Text = "Làm lại";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnNghiViec_Click(object sender, EventArgs e)
        {
            if (btnNghiViec.Text == "Nghỉ việc")
            {
                #region Cho nghỉ việc
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn cho nhân viên này nghỉ việc không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        _maNhanVien = tbMaNV.Text.Trim();
                        NhanVien nv1 = new NhanVien();
                        // nv1 = db.NhanViens.Where(a => a.maNhanVien == tbMaNV.Text).SingleOrDefault();
                        nv1.maNhanVien = tbMaNV.Text;
                        nv1.tenNhanVien = tbTenNV.Text;
                        nv1.ngaySinh = dtpNgaySinh.Value;
                        //nv1.loaiNhanVien = cbbLoaiNV.Text;
                        nv1.loaiNhanVien = cbbLoaiNhanVien.Text;
                        nv1.trangThai = "N";
                        nv1.gioiTinh = cbbGioiTinh.Text;
                        nv1.diaChi = tbDiaChi.Text;
                        nv1.soDienThoai = tbSoDienThoai.Text;

                        // db.SubmitChanges();
                        if (nvbll.nghiViecVaLamLai(nv1, _maNhanVien))
                        {
                            XtraMessageBox.Show("Đã cho nhân viên nghỉ việc !");
                            voHieuTB();
                            xoaAllTB();
                            btnThem.Enabled = true;
                            loadDsNhanVienDangLamLenDtgv();

                        }
                        else
                        {
                            XtraMessageBox.Show("Bị trùng mã nhân viên, vui lòng nhập mã khác !");
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi: " + ex);
                    }
                    btnSua.Enabled = false;
                    btnNghiViec.Enabled = false;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                }

                #endregion
            }
            if (btnNghiViec.Text == "Làm lại")
            {
                #region Cho làm lại
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn cho nhân viên này đi làm lại không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbMaNV.Text == "" || tbTenNV.Text == "" || cbbGioiTinh.Text == "" || tbDiaChi.Text == "" || tbSoDienThoai.Text == "")
                        {

                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                            btnLuu.Enabled = true;
                            btnHuy.Enabled = true;
                        }
                        else
                        {
                            _maNhanVien = tbMaNV.Text.Trim();
                            NhanVien nv1 = new NhanVien();
                            // nv1 = db.NhanViens.Where(a => a.maNhanVien == tbMaNV.Text).SingleOrDefault();
                            nv1.maNhanVien = tbMaNV.Text;
                            nv1.tenNhanVien = tbTenNV.Text;
                            nv1.ngaySinh = dtpNgaySinh.Value;
                            //nv1.loaiNhanVien = cbbLoaiNV.Text;
                            nv1.loaiNhanVien = cbbLoaiNhanVien.Text;
                            nv1.trangThai = "L";
                            nv1.gioiTinh = cbbGioiTinh.Text;
                            nv1.diaChi = tbDiaChi.Text;
                            nv1.soDienThoai = tbSoDienThoai.Text;

                            // db.SubmitChanges();
                            if (nvbll.nghiViecVaLamLai(nv1, _maNhanVien))
                            {
                                XtraMessageBox.Show("Đã cho nhân đi làm lại !");
                                voHieuTB();
                                xoaAllTB();
                                btnThem.Enabled = true;
                                loadDsNhanVienDaNghiLenDtgv();

                            }
                            else
                            {
                                XtraMessageBox.Show("Bị trùng mã nhân viên, vui lòng nhập mã khác !");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi: " + ex);
                    }
                    btnSua.Enabled = false;
                    btnNghiViec.Enabled = false;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                }

                #endregion
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _key = 1;

          
            pnTK.Show();
            xoaAllTB();

            kichHoatTB();

            loadMaNV();
            tbMaNV.Text = NextID(_maTuTang, "NV").ToString();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            tbTenNV.Focus();
            tbSoDienThoai.Enabled = true;
            cbbLoaiNhanVien.Enabled = true;
            dataGridView1.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _key = 2;

            kichHoatTB();
            tbMaNV.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            cbbGioiTinh.Enabled = false;
            btnNghiViec.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_key == 1)
            {
                #region Lưu nút thêm.

                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thêm nhân viên không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        // Kiểm tra dữ liệu
                        if (tbMaNV.Text == "" || tbTenNV.Text == "" || cbbGioiTinh.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else if (tbMK.Text.CompareTo(tbMK2.Text) != 0)
                        {
                            XtraMessageBox.Show("Xác nhận mật khẩu không trùng khớp, vui lòng nhập lại !");
                        }
                        else
                        {
                            #region Chuỗi regex để kiểm tra
                            string reMa = @"^[NV]+[0-9]{4}$";
                            Regex rgMa = new Regex(reMa);

                            string reTen = @"^[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴ]+[a-zĐaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+(\s+[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴĐ]+[a-zaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+)+$";
                            Regex rgTen = new Regex(reTen);

                            string reGT = @"^[TPB]+[0-9]{4}$";
                            Regex rgGT = new Regex(reGT);

                            string reTK = @"^[A-Za-z0-9_\.]{6,32}$";
                            Regex rgTK = new Regex(reTK);

                            string reMK = @"^([A-Z]){1}([\w_\.!@#$%^&*()]+){5,31}$";
                            Regex rgMK = new Regex(reMK);
                            #endregion

                            if (!rgMa.IsMatch(tbMaNV.Text))
                            {
                                XtraMessageBox.Show("Mã nhân viên phải có kí tự NV ở đầu và gồm 7 kí tự , vui lòng nhập lại !");
                            }
                            else if (!rgTen.IsMatch(tbTenNV.Text))
                            {
                                XtraMessageBox.Show("Tên nhân viên viết hoa chữ đầu không bao gồm số , vui lòng nhập lại !");
                            }
                            else if (!rgTK.IsMatch(tbTenTK.Text))
                            {
                                XtraMessageBox.Show("Nhập sai thông tin ! \n Tên tài khoản chứa các ký tự chữ cái hoa, thường, chữ số, dấu . và dấu gạch dưới, độ dài 6 đến 32 ký tự");
                            }
                            else if (!rgMK.IsMatch(tbMK.Text))
                            {
                                XtraMessageBox.Show("Nhập sai thông tin ! \n Mật khẩu bao gồm ký tự chữ cái hoa, thường, chử số, ký tự đặc biệt, dấu chấm bắt đầu với ký tự in hoa, độ dài từ 6 đến 32 ký tự \n Vui lòng nhập lại !");
                            }
                            else
                            {

                              /*  string mk = tbMK.Text;
                                string mkMaHoa = maHoaMK(mk);*/

                                #region Thêm NV
                                //Thêm bảng NV
                                NhanVien nv1 = new NhanVien();
                                nv1.maNhanVien = tbMaNV.Text;
                                nv1.tenNhanVien = tbTenNV.Text;
                                nv1.ngaySinh = dtpNgaySinh.Value;
                                nv1.gioiTinh = cbbGioiTinh.Text;
                                nv1.diaChi = tbDiaChi.Text;
                                // nv1.loaiNhanVien = cbbLoaiNV.Text;
                                nv1.loaiNhanVien = cbbLoaiNhanVien.Text;
                                nv1.trangThai = "L";
                                nv1.soDienThoai = tbSoDienThoai.Text;
                                //Thêm bảng Tài Khoản
                                TaiKhoan tk1 = new TaiKhoan();
                                tk1.maNhanVien = tbMaNV.Text;
                                tk1.matKhau = tbMK.Text;
                                tk1.tenTaiKhoan = tbTenTK.Text;


                                if (nvbll.themNhanVien(nv1) && tkbll.themTaiKhoan(tk1))
                                {
                                    XtraMessageBox.Show("Thêm thành công !");

                                    #region Chỉnh trạng thái control sau khi thêm thành công
                                    btnThem.Enabled = true;
                                    btnHuy.Enabled = false;
                                    loadDsNhanVienDangLamLenDtgv();
                                    voHieuTB();
                                    xoaAllTB();
                                    btnThem.Enabled = true;
                                    tbTenTK.Text = null;
                                    tbMK.Text = null;
                                    tbMK2.Text = null;
                                    dataGridView1.Enabled = true;
                                    pnTK.Enabled = false;
                                    #endregion
                                }
                                else
                                {
                                    XtraMessageBox.Show("Bị trùng mã nhân viên, vui lòng nhập mã khác !");
                                }
                                #endregion
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi: " + ex);
                    }

                }
                else
                {
                    dg = DialogResult.Cancel;
                }

                #endregion
            }
            else if (_key == 2)
            {
                #region Lưu nút sửa
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn sửa thông tin nhân vien này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbMaNV.Text == "" || tbTenNV.Text == "" || cbbGioiTinh.Text == "" || tbDiaChi.Text == "" || tbSoDienThoai.Text=="")
                        {
                            btnLuu.Enabled = true;
                            btnHuy.Enabled = true;
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            _maNhanVien = tbMaNV.Text.Trim();
                            NhanVien nv1 = new NhanVien();
                            // nv1 = db.NhanViens.Where(a => a.maNhanVien == tbMaNV.Text).SingleOrDefault();
                            nv1.maNhanVien = tbMaNV.Text;
                            nv1.tenNhanVien = tbTenNV.Text;
                            nv1.ngaySinh = dtpNgaySinh.Value;
                            //nv1.loaiNhanVien = cbbLoaiNV.Text;
                            nv1.loaiNhanVien = cbbLoaiNhanVien.Text;
                            // nv1.trangThai = "L";
                            nv1.gioiTinh = cbbGioiTinh.Text;
                            nv1.diaChi = tbDiaChi.Text;
                            nv1.soDienThoai = tbSoDienThoai.Text;
                            // db.SubmitChanges();
                            if (nvbll.suaNhanVien2(nv1, _maNhanVien))
                            {
                                XtraMessageBox.Show("Sửa thành công !");
                                voHieuTB();
                                xoaAllTB();
                                btnThem.Enabled = true;
                                loadDsNhanVienDangLamLenDtgv();

                            }
                            else
                            {
                                XtraMessageBox.Show("Bị trùng mã nhân viên, vui lòng nhập mã khác !");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi: " + ex);
                    }
                    btnSua.Enabled = false;
                    btnNghiViec.Enabled = false;
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                }

                #endregion
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xoaAllTB();
            voHieuTB();
            pnTK.Hide();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnNghiViec.Enabled = false;
            dataGridView1.Enabled = true;
        }
    }
}