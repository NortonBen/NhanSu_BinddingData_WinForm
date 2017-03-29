using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.Helper
{
    class HandleDouble : IHandlerForm
    {
        public object GetValue(object obj)
        {
            try
            {
                return Convert.ToDouble(((Control)obj).Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Du Liệu không họp lệ");
            }
            return 0;
            
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
