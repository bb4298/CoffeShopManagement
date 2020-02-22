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
    public partial class Form_QL_QuanLyLoaiTD : DevExpress.XtraEditors.XtraForm
    {
        public int _key;
        public static string _maLoaiThucDon;
        QLCFDataContext db;
        LoaiThucDonBLL ltdbll;
        public Form_QL_QuanLyLoaiTD()
        {
            InitializeComponent();
            db = new QLCFDataContext();
            ltdbll = new LoaiThucDonBLL();
        }

        public void loadThucDonLenDtgv()
        {
            dataGridView1.DataSource = (from a in db.LoaiThucDons                                        
                                        select new
                                        {   a.maLoaiThucDon,
                                            a.tenLoaiThucDon,                                            
                                        });
        }

        private void Form_QL_QuanLyLoaiTD_Load(object sender, EventArgs e)
        {
            loadThucDonLenDtgv();
        }

        public void loadDataLenTB()
        {
            tbMaLoaiThucDon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            tbTenLoaiThucDon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
          
        }

        private void xoaAllTB()
        {
            tbMaLoaiThucDon.Text = null;
            tbTenLoaiThucDon.Text = null;
          

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
            tbMaLoaiThucDon.Enabled = false;
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

        private void Form_QL_QuanLyLoaiTD_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_QL_QLLTD = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_key == 1)
            {
                #region Lưu nút thêm
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thêm thực đơn không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbMaLoaiThucDon.Text == "" || tbTenLoaiThucDon.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            #region Chuỗi regex để kiểm tra

                            string reMa = @"^[L]+[0-9]{3}$";
                            Regex rgMa = new Regex(reMa);

                            string reTen = @"^[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴ]+[a-zĐaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+(\s+[A-ZAÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴĐ]+[a-zaáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵđ]+)+$";
                            Regex rgTen = new Regex(reTen);

                            #endregion

                            if (!rgMa.IsMatch(tbMaLoaiThucDon.Text))
                            {
                                XtraMessageBox.Show("Mã thực đơn phải có kí tự L ở đầu và gồm 4 kí tự , vui lòng nhập lại !");
                            }
                            else
                            {
                                
                                //Thêm bảng loại thực đơn
                                LoaiThucDon ltd1 = new LoaiThucDon();
                                ltd1.maLoaiThucDon = tbMaLoaiThucDon.Text.Trim();
                                ltd1.tenLoaiThucDon = tbTenLoaiThucDon.Text.Trim();
                               

                                if (ltdbll.themLoaiThucDon(ltd1))
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
            else if (_key == 2)
            {
                #region Lưu nút sửa
                DialogResult dg = new DialogResult();
                dg = XtraMessageBox.Show("Bạn có muốn thay đổi thông tin thực đơn này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        if (tbMaLoaiThucDon.Text == "" || tbTenLoaiThucDon.Text == "")
                        {
                            XtraMessageBox.Show("Thiếu thông tin, vui lòng nhập đủ !");
                        }
                        else
                        {
                            //Chuỗi regex để kiểm tra
                            string reMa = @"^[L]+[0-9]{3}$";
                            Regex rgMa = new Regex(reMa);


                            if (!rgMa.IsMatch(tbMaLoaiThucDon.Text))
                            {
                                XtraMessageBox.Show("Mã thực đơn phải có kí tự L ở đầu và gồm 4 kí tự , vui lòng nhập lại !");
                            }
                            else
                            {

                                _maLoaiThucDon = tbMaLoaiThucDon.Text;
                                ////Sửa bảng thực đơn
                                LoaiThucDon td1 = new LoaiThucDon();
                                td1.maLoaiThucDon = tbMaLoaiThucDon.Text.Trim();
                                td1.tenLoaiThucDon = tbTenLoaiThucDon.Text.Trim();

                                if (ltdbll.suaLoaiThucDon(td1, _maLoaiThucDon))
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
            dg = XtraMessageBox.Show("Bạn có muốn xoá loại thực đơn này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {

                try
                {
                    _maLoaiThucDon = tbMaLoaiThucDon.Text;

                    if (ltdbll.xoaLoaiThucDon(_maLoaiThucDon))
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            loadDataLenTB();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            loadDataLenTB();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}