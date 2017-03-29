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
    public partial class frm_quyetdinh : Form, IClickContent, IActionClick
    {
        BindingDataForm form = new BindingDataForm();
        BindDataGridView gridview = new BindDataGridView();
        ControlForm controlForm = new ControlForm();
        BY_QuyetDinh _data = new BY_QuyetDinh();
        QuyetDinh quyetdinh = new QuyetDinh { ngayQD = DateTime.Now };

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

        public frm_quyetdinh()
        {
            InitializeComponent();
            form.setBindInput("SoQD", tb_quyetdinh)
                .setBindInput("MaNV", cb_manv,new handerNhanVien())
                .setBindInput("ngayQD", dp_ngay, new HandleDateTime())
                .setBindInput("NoiDung", tb_noidungqd)
                .setBindInput("TenQD", tb_tenquyetdinh)
                .setObject(quyetdinh);
            gridview.setClickContent(this).setGridView(dataGridView1);
            controlForm.setButton(btn_them, btn_sua, btn_luu, btn_xoa, btn_huy)
                .addTextBox(tb_quyetdinh, true)
                .addTextBox(cb_manv)
                .addTextBox(dp_ngay)
                .addTextBox(tb_noidungqd)
                .addTextBox(tb_tenquyetdinh)
                .setActionClick(this);
        }


        private void frm_quyetdinh_Load(object sender, EventArgs e)
        {
            this.quyetDinhBindingSource.DataSource = _data.getList();
            this.controlForm.setState(StateForm.None);
            this.cb_manv.DataSource = _data.getListNhanVien();
            this.cb_manv.DisplayMember = "TenNV";
            this.cb_manv.ValueMember = "MaNV";
        }


        public bool action(StateForm state)
        {
            if (state == StateForm.None)
            {
                this.quyetdinh = new QuyetDinh { ngayQD = DateTime.Now };
                form.setObject(quyetdinh);
                return true;
            }

            if (state == StateForm.New || state == StateForm.Edit)
            {
                quyetdinh.MaNV  = (new handerNhanVien()).GetValue(cb_manv).ToString();
                if (form.isValidation())
                {
                    if (state == StateForm.New)
                    {
                        _data.add(quyetdinh);
                    }

                    if (state == StateForm.Edit)
                    {
                        _data.update(quyetdinh);
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
                _data.delete(quyetdinh);
            }
            this.quyetDinhBindingSource.DataSource = _data.getList();
            this.Refresh();
            return true;
        }

        public void DataGridViewClick(object obj)
        {
            quyetdinh = (QuyetDinh)obj;
            form.setObject(this.quyetdinh);
            controlForm.setState(StateForm.Show);
        }

       
    }
}
