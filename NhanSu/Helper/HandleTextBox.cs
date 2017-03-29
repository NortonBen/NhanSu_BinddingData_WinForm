using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.Helper
{
    class HandleTextBox : IHandlerForm
    {
        public object GetValue(object obj)
        {
           return ((Control)obj).Text;
        }

        public void SetValue(Control control, object obj)
        {
            if (obj == null)
            {
                control.Text = "";
            }
            else
            {
                control.Text = obj.ToString();
            }
        }
    }
}
