using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.Helper
{
    class HandleDateTime : IHandlerForm
    {
        public object GetValue(object obj)
        {
           return ((DateTimePicker)obj).Value;
        }

        public void SetValue(Control control, object obj)
        {
            var date = (DateTimePicker)control;
            if (obj == null)
            {
                date.Value = DateTime.Now;
            }
            try
            {
                date.Value = DateTime.Parse(obj.ToString());
            }
            catch (Exception ex)
            {
                date.Value = DateTime.Now;
            }
        }
    }
}
