using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.Accessibility;
using DevExpress.XtraToolbox;
using System.Security.Cryptography;

namespace Presentation
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public static string _tenDN;
        public static string _MK;
        public static string _maNhanVien;
        public static string _MK_MaHoa;
        NhanVienBLL nvbll;
        public FormLogin()
        {

            InitializeComponent();
            nvbll = new NhanVienBLL();

        }


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*try
            {
                if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;

                }
            }
            catch
            {

            }*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }

        public string maHoaMK(string matKhau)
        {
            MD5 mh = MD5.Create();
            //Tạo MD5 

            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(matKhau);

            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);

            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _tenDN = tbTaiKhoan.Text;
            _MK_MaHoa = maHoaMK(tbMatKhau.Text);
            try
            {
                NhanVien kt = nvbll.kiemTraDangNhap(tbTaiKhoan.Text, maHoaMK(tbMatKhau.Text));

                if (tbTaiKhoan.Text.Trim() == "" || tbMatKhau.Text.Trim() == "")
                {
                    XtraMessageBox.Show("Bạn chưa nhập đủ thông tin tài khoản !");
                    tbTaiKhoan.Focus();
                }
                if (tbTaiKhoan.Text.Trim() != "" || tbMatKhau.Text.Trim() != "")
                {


                    if (kt != null)
                    {
                        _maNhanVien = nvbll.layMaNhanVien(tbTaiKhoan.Text);
                        FormMain form = new FormMain();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        XtraMessageBox.Show("Tài khoản hoặc mật khẩu sai, vui lòng nhập lại !");
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi " + ex);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        
    }
}