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
    public interface IHandlerForm
    {
         object GetValue(object obj);
        void SetValue(Control control, object obj);
    }

    public abstract class AHandlerForm : IHandlerForm
    {
        public  object  GetValue(object obj) { return obj; }
        public  void SetValue(Control control,object obj) {
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

    public class BindingDataForm
    {
        Dictionary<string, Label> show_error = new Dictionary<string, Label>();
        Dictionary<string, Control> input = new Dictionary<string, Control>();
        Dictionary<string, IHandlerForm> handers = new Dictionary<string, IHandlerForm>();
        List<string> errrs = new List<string>();
        object obj = null;
        HandleTextBox handleText = new HandleTextBox();

        public BindingDataForm setBindInput(string name, Control control, IHandlerForm hander = null)
        {
            var __handler = new System.EventHandler((object sender, EventArgs e) =>
            {
                object value = handleText.GetValue(sender);
                if (hander != null)
                {
                    value = hander.GetValue(sender);
                }
                Type objtype = this.obj.GetType();

                PropertyInfo item = objtype.GetProperties().FirstOrDefault(t => t.Name == name);
                if (item != null)
                {
                    item.SetValue(obj, value);
                }
            });
            control.TextChanged += new System.EventHandler(__handler);
            if(control.GetType().Name == "CheckBox")
            {
                ((CheckBox)control).CheckedChanged += new System.EventHandler(__handler);
            }
            if (control.GetType().Name == "CheckBox")
            {
                ((DateTimePicker)control).ValueChanged += new System.EventHandler(__handler);
            }
            this.input.Add(name, control);
            if(hander != null)
            {
                this.handers.Add(name, hander);
            }
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
                    if (handers.ContainsKey(p.Name))
                    {
                        var hander = handers[p.Name];
                        hander.SetValue(control, p.GetValue(obj));
                    }else
                    {
                        try
                        {
                            handleText.SetValue(control, p.GetValue(obj));
                        }
                        catch(Exception ex)
                        {
                            Console.Write(ex);
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
                        if (!keyAttribute(a, p))
                        {
                            success = false;
                        }
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

        private bool keyAttribute(Attribute a, PropertyInfo p)
        {

            if (a.GetType().Name == "KeyAttribute")
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

        private bool Required(Attribute a, PropertyInfo p)
        {
            object o = p.GetValue(obj);
            if (o == "")
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
                if (!Required(a, p) || o == "" || o == null)
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
