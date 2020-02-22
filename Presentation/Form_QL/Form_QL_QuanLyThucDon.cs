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
using System.Text.RegularExpressions;

namespace Presentation.Form_QL
{
    public partial class Form_QL_QuanLyThucDon : DevExpress.XtraEditors.XtraForm
    {
        public static int _key =0;
        public static string _maTD;
        public static string _maLoaiTD;
        public static string _tenLoaiTD;
        QLCFDataContext db;
        ThucDonBLL tdbll;
        LoaiThucDonBLL ltdbll;
        public Form_QL_QuanLyThucDon()
        {
            InitializeComponent();
            db = new QLCFDataContext();
            tdbll = new ThucDonBLL();
            ltdbll = new LoaiThucDonBLL();
        }
        

        public void loadThucDonLenDtgv()
        {
            dataGridView1.DataSource = (from a in db.ThucDons join b in db.LoaiThucDons on a.maLoaiThucDon equals b.maLoaiThucDon
                                        select new {
                                                    a.maThucDon,
                                                    a.tenThucDon,
                                                    b.tenLoaiThucDon,
                                                    a.donViTinh,
                                                    a.donGia
                                        });
        }

        private void Form_QL_QuanLyThucDon_Load(object sender, EventArgs e)
        {
            loadThucDonLenDtgv();
            cbbLoaiThucDon.DataSource = (from a in db.LoaiThucDons
                                         select a.tenLoaiThucDon
                                         ); 
        }

        private void Form_QL_QuanLyThucDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_QL_QLTD = true;
        }

        public void loadDataLenTB()
        {
            tbMaThucDon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            tbTenThucDon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            cbbLoaiThucDon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbDonViTinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbDonGia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();          

        }

        private void xoaAllTB()
        {
            tbMaThucDon.Text = null;
            tbTenThucDon.Text = null;
            cbbLoaiThucDon.Text = null;
            tbDonViTinh.Text = null;
            tbDonGia.Text = null;
            
        }
        private void kichHoatTB()
        {
            panelQuanLyTD.Enabled = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataLenTB();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataLenTB();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _key = 1;
           // _huy = 1;
            btnThem.Enabled = false;
            dataGridView1.Enabled = false;
            xoaAllTB();
            kichHoatTB();

          
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _key = 2;
            kichHoatTB();
            tbMaThucDon.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _key = 0;
            xoaAllTB();
            panelQuanLyTD.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataGridView1.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(_key == 1)
            {
                #region Lưu nút thêm
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thêm thực đơn không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbMaThucDon.Text == "" || tbTenThucDon.Text == "" || tbDonViTinh.Text == "" || tbDonGia.Text =="")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            #region Chuỗi regex để kiểm tra

                            string reMa = @"^[TD]+[0-9]{4}$";
                            Regex rgMa = new Regex(reMa);

                            string reTen = @"^[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴ]+[a-zĐaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+(\s+[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴĐ]+[a-zaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+)+$";
                            Regex rgTen = new Regex(reTen);
                       
                            #endregion

                            if (!rgMa.IsMatch(tbMaThucDon.Text))
                            {
                                XtraMessageBox.Show("Mã thực đơn phải có kí tự TD ở đầu và gồm 6 kí tự , vui lòng nhập lại !");
                            }
                            else
                            {
                                _tenLoaiTD = cbbLoaiThucDon.Text;
                                //Thêm bảng thực đơn
                                ThucDon td1 = new ThucDon();
                                td1.maThucDon = tbMaThucDon.Text.Trim();
                                td1.tenThucDon = tbTenThucDon.Text.Trim();                              
                                td1.donViTinh = tbDonViTinh.Text;
                                td1.donGia = Convert.ToDecimal(tbDonGia.Text);
                                td1.maLoaiThucDon = ltdbll.layMaLoaiThucDon(_tenLoaiTD);                              

                                if (tdbll.themThucDon(td1))
                                {
                                   
                                    XtraMessageBox.Show("Thêm thành công !");
                                    _key = 0;
                                    loadThucDonLenDtgv();
                                    #region Chỉnh trạng thái control sau khi thêm thành công
                                    xoaAllTB();
                                    panelQuanLyTD.Enabled = false;
                                    dataGridView1.Enabled = true;
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    btnThem.Enabled = true;

                                    #endregion
                                }
                                else
                                {
                                    XtraMessageBox.Show("Bị trùng mã thực đơn, vui lòng nhập mã khác !");
                                }

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
            else if(_key == 2)
            {
                #region Lưu nút sửa
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thay đổi thông tin thực đơn này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbMaThucDon.Text == "" || tbTenThucDon.Text == "" || tbDonViTinh.Text == "" || tbDonGia.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            //Chuỗi regex để kiểm tra
                            string reMa = @"^[DT]+[0-9]{4}$";
                            Regex rgMa = new Regex(reMa);


                            if (!rgMa.IsMatch(tbMaThucDon.Text))
                            {
                                XtraMessageBox.Show("Mã thực đơn phải có kí tự TD ở đầu và gồm 6 kí tự , vui lòng nhập lại !");
                            }
                            else
                            {

                                _maTD = tbMaThucDon.Text;
                                _tenLoaiTD = cbbLoaiThucDon.Text;
                                ////Sửa bảng thực đơn
                                ThucDon td1 = new ThucDon();
                                td1.maThucDon = tbMaThucDon.Text.Trim();
                                td1.tenThucDon = tbTenThucDon.Text.Trim();
                                td1.donViTinh = tbDonViTinh.Text.Trim();
                                td1.donGia = Convert.ToDecimal(tbDonGia.Text);
                                td1.maLoaiThucDon = ltdbll.layMaLoaiThucDon(_tenLoaiTD);

                                if (tdbll.suaThucDon(td1, _maTD))
                                {
                                    XtraMessageBox.Show("Sửa thành công !");
                                    _key = 0;
                                    loadThucDonLenDtgv();
                                    #region Chỉnh trạng thái control sau khi sửa thành công
                                    btnThem.Enabled = true;
                                    btnLuu.Enabled = false;
                                    btnHuy.Enabled = false;
                                    #endregion
                                }
                                else
                                {
                                    XtraMessageBox.Show("Bị trùng mã thực đơn, vui lòng nhập mã khác !");
                                }

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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = XtraMessageBox.Show("Bạn có muốn xoá thực đơn không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                
                try
                {
                    _maTD = tbMaThucDon.Text;
                   
                    if (tdbll.xoaThucDon(_maTD))
                    {
                        XtraMessageBox.Show("Xoá thành công !");
                        #region Sửa control sau khi xoá thành công
                        _key = 0;
                        loadThucDonLenDtgv();
                        xoaAllTB();
                        panelQuanLyTD.Enabled = false;
                        btnThem.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        #endregion
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

            }
            else
            {
                dg = DialogResult.Cancel;
            }
        }
    }
}