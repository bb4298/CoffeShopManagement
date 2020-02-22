namespace Presentation.Form_QL
{
    partial class Form_QL_QuanLyHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.controlThaoTac = new DevExpress.XtraEditors.GroupControl();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrangCuoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrangDau = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrangSau = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrangTruoc = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lbTongTienHD = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridVgiewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTTcthd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlThaoTac)).BeginInit();
            this.controlThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(585, 34);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(200, 23);
            this.dtpKetThuc.TabIndex = 0;
            this.dtpKetThuc.ValueChanged += new System.EventHandler(this.dtpKetThuc_ValueChanged);
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(5, 34);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(200, 23);
            this.dtpBatDau.TabIndex = 1;
            this.dtpBatDau.ValueChanged += new System.EventHandler(this.dtpBatDau_ValueChanged);
            // 
            // controlThaoTac
            // 
            this.controlThaoTac.Controls.Add(this.groupControl1);
            this.controlThaoTac.Controls.Add(this.btnXacNhan);
            this.controlThaoTac.Controls.Add(this.btnTrangCuoi);
            this.controlThaoTac.Controls.Add(this.btnTrangDau);
            this.controlThaoTac.Controls.Add(this.btnTrangSau);
            this.controlThaoTac.Controls.Add(this.btnTrangTruoc);
            this.controlThaoTac.Controls.Add(this.dataGridView1);
            this.controlThaoTac.Controls.Add(this.dtpBatDau);
            this.controlThaoTac.Controls.Add(this.dtpKetThuc);
            this.controlThaoTac.Location = new System.Drawing.Point(12, 12);
            this.controlThaoTac.Name = "controlThaoTac";
            this.controlThaoTac.Size = new System.Drawing.Size(790, 537);
            this.controlThaoTac.TabIndex = 48;
            this.controlThaoTac.Text = "Danh Sách Hoá Đơn";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.Location = new System.Drawing.Point(344, 29);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(139, 28);
            this.btnXacNhan.TabIndex = 19;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTrangCuoi
            // 
            this.btnTrangCuoi.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTrangCuoi.Appearance.Options.UseFont = true;
            this.btnTrangCuoi.Location = new System.Drawing.Point(646, 493);
            this.btnTrangCuoi.Name = "btnTrangCuoi";
            this.btnTrangCuoi.Size = new System.Drawing.Size(139, 39);
            this.btnTrangCuoi.TabIndex = 18;
            this.btnTrangCuoi.Text = "Trang cuối";
            this.btnTrangCuoi.Click += new System.EventHandler(this.btnTrangCuoi_Click);
            // 
            // btnTrangDau
            // 
            this.btnTrangDau.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTrangDau.Appearance.Options.UseFont = true;
            this.btnTrangDau.Location = new System.Drawing.Point(5, 493);
            this.btnTrangDau.Name = "btnTrangDau";
            this.btnTrangDau.Size = new System.Drawing.Size(139, 39);
            this.btnTrangDau.TabIndex = 17;
            this.btnTrangDau.Text = "Trang đầu";
            this.btnTrangDau.Click += new System.EventHandler(this.btnTrangDau_Click);
            // 
            // btnTrangSau
            // 
            this.btnTrangSau.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTrangSau.Appearance.Options.UseFont = true;
            this.btnTrangSau.Location = new System.Drawing.Point(501, 493);
            this.btnTrangSau.Name = "btnTrangSau";
            this.btnTrangSau.Size = new System.Drawing.Size(139, 39);
            this.btnTrangSau.TabIndex = 16;
            this.btnTrangSau.Text = "Trang Sau";
            this.btnTrangSau.Click += new System.EventHandler(this.btnTrangSau_Click);
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnTrangTruoc.Appearance.Options.UseFont = true;
            this.btnTrangTruoc.Location = new System.Drawing.Point(150, 493);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.Size = new System.Drawing.Size(139, 39);
            this.btnTrangTruoc.TabIndex = 15;
            this.btnTrangTruoc.Text = "Trang trước";
            this.btnTrangTruoc.Click += new System.EventHandler(this.btnTrangTruoc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDon,
            this.maBan,
            this.tongTienThanhToan,
            this.ngayThanhToan,
            this.tenNhanVien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(5, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 327);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maHoaDon
            // 
            this.maHoaDon.DataPropertyName = "maHoaDon";
            this.maHoaDon.HeaderText = "Mã Hoá Đơn";
            this.maHoaDon.Name = "maHoaDon";
            this.maHoaDon.ReadOnly = true;
            this.maHoaDon.Width = 110;
            // 
            // maBan
            // 
            this.maBan.DataPropertyName = "maBan";
            this.maBan.HeaderText = "Số Bàn";
            this.maBan.Name = "maBan";
            this.maBan.ReadOnly = true;
            // 
            // tongTienThanhToan
            // 
            this.tongTienThanhToan.DataPropertyName = "tongTienThanhToan";
            this.tongTienThanhToan.HeaderText = "Tổng Tiền Thanh Toán";
            this.tongTienThanhToan.Name = "tongTienThanhToan";
            this.tongTienThanhToan.ReadOnly = true;
            this.tongTienThanhToan.Width = 175;
            // 
            // ngayThanhToan
            // 
            this.ngayThanhToan.DataPropertyName = "ngayThanhToan";
            this.ngayThanhToan.HeaderText = "Ngày Thanh Toán";
            this.ngayThanhToan.Name = "ngayThanhToan";
            this.ngayThanhToan.ReadOnly = true;
            this.ngayThanhToan.Width = 170;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên Nhân Viên";
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView2);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Location = new System.Drawing.Point(808, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(536, 537);
            this.groupControl2.TabIndex = 54;
            this.groupControl2.Text = "Chi Tiết Hoá Đơn";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTongDoanhThu);
            this.groupControl1.Location = new System.Drawing.Point(5, 396);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 91);
            this.groupControl1.TabIndex = 55;
            this.groupControl1.Text = "Tổng Doanh Thu";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTongDoanhThu.Location = new System.Drawing.Point(190, 26);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(368, 51);
            this.lbTongDoanhThu.TabIndex = 2;
            this.lbTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lbTTcthd);
            this.groupControl3.Controls.Add(this.lbTongTienHD);
            this.groupControl3.Location = new System.Drawing.Point(5, 378);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(526, 154);
            this.groupControl3.TabIndex = 56;
            this.groupControl3.Text = "Tổng Tiền Hoá Đơn:";
            // 
            // lbTongTienHD
            // 
            this.lbTongTienHD.AutoSize = true;
            this.lbTongTienHD.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTongTienHD.Location = new System.Drawing.Point(-318, 0);
            this.lbTongTienHD.Name = "lbTongTienHD";
            this.lbTongTienHD.Size = new System.Drawing.Size(0, 51);
            this.lbTongTienHD.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.donViTinh,
            this.dataGridVgiewTextBoxColumn3,
            this.soLuong,
            this.thanhTien});
            this.dataGridView2.Location = new System.Drawing.Point(5, 29);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(526, 345);
            this.dataGridView2.TabIndex = 57;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenThucDon";
            this.Column1.HeaderText = "Tên Thực Đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.ReadOnly = true;
            // 
            // dataGridVgiewTextBoxColumn3
            // 
            this.dataGridVgiewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVgiewTextBoxColumn3.DataPropertyName = "donGia";
            this.dataGridVgiewTextBoxColumn3.HeaderText = "Đơn Giá";
            this.dataGridVgiewTextBoxColumn3.Name = "dataGridVgiewTextBoxColumn3";
            this.dataGridVgiewTextBoxColumn3.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành Tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // lbTTcthd
            // 
            this.lbTTcthd.AutoSize = true;
            this.lbTTcthd.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.lbTTcthd.Location = new System.Drawing.Point(109, 58);
            this.lbTTcthd.Name = "lbTTcthd";
            this.lbTTcthd.Size = new System.Drawing.Size(368, 51);
            this.lbTTcthd.TabIndex = 3;
            this.lbTTcthd.Text = "Tổng doanh thu:";
            // 
            // Form_QL_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 561);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.controlThaoTac);
            this.Name = "Form_QL_QuanLyHoaDon";
            this.Text = "Quản Lí Hoá Đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QL_QuanLyHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.Form_QL_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlThaoTac)).EndInit();
            this.controlThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private DevExpress.XtraEditors.GroupControl controlThaoTac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnTrangCuoi;
        private DevExpress.XtraEditors.SimpleButton btnTrangDau;
        private DevExpress.XtraEditors.SimpleButton btnTrangSau;
        private DevExpress.XtraEditors.SimpleButton btnTrangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label lbTongTienHD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridVgiewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.Label lbTTcthd;
    }
}