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
    public partial class frm_nhanvien : Form
    {
        private BLY_NhanVien data = new BLY_NhanVien();
        private NhanVien nhanvien = new NhanVien();
        private BindingDataForm bind = new BindingDataForm();
        private StateForm state = StateForm.New;
        public frm_nhanvien()

        {
            InitializeComponent();
            bind.setBindInput("MaNV", tb_manhanvien);
            bind.setBindInput("MaP", tb_maphong);
            bind.setBindInput("TenNV", tb_ten);
            bind.setBindInput("NgayVaoCty",tb_ngayvao);
            bind.setBindInput("MaCV",tb_machucvu);
            bind.setBindInput("NamSih", tb_nam);
            bind.setBindInput("DiaChi", tb_diachi);
            bind.setBindInput("SDT", tb_sdt);
            bind.setBindInput("GioiTinh", tb_gt);
            nhanvien.NgayVaoCty = DateTime.Now;
            nhanvien.NamSinh = DateTime.Now;
            bind.setObject(nhanvien);
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            this.loadList();
           //his.cb_phong.DataSource = data.getListPhong();
            //is.cb_phong.DisplayMember = "MaP";
           //his.cb_phong.ValueMember = "MaP";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.newItem();
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           //string s = txtSearch.Text;
           //NhanVien ketqua = data.search(s);
           // if (ketqua!=null)
           // {
           //     dataGridView1.DataSource = ketqua;
           // }
        }

        private void tb_manhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_maphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void loadList()
        {
            this.nhanVienBindingSource.DataSource = data.getList();
        }

        private void newItem()
        {
            state = StateForm.New;
            nhanvien = new NhanVien();
            bind.setObject(nhanvien);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bind.isValidation())
            {
                if (state == StateForm.New)
                {
                    data.add(nhanvien);
                    this.newItem();
                }
                if (state == StateForm.Edit)
                {
                    data.update(nhanvien);
                    this.newItem();
                }
                this.loadList();

            }else
            {
                MessageBox.Show(bind.getErrors()[0]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
