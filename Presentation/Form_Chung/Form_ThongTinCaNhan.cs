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
using System.Data.SqlClient;
using DAL;
using BLL;
using System.Text.RegularExpressions;

namespace Presentation.Form_Chung
{
    public partial class Form_ThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        int kq;
        DataKetNoi DT;
        NhanVienBLL nvbll;
        public Form_ThongTinCaNhan()
        {
            InitializeComponent();
            nvbll = new NhanVienBLL();
            DT = new DataKetNoi();
        }

        public void loadThongTinLenTB()
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            #region Load dữ liệu lên TB
            //SqlConnection myCon = new SqlConnection();
            ////myCon.ConnectionString = @"Data Source=DESKTOP-PTT6BR4\SQLEXPRESS;Initial Catalog=QuanLiLaoDong;Integrated Security=True";
            //myCon.ConnectionString = @DT.chuoiKetNoi() ;

            //myCon.Open();

            //SqlDataAdapter myAdapter = new SqlDataAdapter(nvbll.loadThongTinLenTB(FormLogin._tenDN), myCon);
            //DataTable myTable = new DataTable();
            //myAdapter.Fill(myTable);

            ////textBox1.Text = myTable.Rows[indexer]["username"].ToString(); 
            ////textBox2.Text = myTable.Rows[indexer]["password"].ToString();

            //tbMaNV.Text = myTable.Rows[0]["maNhanVien"].ToString().Trim();
            //tbTenNV.Text = myTable.Rows[0]["tenNhanVien"].ToString().Trim();
            //dtpNgaySinh.Text = myTable.Rows[0]["ngaySinh"].ToString();
            //cbbGioiTinh.Text = myTable.Rows[0]["gioiTinh"].ToString();
            //tbDiaChi.Text = myTable.Rows[0]["diaChi"].ToString();
            //tbSoDienThoai.Text = myTable.Rows[0]["soDienThoai"].ToString().Trim();

            //myCon.Close();
            var q = nvbll.loadThongTinLenTB(FormLogin._tenDN);

            tbMaNV.Text = q.maNhanVien;
            tbTenNV.Text = q.tenNhanVien;
            dtpNgaySinh.Text = q.ngaySinh.ToString();
            cbbGioiTinh.Text = q.gioiTinh;
            tbDiaChi.Text = q.diaChi;
            tbSoDienThoai.Text = q.soDienThoai;
            #endregion
        }

        private void Form_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadThongTinLenTB();
        }

        private void Form_ThongTinCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_TTCN = true;
        }

        private void tbLoaiNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbTenNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbbGioiTinh.Enabled = true;
            tbDiaChi.Enabled = true;

            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            tbTenNV.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadThongTinLenTB();
            tbTenNV.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbbGioiTinh.Enabled = false;
            tbDiaChi.Enabled = false;
            btnSua.Enabled = true;

            btnSua.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            try
            {
                SqlConnection myCon = new SqlConnection();
                myCon.ConnectionString = DT.chuoiKetNoi();
                myCon.Open();//không có dòng này thì adapter sẽ tự open

                #region Chuỗi regex để kiểm tra
                string sqlSua = @"update NhanVien set tenNhanVien=N'" + tbTenNV.Text + "',ngaySinh=N'" + dtpNgaySinh.Text + "',gioiTinh=N'" + cbbGioiTinh.Text + "',diaChi=N'" + tbDiaChi.Text + "',soDienThoai=N'"+tbSoDienThoai.Text+"'where maNhanVien='" + tbMaNV.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlSua, myCon);

                string reTen = @"^[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴ]+[a-zĐaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+(\s+[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴĐ]+[a-zaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+)+$";
                Regex rgTen = new Regex(reTen);

                string reGT = @"^[TPB]+[0-9]{4}$";
                Regex rgGT = new Regex(reGT);
                #endregion

                if (!rgTen.IsMatch(tbTenNV.Text))
                {
                    XtraMessageBox.Show("Tên nhân viên viết hoa chữ đầu không bao gồm số , vui lòng nhập lại !");
                }
                else
                {
                    kq = (int)cmd.ExecuteNonQuery();
                }

                if (kq > 0)
                {
                    XtraMessageBox.Show("Sửa thành công !");
                    loadThongTinLenTB();
                    tbTenNV.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    cbbGioiTinh.Enabled = false;
                    //tbGioiTinh.Enabled = false;
                    tbDiaChi.Enabled = false;
                    myCon.Close();

                    btnSua.Focus();
                }
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lối " + ex);
            }
        }
    }
}