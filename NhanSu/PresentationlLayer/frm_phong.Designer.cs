namespace NhanSu.PersentationlLayer
{
    partial class frm_phong
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
            this.tbTenP = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbMaP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_Map = new System.Windows.Forms.Label();
            this.lb_TenP = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.mapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_SDT);
            this.groupBox1.Controls.Add(this.lb_DiaChi);
            this.groupBox1.Controls.Add(this.lb_TenP);
            this.groupBox1.Controls.Add(this.lb_Map);
            this.groupBox1.Controls.Add(this.tbTenP);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbMaP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(23, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbTenP
            // 
            this.tbTenP.Location = new System.Drawing.Point(92, 75);
            this.tbTenP.Name = "tbTenP";
            this.tbTenP.Size = new System.Drawing.Size(164, 20);
            this.tbTenP.TabIndex = 17;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(374, 75);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(167, 20);
            this.tbSDT.TabIndex = 16;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(374, 30);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(167, 20);
            this.tbDiaChi.TabIndex = 15;
            // 
            // tbMaP
            // 
            this.tbMaP.Location = new System.Drawing.Point(92, 27);
            this.tbMaP.Name = "tbMaP";
            this.tbMaP.Size = new System.Drawing.Size(164, 20);
            this.tbMaP.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "SDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tên phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(187, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "PHÒNG";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(270, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(489, 196);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(386, 196);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapDataGridViewTextBoxColumn,
            this.tenPDataGridViewTextBoxColumn,
            this.diaChiPDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 137);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // lb_Map
            // 
            this.lb_Map.AutoSize = true;
            this.lb_Map.Location = new System.Drawing.Point(94, 55);
            this.lb_Map.Name = "lb_Map";
            this.lb_Map.Size = new System.Drawing.Size(35, 13);
            this.lb_Map.TabIndex = 18;
            this.lb_Map.Text = "label1";
            // 
            // lb_TenP
            // 
            this.lb_TenP.AutoSize = true;
            this.lb_TenP.Location = new System.Drawing.Point(94, 101);
            this.lb_TenP.Name = "lb_TenP";
            this.lb_TenP.Size = new System.Drawing.Size(35, 13);
            this.lb_TenP.TabIndex = 19;
            this.lb_TenP.Text = "label2";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(371, 55);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(35, 13);
            this.lb_DiaChi.TabIndex = 20;
            this.lb_DiaChi.Text = "label3";
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(371, 101);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(35, 13);
            this.lb_SDT.TabIndex = 21;
            this.lb_SDT.Text = "label4";
            // 
            // mapDataGridViewTextBoxColumn
            // 
            this.mapDataGridViewTextBoxColumn.DataPropertyName = "Map";
            this.mapDataGridViewTextBoxColumn.HeaderText = "Map";
            this.mapDataGridViewTextBoxColumn.Name = "mapDataGridViewTextBoxColumn";
            this.mapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenPDataGridViewTextBoxColumn
            // 
            this.tenPDataGridViewTextBoxColumn.DataPropertyName = "TenP";
            this.tenPDataGridViewTextBoxColumn.HeaderText = "TenP";
            this.tenPDataGridViewTextBoxColumn.Name = "tenPDataGridViewTextBoxColumn";
            this.tenPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiPDataGridViewTextBoxColumn
            // 
            this.diaChiPDataGridViewTextBoxColumn.DataPropertyName = "DiaChiP";
            this.diaChiPDataGridViewTextBoxColumn.HeaderText = "DiaChiP";
            this.diaChiPDataGridViewTextBoxColumn.Name = "diaChiPDataGridViewTextBoxColumn";
            this.diaChiPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(NhanSu.DataAccessLayer.Phong);
            // 
            // frm_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "frm_phong";
            this.Load += new System.EventHandler(this.frm_phong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTenP;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbMaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_TenP;
        private System.Windows.Forms.Label lb_Map;
    }
}