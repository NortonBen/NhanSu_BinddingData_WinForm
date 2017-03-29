using NhanSu.BusinessLogicLayer;
using NhanSu.DataAccessLayer;
using NhanSu.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.PresentationlLayer
{
    public partial class frm_hopdong : Form, IClickContent, IActionClick
    {
        BindingDataForm form = new BindingDataForm();
        BindDataGridView gridview = new BindDataGridView();
        ControlForm controlForm = new ControlForm();
        BL_HopDong _data = new BL_HopDong();
        HopDong hopdong = new HopDong { ngayHD = DateTime.Now , ngayKT = DateTime.Now};

        class handerNhanVien : IHandlerForm
        {
            public object GetValue(object obj)
            {
                var cb = (ComboBox)obj;
                var val = cb.SelectedValue;
                if (val.GetType().Name == "String")
                {
                    return val;
                }
                var a = (NhanVien)val;
                return a.MaNV;
            }

            public void SetValue(Control control, object obj)
            {
                var cb = (ComboBox)control;
                if (obj != null)
                {
                    cb.SelectedValue = obj;
                }
            }
        }
        public frm_hopdong()
        {
            InitializeComponent();
            form.setBindInput("SoHD", tb_hopsong)
                .setBindInput("TenHD", tb_tenhopdong)
                .setBindInput("luongcb", tb_lcb, new HandleDouble())
                .setBindInput("phucap", tb_phucap, new HandleDouble())
                .setBindInput("ngayHD", dp_ngki, new HandleDateTime())
                .setBindInput("ngayKT", dp_ngkt,new HandleDateTime())
                .setBindInput("MaNV", cb_mavn, new handerNhanVien())
                .setObject(hopdong);
            gridview.setClickContent(this).setGridView(dataGridView1);
            controlForm.setButton(btn_them, btn_sua, btn_luu, btn_xoa, btn_huy)
                .addTextBox(tb_hopsong, true)
                .addTextBox(tb_tenhopdong)
                .addTextBox(tb_lcb)
                .addTextBox(tb_phucap)
                .addTextBox(dp_ngki)
                .addTextBox(dp_ngkt)
                .addTextBox(cb_mavn)
                .setActionClick(this);

        }


        private void frm_hopdong_Load(object sender, EventArgs e)
        {
            this.hopDongBindingSource.DataSource = _data.getList();
            this.controlForm.setState(StateForm.None);
            this.cb_mavn.DataSource = _data.getListNhanVien();
            this.cb_mavn.DisplayMember = "TenNV";
            this.cb_mavn.ValueMember = "MaNV";
        }


        public bool action(StateForm state)
        {
            if (state == StateForm.None)
            {
                this.hopdong = new HopDong { ngayHD = DateTime.Now, ngayKT = DateTime.Now };
                form.setObject(hopdong);
                return true;
            }

            if (state == StateForm.New || state == StateForm.Edit)
            {
                hopdong.MaNV = (new handerNhanVien()).GetValue(cb_mavn).ToString();
                if (form.isValidation())
                {
                    if (state == StateForm.New)
                    {
                        _data.add(hopdong);
                    }

                    if (state == StateForm.Edit)
                    {
                        _data.update(hopdong);
                    }
                }
                else
                {
                    MessageBox.Show(form.getErrors()[0]);
                    return false;
                }

            }


            if (state == StateForm.Del)
            {
                _data.delete(hopdong);
            }
            this.hopDongBindingSource.DataSource = _data.getList();
            this.Refresh();
            return true;
        }

        public void DataGridViewClick(object obj)
        {
            hopdong = (HopDong)obj;
            form.setObject(this.hopdong);
            controlForm.setState(StateForm.Show);
        }

    }
}
