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
    public partial class frm_nhanvien : Form, IClickContent, IActionClick
    {
        BindingDataForm form = new BindingDataForm();
        BindDataGridView gridview = new BindDataGridView();
        ControlForm controlForm = new ControlForm();
        BY_NhanVien _data = new BY_NhanVien();
        NhanVien nhanvien = new NhanVien {  NamSinh = DateTime.Now, GioiTinh = "nam" };
        class handerPhong : IHandlerForm
        {
            public object GetValue(object obj)
            {
                var cb = (ComboBox)obj;
                var val = cb.SelectedValue;
                if (val.GetType().Name == "String")
                {
                    return val;
                }
                var a = (Phong)val;
                return a.Map;
            }

            public void SetValue(Control control, object obj)
            {
                var cb = (ComboBox)control;
                if(obj != null)
                {
                    cb.SelectedValue = obj;
                }
            }
        }
        class handerCheckBox : IHandlerForm
        {
            public void SetValue(Control control, object obj)
            {
                if(obj != null)
                {
                    if (obj.ToString() == "nam")
                    {
                        ((CheckBox)control).Checked = true;
                    }
                    else
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }else
                {
                    obj = "nữ";
                }
               
            }

            public object GetValue(object obj)
            {
                if (((CheckBox)obj).Checked)
                {
                    return "nam";
                }
                return "nữ";
            }
        }
        public frm_nhanvien()
        {
            InitializeComponent();
            form.setBindInput("MaNV", tb_manv)
                .setBindInput("MaP", comboBox1,new handerPhong())
                .setBindInput("TenNV", tb_tennv)
                .setBindInput("quequan", tb_que)
                .setBindInput("dantoc", tb_dtoc)
                .setBindInput("ngoaingu", tb_ngoaingu)
                .setBindInput("trinhdo", tb_trinhdo)
                .setBindInput("GioiTinh", cb_gt, new handerCheckBox())
                .setBindInput("NgaySinh", dtp_ngaysinh,new HandleDateTime())
                .setObject(nhanvien);
            gridview.setClickContent(this).setGridView(dataGridView1);
            controlForm.setButton(btn_them, btn_sua, btn_luu, btn_xoa, btn_huy)
                .addTextBox(tb_manv, true)
                .addTextBox(tb_tennv)
                .addTextBox(tb_ngoaingu)
                .addTextBox(tb_que)
                .addTextBox(tb_dtoc)
                .addTextBox(dtp_ngaysinh)
                .addTextBox(cb_gt)
                .addTextBox(comboBox1)
                .addTextBox(tb_trinhdo)
                .setActionClick(this);

        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            this.nhanVienBindingSource.DataSource = _data.getList();
            this.controlForm.setState(StateForm.None);
            this.comboBox1.DataSource = _data.getListPhong();
            this.comboBox1.DisplayMember = "TenP";
            this.comboBox1.ValueMember = "MaP";
        }

        public bool action(StateForm state)
        {
            if (state == StateForm.None)
            {
                this.nhanvien = new NhanVien { NamSinh = DateTime.Now , GioiTinh = "nam"};
                this.cb_gt.Checked = true;
                form.setObject(nhanvien);
                return true;
            }

            if (state == StateForm.New || state == StateForm.Edit)
            {
                if (form.isValidation())
                {
                    if (state == StateForm.New)
                    {
                        _data.add(nhanvien);
                    }

                    if (state == StateForm.Edit)
                    {
                        _data.update(nhanvien);
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
                _data.delete(nhanvien);
            }
            this.nhanVienBindingSource.DataSource = _data.getList();
            this.Refresh();
            return true;
        }

        public void DataGridViewClick(object obj)
        {
            nhanvien = (NhanVien)obj;
            form.setObject(this.nhanvien);
            controlForm.setState(StateForm.Show);
        }
    }
}
