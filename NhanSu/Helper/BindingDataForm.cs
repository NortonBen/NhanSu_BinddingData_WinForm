using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.Helper
{
    class BindingDataForm
    {
        Dictionary<string, Label> show_error = new Dictionary<string, Label>();
        Dictionary<string, Control> input = new Dictionary<string, Control>();
        List<string> errrs = new List<string>();
        object obj = null;

        public BindingDataForm setBindInput(string name, Control control)
        {
            control.TextChanged += new System.EventHandler((object sender, EventArgs e) =>
            {
                object value = ((Control)sender).Text;
                Type objtype = this.obj.GetType();
                PropertyInfo item = objtype.GetProperties().FirstOrDefault(t => t.Name == name);
                item.SetValue(obj, value, null);
            });
            this.input.Add(name, control);
            return this;
        }

        public BindingDataForm setBindInput(string name, Control control, Label show_error)
        {
            this.setBindInput(name, control);
            this.show_error.Add(name, show_error);
            return this;
        }

        public BindingDataForm setObject(object obj)
        {
            this.obj = obj;
            Type objtype = obj.GetType();
            foreach (PropertyInfo p in objtype.GetProperties())
            {
                if (input.ContainsKey(p.Name))
                {
                    Control control = input[p.Name];
                    if(p.GetValue(obj) == null)
                    {
                        control.Text = "";
                        continue;
                    }
                    control.Text = p.GetValue(obj).ToString();
                }
            }
            return this;
        }

        public bool isValidation()
        {
            bool success = true;
            Type objtype = obj.GetType();
            foreach (PropertyInfo p in objtype.GetProperties())
            {
                if (input.ContainsKey(p.Name))
                {
                    foreach (Attribute a in p.GetCustomAttributes(false))
                    {
                        if (a.GetType().Name == "RequiredAttribute")
                        {
                            object o = p.GetConstantValue();
                            if (o == null)
                            {
                                success = false;
                                if (show_error.ContainsKey(p.Name))
                                {
                                    Label label = show_error[p.Name];
                                    label.Text = "Bạn Chưa nhập " + p.Name;
                                    errrs.Add("Bạn Chưa nhập " + p.Name);
                                }
                            }

                        }

                        if (a.GetType().Name == "MaxLengthAttribute")
                        {
                            MaxLengthAttribute max_a = (MaxLengthAttribute)a;
                            string o = (string)p.GetConstantValue();
                            if (o.Length > max_a.Length)
                            {
                                success = false;
                                if (show_error.ContainsKey(p.Name))
                                {
                                    Label label = show_error[p.Name];
                                    label.Text = "Trường " + p.Name + " dài hơn " + max_a.Length + " kí tự";
                                    errrs.Add("Trường " + p.Name + " dài hơn " + max_a.Length + " kí tự");
                                }
                            }

                        }

                        if (a.GetType().Name == "MinLengthAttribute")
                        {
                            MinLengthAttribute max_a = (MinLengthAttribute)a;
                            string o = (string)p.GetValue(obj);
                            if (o.Length < max_a.Length)
                            {
                                success = false;
                                if (show_error.ContainsKey(p.Name))
                                {
                                    Label label = show_error[p.Name];
                                    label.Text = "Trường " + p.Name + " ngắn hơn " + max_a.Length + " kí tự";
                                    errrs.Add("Trường " + p.Name + " ngắn hơn " + max_a.Length + " kí tự");
                                }
                            }

                        }
                    }
                }

            }
            return success;
        }

        public List<String> getErrors()
        {
            return this.errrs;
        }
    }
}
