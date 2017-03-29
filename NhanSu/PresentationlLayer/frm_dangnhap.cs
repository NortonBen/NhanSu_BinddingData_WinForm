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
    public partial class frm_dangnhap : Form
    {
        public bool islogin { get; set; }
        BindingDataForm form = new BindingDataForm();
        BLY_DangNhap _data = new BLY_DangNhap();
        User user = new User();
        public frm_dangnhap()
        {
            InitializeComponent();
            form.setBindInput("email", tb_email,lb_email)
                .setBindInput("password", tb_password,lb_pasword)
                .setObject(user);
            islogin = false;
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (form.isValidation())
            {
                if (_data.login(user))
                {
                    islogin = true;
                    this.Dispose();
                }else
                {
                    MessageBox.Show("Email hoặc Password sai!");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
