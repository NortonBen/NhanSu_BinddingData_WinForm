using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanSu.Helper;
using NhanSu.BusinessLogicLayer;
using NhanSu.DataAccessLayer;

namespace NhanSu.PresentationlLayer
{
    public partial class frm_phong : Form, IClickContent,IActionClick
    {
        BindingDataForm form = new BindingDataForm();
        BindDataGridView gridview = new BindDataGridView();
        ControlForm controlForm = new ControlForm();
        BY_Phong _data = new BY_Phong();
        Phong phong = new Phong();
        public frm_phong()
        {
            InitializeComponent();
            form.setBindInput("Map", tb_map).setBindInput("TenP", tb_tenp).setObject(phong);
            gridview.setClickContent(this).setGridView(dataGridView1);
            controlForm.setButton(btn_them, btn_sua, btn_luu, btn_xoa, btn_huy)
                .addTextBox(tb_map,true).addTextBox(tb_tenp)
                .setActionClick(this);
        }

        private void frm_phong_Load(object sender, EventArgs e)
        {
            this.phongBindingSource.DataSource = _data.getList();
            this.controlForm.setState(StateForm.None);
        }

        public void DataGridViewClick(object obj)
        {
            var phong = (Phong)obj;
            this.phong = new Phong { Map = phong.Map, TenP = phong.TenP };
            form.setObject(this.phong);
            controlForm.setState(StateForm.Show);
        }

        public bool action(StateForm state)
        {
            if(state == StateForm.None)
            {
                this.phong = new Phong();
                form.setObject(phong);
                return true;
            }
            if(state == StateForm.New  || state == StateForm.Edit)
            {
                if (form.isValidation())
                {
                    if (state == StateForm.New)
                    {
                        _data.add(phong);
                    }

                    if (state == StateForm.Edit)
                    {
                        _data.update(phong);
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
                _data.delete(phong);
            }
            this.phongBindingSource.DataSource = _data.getList();
            this.Refresh();
            return true;
        }

    }
}
