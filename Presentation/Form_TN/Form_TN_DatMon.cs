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
using Entities;
using System.IO;

namespace Presentation
{
    public partial class Form_TN_DatMon : DevExpress.XtraEditors.XtraForm
    {
        
        public static string _maBanDangChon;
        public static string _maHoaDonDangChon;
       
        QLCFDataContext db;
        BanBLL bbll;
        HoaDonBLL hdbll;
        ThucDonBLL tdbll;
        LoaiThucDonBLL ltdbll;
        ChiTietHoaDonBLL cthdbll;
        NhanVienBLL nvbll;
        public SimpleButton btn;
        public Form_TN_DatMon()
        {
            InitializeComponent();
            db = new QLCFDataContext();
            bbll = new BanBLL();
            hdbll = new HoaDonBLL();
            tdbll = new ThucDonBLL();
            ltdbll = new LoaiThucDonBLL();
            cthdbll = new ChiTietHoaDonBLL();
            nvbll = new NhanVienBLL();
            

        }

        #region code cũ

        public void xoaDsBan()

        {

            foreach (Control c in flowLayoutPanel1.Controls.OfType<SimpleButton>())
            {
                c.Dispose();

                c.Refresh();
            }
            flowLayoutPanel1.Controls.Clear();
        }
        public void refresh()
        {
            foreach (Control c in flowLayoutPanel1.Controls.OfType<SimpleButton>())
            {

                if (Convert.ToString(c.Tag) == "Có Người")
                {
                    //c.LookAndFeel.SetUltraFlatStyle();
                    c.Click += new EventHandler(loadMonDaGoiLenDtgv);

                }
                //btn.Click += new EventHandler(btn_Click);
                if (Convert.ToString(c.Tag) == "Trống")
                {
                    c.Click += new EventHandler(moBan);


                }
            }

            foreach (SimpleButton btn in flowLayoutPanel1.Controls)
            {
                if (Convert.ToString(btn.Tag) == "Có Người")
                {
                    //c.LookAndFeel.SetUltraFlatStyle();
                    btn.Click += new EventHandler(loadMonDaGoiLenDtgv);

                }
                //btn.Click += new EventHandler(btn_Click);
                if (Convert.ToString(btn.Tag) == "Trống")
                {
                    btn.Click += new EventHandler(moBan);

                }
            }

            foreach (SimpleButton btn in flowLayoutPanel1.Controls)
            {
                //Convert.ToString(btn.Tag) == "Có Người");
                Console.WriteLine(btn.Tag);
            }

        }
        public void loadDanhSachBan()
        {

            foreach (Ban b in db.Bans)
            {

                btn = new SimpleButton();
                btn.Name = b.maBan.ToString();                
                btn.Tag = b.maHoaDon;
                btn.Text = string.Format("Bàn số {0} \n {1}", btn.Name, b.trangThai);
                btn.Size = new Size(80, 80);
                btn.Margin = new Padding(10);
                //btn.Click += btn_Click;
               
                flowLayoutPanel1.Controls.Add(btn);
                if (btn.Tag != null)
                {
                    
                    btn.LookAndFeel.SetUltraFlatStyle();
                    btn.Click += loadMonDaGoiLenDtgv;
                    btn.Click += luuTenBanDangChon;                  
                }
                else if (btn.Tag == null)
                {
                    btn.Click += moBan;
                    //btn.Click += luuTenBanDangChon;
                }
                // btn.LookAndFeel.SetUltraFlatStyle();                  
                /*if (Convert.ToString(btn.Tag) == "Có Người")
                {
                    btn.LookAndFeel.SetUltraFlatStyle();
                   // btn.Click += new EventHandler(loadDataLenDtgv);
                    btn.Click += loadDataLenDtgv;
                    flowLayoutPanel1.Controls.Add(btn);
                }
                //btn.Click += new EventHandler(btn_Click);
                if (Convert.ToString(btn.Tag) == "Trống")
                {
                   // btn.Click += new EventHandler(moBan);
                    btn.Click += moBan;
                    flowLayoutPanel1.Controls.Add(btn);                   
                }*/

            }

        }
        public void moBan(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = XtraMessageBox.Show("Bạn có muốn mở bàn này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {                
                ((SimpleButton)sender).LookAndFeel.SetUltraFlatStyle();
                ((SimpleButton)sender).Tag = hdbll.layMaHoaDonCaoNhat() +1;
               // ((SimpleButton)sender).Click += new EventHandler(moBan);
               ((SimpleButton)sender).Text= string.Format("Bàn số {0} \n {1}", ((SimpleButton)sender).Name, "Có Người");
               ((SimpleButton)sender).Click -= moBan;
                ((SimpleButton)sender).Click += luuTenBanDangChon;
                ((SimpleButton)sender).Click += loadMonDaGoiLenDtgv;
                
                //cập nhật vào db
                foreach (Ban b in db.Bans)
                {
                    if (b.maBan.ToString() == ((SimpleButton)sender).Name)
                    {
                        
                        //Thêm hoá đơn vào bảng hoá đơn
                        HoaDon hd = new HoaDon();
                        if (hdbll.layMaHoaDonCaoNhat() == null)
                        {
                            hd.maHoaDon = 1;
                        }
                        else
                        {
                            hd.maHoaDon = hdbll.layMaHoaDonCaoNhat() + 1;
                        }
                        hd.ngayThanhToan = DateTime.Now;
                        hd.trangThai = "C";
                        hd.maBan =Convert.ToInt32(((SimpleButton)sender).Name);
                        hd.maNhanVien = FormLogin._maNhanVien;
                        hdbll.themHoaDon(hd);

                        //Thêm mã hoá đơn vào bàn
                        int maHD = hdbll.layMaHoaDonCaoNhat();

                        //Lưu trạng thái vào db
                        Ban ban = new Ban();
                        ban.maBan = Convert.ToInt32(((SimpleButton)sender).Name);
                        //ban.tenBan = ban.tenBan; 
                        ban.trangThai = "Có Người";
                        ban.maHoaDon = maHD;
                        bbll.suaBan(ban, ((SimpleButton)sender).Name);

                    }

                }

                
                //loadDanhSachBan();
            }
        }
        
        public void luuTenBanDangChon(object sender, EventArgs e)
        {
            _maBanDangChon = ((SimpleButton)sender).Name;
            _maHoaDonDangChon = ((SimpleButton)sender).Tag.ToString();
            tbTenBan.Text = _maBanDangChon;
            tbTenNhanVien.Text = nvbll.layTenNhanVien(FormLogin._tenDN);
            

        }

        public void loadMonDaGoiLenDtgv(object sender, EventArgs e)
        {
            string tongTienHD;
            if (((SimpleButton)sender).Tag != null)
            {
                //tongTienHD = cthdbll.tinhTongHoaDon(Convert.ToInt32(((SimpleButton)sender).Tag));
                tongTienHD = cthdbll.tinhTongHoaDon(Convert.ToInt32(((SimpleButton)sender).Tag));
                 lbThanhTien.Text = "Tổng tiền: " +Convert.ToDecimal(tongTienHD).ToString("###,##");
            }
            else
            {
                lbThanhTien.Text = "Tổng tiền: 0 VND";
            }
            
            dataGridView1.DataSource = (from a in db.Bans
                                        join b in db.HoaDons on a.maBan equals b.maBan
                                        join c in db.ChiTietHoaDons on b.maHoaDon equals c.maHoaDon
                                        join d in db.ThucDons on c.maThucDon equals d.maThucDon
                                        where a.maBan.ToString() == ((SimpleButton)sender).Name && b.trangThai == "C"
                                        //where a.maHoaDon.ToString() == ((SimpleButton)sender).Tag.ToString() && b.trangThai == "C"
                                        select new
                                        {
                                            d.tenThucDon,
                                            c.soLuong,
                                            d.donGia,
                                            c.thanhTien
                                        });
        }
       
        public void loadLoaiThucDon()
        {
            ccbLoaiThucDon.DataSource = (from a in db.LoaiThucDons
                                         select a.tenLoaiThucDon
                                         );
        }

        public void loadDanhSachThucDon()
        {
            string loadTD = ltdbll.layMaLoaiThucDon(ccbLoaiThucDon.Text);
            dataGridView2.DataSource = (from a in db.ThucDons
                                        where a.maLoaiThucDon == loadTD
                                        select new
                                        {
                                            a.maThucDon,
                                            a.tenThucDon,
                                            a.donViTinh,
                                            a.donGia
                                        });
        }

        public void loadThongTinHoaDonLenTB()
        {
            //tbten
        }

        private void Form_TN_DatMon_Load(object sender, EventArgs e)
        {
            loadDanhSachBan();
            loadLoaiThucDon();
        }

        #endregion


        private void Form_TN_DatMon_FormClosed(object sender, FormClosedEventArgs e)
        {          
            FormMain.f_TN_DatMon = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDanhSachThucDon();
        }

        private void btnMoBan_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = XtraMessageBox.Show("Bạn có muốn thêm món vào bàn này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {

                ChiTietHoaDon cthd1 = new ChiTietHoaDon();
                if (cthdbll.layMa_CTHD_CaoNhat() == null)
                {
                    cthd1.maChiTietHoaDon = 1;
                }
                else
                {
                    cthd1.maChiTietHoaDon = cthdbll.layMa_CTHD_CaoNhat() + 1;
                }
                // tạo chi tiết hoá đơn
                decimal donGia = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);
                cthd1.maHoaDon = Convert.ToInt32(_maHoaDonDangChon);
                cthd1.maThucDon = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                cthd1.soLuong = Convert.ToInt32(nmrSoLuong.Value);
                cthd1.thanhTien = donGia * Convert.ToDecimal(cthd1.soLuong);
                cthd1.trangThai = "C";

                if(cthd1.maThucDon == null )
                {
                    XtraMessageBox.Show("Vui lòng chọn thực đơn !");
                }
                else if(cthd1.soLuong < 1)
                {
                    XtraMessageBox.Show("Vui lòng chọn số lượng từ 1 trở lên !");
                }
                else
                {
                    if(cthdbll.them_CTHD(cthd1))
                    {
          /**/              string tongTienHD = cthdbll.tinhTongHoaDon(Convert.ToInt32(_maHoaDonDangChon));
                        // Cập nhật tổng tiền vào bảng hoá đơn

                        HoaDon hd1 = new HoaDon();
                        hd1.maHoaDon = Convert.ToInt32(_maHoaDonDangChon);
                        hd1.tongTienThanhToan =Convert.ToDecimal( tongTienHD);
                        hdbll.suaTongTienHoaDon(hd1, Convert.ToInt32(_maHoaDonDangChon));

                        lbThanhTien.Text = "Tổng tiền: "+Convert.ToDecimal( hdbll.tongTienHoaDon(Convert.ToInt32(_maHoaDonDangChon))).ToString("###,##");

                        XtraMessageBox.Show("Thêm thành công !");
                        loadMonDaGoiLenDtgv(sender,e);
                    }
                    else
                    {
                        XtraMessageBox.Show("Thêm thất bại !");
                    }
                }


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = XtraMessageBox.Show("Bạn có muốn tính tiền bàn này không !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (!cthdbll.kiemTraPhaChe(Convert.ToInt32(_maHoaDonDangChon)))
                {
                    XtraMessageBox.Show("Nhân viên pha chế chưa xác nhận đã pha chế thực đơn !");
                }
                else
                {
                    #region Câp nhật
                    // Cập nhật hoá đơn đã thanhn toán vào database
                    HoaDon hd1 = new HoaDon();
                    hd1.maHoaDon = Convert.ToInt32(_maHoaDonDangChon);
                    hd1.trangThai = "R";
                    hdbll.suaTrangThaiHoaDon(hd1, Convert.ToInt32(_maHoaDonDangChon));

                    // Cập nhật bàn sau khi thanh toán
                    Ban b = new Ban();
                    b.maBan = Convert.ToInt32(_maBanDangChon);
                    b.trangThai = "Trống";
                    b.maHoaDon = null;

                    bbll.suaBan(b, _maBanDangChon);

                    // int maBan = Convert.ToInt32(tbTenBan.Text); 

                    // Sửa control trên form
                    foreach (SimpleButton btn in flowLayoutPanel1.Controls)
                    {
                        if (btn.Name == _maBanDangChon)
                        {
                            btn.LookAndFeel.SetDefaultStyle();
                            btn.Tag = null;
                            btn.Click -= loadMonDaGoiLenDtgv;
                            btn.Click -= luuTenBanDangChon;
                            btn.Click += moBan;
                            btn.Text = string.Format("Bàn số {0} \n {1}", btn.Name, "Trống");
                        }
                    }
                    dataGridView1.DataSource = null;

                    XtraMessageBox.Show("Thanh toán thành công !");
                    #endregion
                }

            }
        }
    }
}