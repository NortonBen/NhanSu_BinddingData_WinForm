using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanSu.PresentationlLayer;

namespace NhanSu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_dangnhap form = new frm_dangnhap();
            form.ShowDialog();
            if (form.islogin)
            {
                Application.Run(new frm_hopdong());
            }
        }
    }
}
