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
                object value  = ((Control)sender).Text;
                if (sender.GetType().Name=="ComboBox") 
                {

                    value = ((ComboBox)sender).Text;

                }
                if (sender.GetType().Name == "DateTimePicker")
                {
                    value = ((DateTimePicker)sender).Value;
                }
                Type objtype = this.obj.GetType();
                
                PropertyInfo item = objtype.GetProperties().FirstOrDefault(t => t.Name == name);
                if (item != null)
                {
                    item.SetValue(obj, value);
                }
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
                    if (control.GetType().Name == "TextBox")
                    {

                        if (p.GetValue(obj) == null)
                        {
                            control.Text = "";
                            continue;
                        }
                        else
                        {
                            control.Text = p.GetValue(obj).ToString();
                        }
                    }
                    if (input[p.Name].GetType().Name =="DateTimePicker")
                    {
                        DateTimePicker date = (DateTimePicker)input[p.Name];
                        var __data = p.GetValue(obj);
                        if (__data == null)
                        {
                            continue;
                        }
                        try
                        {
                            date.Value = (DateTime)__data;

                        }catch(Exception ex)
                        {
                            date.Value = DateTime.Now;

                        }


                    }
                }
            }
            foreach (PropertyInfo p in objtype.GetProperties())
            {
                if (show_error.ContainsKey(p.Name))
                {
                    Control control = show_error[p.Name];
                    if (p.GetValue(obj) == null)
                    {
                        control.Text = "";
                        continue;
                    }
                }
            }
            return this;
        }

        public bool isValidation()
        {
            bool success = true;
            Type objtype = obj.GetType();
            errrs = new List<string>();
            foreach (PropertyInfo p in objtype.GetProperties())
            {
                if (show_error.ContainsKey(p.Name))
                {
                    Control control = show_error[p.Name];
                    control.Text = "";
                }
                if (input.ContainsKey(p.Name))
                {
                    foreach (Attribute a in p.GetCustomAttributes(false))
                    {

                        if (!RequiredAttribute(a, p))
                        {
                            success = false;
                        }
                        if (!MinLengthAttribute(a, p))
                        {
                            success = false;
                        }
                        if (!MaxLengthAttribute(a, p))
                        {
                            success = false;
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

        private bool Required(Attribute a, PropertyInfo p)
        {
            object o = p.GetValue(obj);
            if (o == null)
            {
                if (show_error.ContainsKey(p.Name))
                {
                    Label label = show_error[p.Name];
                    label.Text = "Bạn Chưa nhập " + p.Name;
                }
                this.errrs.Add("Bạn Chưa nhập " + p.Name);

                return false;
            }
            return true;
        }

        private bool RequiredAttribute(Attribute a, PropertyInfo p)
        {
            if (a.GetType().Name == "RequiredAttribute")
            {
                object o = p.GetValue(obj);
                if (o == null)
                {
                    if (show_error.ContainsKey(p.Name))
                    {
                        Label label = show_error[p.Name];
                        label.Text = "Bạn Chưa nhập " + p.Name;
                    }
                    this.errrs.Add("Bạn Chưa nhập " + p.Name);

                    return false;
                }

            }
            return true;
        }

        private bool MaxLengthAttribute(Attribute a, PropertyInfo p)
        {
           
            if (a.GetType().Name == "MaxLengthAttribute")
            {
                MaxLengthAttribute max_a = (MaxLengthAttribute)a;
                string o = (string)p.GetValue(obj);
                if (!Required(a, p))
                {
                    return false;
                }
                if (o.Length > max_a.Length)
                {
                    
                    if (show_error.ContainsKey(p.Name))
                    {
                        Label label = show_error[p.Name];
                        label.Text = "Trường " + p.Name + " dài hơn " + max_a.Length + " kí tự";
                    }
                    this.errrs.Add("Trường " + p.Name + " dài hơn " + max_a.Length + " kí tự");

                    return false;
                }

            }
            return true;
        }

        private bool MinLengthAttribute(Attribute a, PropertyInfo p)
        {
           
            if (a.GetType().Name == "MinLengthAttribute")
            {
                if (!Required(a, p))
                {
                    return false;
                }
                MinLengthAttribute max_a = (MinLengthAttribute)a;
                string o = (string)p.GetValue(obj);
                if (o.Length < max_a.Length)
                {
                   
                    if (show_error.ContainsKey(p.Name))
                    {
                        Label label = show_error[p.Name];
                        label.Text = "Trường " + p.Name + " ngắn hơn " + max_a.Length + " kí tự";
                    }
                    errrs.Add("Trường " + p.Name + " ngắn hơn " + max_a.Length + " kí tự");

                    return true;
                }

            }
            return true;
        }
    }
}
