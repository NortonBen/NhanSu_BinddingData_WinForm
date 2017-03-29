using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.Helper
{
    class ControlForm
    {
        Button btn_add = null;
        Button btn_edit = null;
        Button btn_save = null;
        Button btn_del = null;
        Button btn_cancel = null;
        List<Control> list_bt = new List<Control>();
        Control key = null;
        IActionClick ActionClick = null;
        StateForm state = StateForm.None;

        public ControlForm setActionClick(IActionClick ActionClick)
        {
            this.ActionClick = ActionClick;
            return this;
        }
        public ControlForm setButton(Button btn_add, Button btn_edit, Button btn_save, Button btn_del, Button btn_cancel)
        {
            this.btn_add = btn_add;
            this.btn_add.Click += new EventHandler(this.btn_them_Click);
            this.btn_cancel = btn_cancel;
            this.btn_cancel.Click += new EventHandler(this.btn_huy_Click);
            this.btn_del = btn_del;
            this.btn_del.Click += new EventHandler(this.btn_xoa_Click);
            this.btn_edit = btn_edit;
            this.btn_edit.Click += new EventHandler(this.btn_sua_Click);
            this.btn_save = btn_save;
            this.btn_save.Click += new EventHandler(this.btn_luu_Click);
            return this;
        }

        public ControlForm addTextBox(Control tb,bool _key = false)
        {
            list_bt.Add(tb);
            if (_key)
            {
                this.key = tb;
            }
            return this;
        }


        public ControlForm setState(StateForm state)
        {
            if(state == StateForm.None)
            {
                this.State_None();
            }
            if(state == StateForm.Show)
            {
                this.State_Show();
            }
            this.state = state;
            return this;
        }

        private void State_None()
        {
            list_bt.ForEach(item =>
            {
                item.Enabled = false;
            });
            this.btn_add.Enabled = true;
            this.btn_cancel.Enabled = false;
            this.btn_save.Enabled = false;
            this.btn_edit.Enabled = false;
            this.btn_del.Enabled = false;
            ActionClick.action(StateForm.None);
        }

        private void State_Show()
        {
            bool able = false;
            list_bt.ForEach(item =>
            {
                if(item.Text != null)
                {
                    able = true;
                }
            });
            this.btn_edit.Enabled = able;
            this.btn_del.Enabled = able;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            list_bt.ForEach(item =>
            {
                item.Enabled = true;
            });
            this.btn_add.Enabled = false;
            this.btn_cancel.Enabled = true;
            this.btn_save.Enabled = true;
            this.btn_edit.Enabled = false;
            this.btn_del.Enabled = false;
            ActionClick.action(StateForm.None);
            state = StateForm.New;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            list_bt.ForEach(item =>
            {
                if (key != item)
                {
                    item.Enabled = true;
                }
            });
            this.btn_add.Enabled = false;
            this.btn_cancel.Enabled = true;
            this.btn_save.Enabled = true;
            this.btn_edit.Enabled = false;
            this.btn_del.Enabled = false;
            state = StateForm.Edit;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (ActionClick != null)
            {
                if (!ActionClick.action(StateForm.Del))
                {
                    return;
                };
            }
            list_bt.ForEach(item =>
            {
                item.Enabled = false;
            });
            this.btn_add.Enabled = true;
            this.btn_cancel.Enabled = false;
            this.btn_save.Enabled = false;
            this.btn_edit.Enabled = false;
            this.btn_del.Enabled = false;
            ActionClick.action(StateForm.None);
            state = StateForm.None;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
          
            if (ActionClick != null)
            {
                if (!ActionClick.action(state))
                {
                    return;
                };
            }
            list_bt.ForEach(item =>
            {
                item.Enabled = false;
            });
            this.btn_add.Enabled = true;
            this.btn_cancel.Enabled = false;
            this.btn_save.Enabled = false;
            this.btn_edit.Enabled = false;
            this.btn_del.Enabled = false;
            ActionClick.action(StateForm.None);
            state = StateForm.None;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            list_bt.ForEach(item =>
            {
                item.Enabled = false;
            });
            this.btn_add.Enabled = true;
            this.btn_cancel.Enabled = false;
            this.btn_save.Enabled = false;
            this.btn_edit.Enabled = false;
            this.btn_del.Enabled = false;
            state = StateForm.None;
            ActionClick.action(StateForm.None);
        }
    }


    public interface IActionClick
    {
        bool action(StateForm state);
    }
}
