using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanSu.BusinessLogicLayer;
using NhanSu.DataAccessLayer;
using NhanSu.Helper;

namespace NhanSu.PersentationlLayer
{
    public partial class frm_phong : Form
    {
        private BLY_Phong _data = new BLY_Phong();
        private Phong phong = new Phong();
        private BindingDataForm bind = new BindingDataForm();
        private StateForm state = StateForm.New;
        public frm_phong()
        {
            InitializeComponent();
            bind.setBindInput("Map", tbMaP);
            bind.setBindInput("TenP", tbTenP);
            bind.setBindInput("DiaChiP", tbDiaChi);
            bind.setBindInput("SDT", tbSDT);
            bind.setObject(phong);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_phong_Load(object sender, EventArgs e)
        {
            this.phongBindingSource.DataSource = _data.getList();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            phong.Map = this.dataGridView1[0, index].Value.ToString();
            phong.TenP = this.dataGridView1[1, index].Value.ToString();
            phong.DiaChiP = this.dataGridView1[2, index].Value.ToString();
            phong.SDT = this.dataGridView1[3, index].Value.ToString();
            bind.setObject(phong);
            state = StateForm.Edit;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = StateForm.New;
            phong = new Phong();
            bind.setObject(phong);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(state == StateForm.New)
            {
                _data.add(phong);
                phong = new Phong();
                bind.setObject(phong);
            }
            if (state == StateForm.Edit)
            {
                _data.update(phong);
                phong = new Phong();
                bind.setObject(phong);
            }
            this.phongBindingSource.DataSource = _data.getList();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            _data.delete(phong);
            phong = new Phong();
            bind.setObject(phong);
            this.phongBindingSource.DataSource = _data.getList();
        }
    }
}
