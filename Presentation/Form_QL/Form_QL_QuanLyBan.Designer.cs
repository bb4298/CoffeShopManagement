namespace Presentation.Form_QL
{
    partial class Form_QL_QuanLyBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelQuanLyTD = new System.Windows.Forms.Panel();
            this.tbMaBan = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.controlThaoTac = new DevExpress.XtraEditors.GroupControl();
            this.panelThaoTac = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panelQuanLyTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlThaoTac)).BeginInit();
            this.controlThaoTac.SuspendLayout();
            this.panelThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl1.Controls.Add(this.panelQuanLyTD);
            this.groupControl1.Controls.Add(this.controlThaoTac);
            this.groupControl1.Location = new System.Drawing.Point(81, 19);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1195, 287);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "                                                                                 " +
    "                                                  Quản Lý Bàn";
            // 
            // panelQuanLyTD
            // 
            this.panelQuanLyTD.Controls.Add(this.tbMaBan);
            this.panelQuanLyTD.Controls.Add(this.label3);
            this.panelQuanLyTD.Enabled = false;
            this.panelQuanLyTD.Location = new System.Drawing.Point(57, 29);
            this.panelQuanLyTD.Name = "panelQuanLyTD";
            this.panelQuanLyTD.Size = new System.Drawing.Size(1071, 110);
            this.panelQuanLyTD.TabIndex = 53;
            // 
            // tbMaBan
            // 
            this.tbMaBan.Enabled = false;
            this.tbMaBan.Location = new System.Drawing.Point(420, 59);
            this.tbMaBan.Name = "tbMaBan";
            this.tbMaBan.Size = new System.Drawing.Size(263, 22);
            this.tbMaBan.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(333, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã bàn:";
            // 
            // controlThaoTac
            // 
            this.controlThaoTac.Controls.Add(this.panelThaoTac);
            this.controlThaoTac.Location = new System.Drawing.Point(20, 141);
            this.controlThaoTac.Name = "controlThaoTac";
            this.controlThaoTac.Size = new System.Drawing.Size(1154, 141);
            this.controlThaoTac.TabIndex = 47;
            this.controlThaoTac.Text = "Thao tác";
            // 
            // panelThaoTac
            // 
            this.panelThaoTac.Controls.Add(this.btnThem);
            this.panelThaoTac.Controls.Add(this.btnXoa);
            this.panelThaoTac.Location = new System.Drawing.Point(17, 29);
            this.panelThaoTac.Name = "panelThaoTac";
            this.panelThaoTac.Size = new System.Drawing.Size(1097, 107);
            this.panelThaoTac.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(198, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(256, 63);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(614, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(256, 63);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(81, 312);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 229);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maBan
            // 
            this.maBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maBan.DataPropertyName = "maBan";
            this.maBan.HeaderText = "Mã Bàn";
            this.maBan.Name = "maBan";
            this.maBan.ReadOnly = true;
            // 
            // Form_QL_QuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_QL_QuanLyBan";
            this.Text = "Quản Lý Bàn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_QL_QuanLyBan_FormClosed);
            this.Load += new System.EventHandler(this.Form_QL_QuanLyBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panelQuanLyTD.ResumeLayout(false);
            this.panelQuanLyTD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlThaoTac)).EndInit();
            this.controlThaoTac.ResumeLayout(false);
            this.panelThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panelQuanLyTD;
        private DevExpress.XtraEditors.TextEdit tbMaBan;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl controlThaoTac;
        private System.Windows.Forms.Panel panelThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBan;
    }
}