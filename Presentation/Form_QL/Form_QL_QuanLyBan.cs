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

namespace Presentation.Form_QL
{
    public partial class Form_QL_QuanLyBan : DevExpress.XtraEditors.XtraForm
    {   public string _maBan;
        public string _maBanTuTang;
        public int _tenBanTuTang;
        BanBLL bbll;
        QLCFDataContext db;
        public Form_QL_QuanLyBan()
        {
            InitializeComponent();
            db = new QLCFDataContext();
            bbll = new BanBLL();
        }

        public void loadDsBanLenDtgv()
        {
            dataGridView1.DataSource = (from a in db.Bans
                                        select new
                                        {
                                        a.maBan,
                                        });
        }
        public void loadDataLenTB()
        {
            tbMaBan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            //tbTenBan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
        }

        private string NextID(string maTuTang, string prefixID)
        {
            if (maTuTang == "")
            {
                return prefixID + "001";  // fixwidth default
            }
            int nextID = int.Parse(maTuTang.Remove(0, prefixID.Length)) + 1;
            int lengthNumerID = maTuTang.Length - prefixID.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;

        }
        private void Form_QL_QuanLyBan_Load(object sender, EventArgs e)
        {
            loadDsBanLenDtgv();
            //layMaBanCaoNhat();
         
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thêm bảng bàn
           // layMaBanCaoNhat();
            //int maBam = bbll.layMaBanCaoCaoNhat()+1;
            Ban ban1 = new Ban();
            if (bbll.layMaBanCaoCaoNhat() == null)
            {
                ban1.maBan = 1;
            }
            else
            {
                ban1.maBan = bbll.layMaBanCaoCaoNhat() + 1;
            }
            //ban1.tenBan = _tenBanTuTang +1;
            ban1.trangThai = "Trống";

            if (bbll.themBan(ban1))
            {               
               // XtraMessageBox.Show("Thêm thành công !");
                loadDsBanLenDtgv();
               // btnXoa.Enabled = false;
               
            }
            else
            {
                XtraMessageBox.Show("Bị trùng mã bàn, vui lòng nhập mã khác !");
            }
        }

        private void Form_QL_QuanLyBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.f_QL_QLB = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataLenTB();
            btnXoa.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataLenTB();
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        try
        {
            //layMaBanCaoNhat();
            // _maBan = tbMaBan.Text;

            if (bbll.xoaBan(bbll.layMaBanCaoCaoNhat()))
            {
                //XtraMessageBox.Show("Xoá thành công !");              
                loadDsBanLenDtgv();            
            }
            else
            {
                XtraMessageBox.Show("Bị trùng mã bàn, vui lòng nhập mã khác !");
            }
        }
        catch (Exception ex)
        {

            XtraMessageBox.Show("Lỗi: " + ex);
        }
   
        }
    }
}