namespace NhanSu.PresentationlLayer
{
    partial class frm_quyetdinh
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.dp_ngay = new System.Windows.Forms.DateTimePicker();
            this.tb_quyetdinh = new System.Windows.Forms.TextBox();
            this.tb_tenquyetdinh = new System.Windows.Forms.TextBox();
            this.tb_noidungqd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayQDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyetDinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyetDinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.dp_ngay);
            this.groupBox1.Controls.Add(this.tb_quyetdinh);
            this.groupBox1.Controls.Add(this.tb_tenquyetdinh);
            this.groupBox1.Controls.Add(this.tb_noidungqd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(109, 87);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(161, 21);
            this.cb_manv.TabIndex = 11;
            // 
            // dp_ngay
            // 
            this.dp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ngay.Location = new System.Drawing.Point(381, 89);
            this.dp_ngay.Name = "dp_ngay";
            this.dp_ngay.Size = new System.Drawing.Size(163, 20);
            this.dp_ngay.TabIndex = 10;
           
            // 
            // tb_quyetdinh
            // 
            this.tb_quyetdinh.Location = new System.Drawing.Point(109, 25);
            this.tb_quyetdinh.Name = "tb_quyetdinh";
            this.tb_quyetdinh.Size = new System.Drawing.Size(161, 20);
            this.tb_quyetdinh.TabIndex = 8;
            // 
            // tb_tenquyetdinh
            // 
            this.tb_tenquyetdinh.Location = new System.Drawing.Point(109, 56);
            this.tb_tenquyetdinh.Name = "tb_tenquyetdinh";
            this.tb_tenquyetdinh.Size = new System.Drawing.Size(161, 20);
            this.tb_tenquyetdinh.TabIndex = 7;
            // 
            // tb_noidungqd
            // 
            this.tb_noidungqd.Location = new System.Drawing.Point(381, 28);
            this.tb_noidungqd.Multiline = true;
            this.tb_noidungqd.Name = "tb_noidungqd";
            this.tb_noidungqd.Size = new System.Drawing.Size(163, 44);
            this.tb_noidungqd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày QĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nội dung QĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên quyết định";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số quyết định";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(243, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUYẾT ĐỊNH ";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(361, 74);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(136, 20);
            this.tb_timkiem.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(24, 247);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(146, 247);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(269, 247);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(393, 247);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soQDDataGridViewTextBoxColumn,
            this.tenQDDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.ngayQDDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.nhanVienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quyetDinhBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 195);
            this.dataGridView1.TabIndex = 7;
            // 
            // soQDDataGridViewTextBoxColumn
            // 
            this.soQDDataGridViewTextBoxColumn.DataPropertyName = "SoQD";
            this.soQDDataGridViewTextBoxColumn.HeaderText = "SoQD";
            this.soQDDataGridViewTextBoxColumn.Name = "soQDDataGridViewTextBoxColumn";
            this.soQDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenQDDataGridViewTextBoxColumn
            // 
            this.tenQDDataGridViewTextBoxColumn.DataPropertyName = "TenQD";
            this.tenQDDataGridViewTextBoxColumn.HeaderText = "TenQD";
            this.tenQDDataGridViewTextBoxColumn.Name = "tenQDDataGridViewTextBoxColumn";
            this.tenQDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayQDDataGridViewTextBoxColumn
            // 
            this.ngayQDDataGridViewTextBoxColumn.DataPropertyName = "ngayQD";
            this.ngayQDDataGridViewTextBoxColumn.HeaderText = "ngayQD";
            this.ngayQDDataGridViewTextBoxColumn.Name = "ngayQDDataGridViewTextBoxColumn";
            this.ngayQDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhanVienDataGridViewTextBoxColumn
            // 
            this.nhanVienDataGridViewTextBoxColumn.DataPropertyName = "NhanVien";
            this.nhanVienDataGridViewTextBoxColumn.HeaderText = "NhanVien";
            this.nhanVienDataGridViewTextBoxColumn.Name = "nhanVienDataGridViewTextBoxColumn";
            this.nhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quyetDinhBindingSource
            // 
            this.quyetDinhBindingSource.DataSource = typeof(NhanSu.DataAccessLayer.QuyetDinh);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(502, 247);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 8;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // frm_quyetdinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 495);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_quyetdinh";
            this.Text = "frm_quyetdinh";
            this.Load += new System.EventHandler(this.frm_quyetdinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyetDinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_quyetdinh;
        private System.Windows.Forms.TextBox tb_tenquyetdinh;
        private System.Windows.Forms.TextBox tb_noidungqd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dp_ngay;
        private System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource quyetDinhBindingSource;
    }
}