using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.Helper
{
    public  class BindDataGridView
    {
        IClickContent ClickContent = null;
        DataGridView gridView = null;
        object obj = null;

        public BindDataGridView(IClickContent ClickContent)
        {
            this.ClickContent = ClickContent;
        }

        public BindDataGridView()
        {

        }

        public BindDataGridView setGridView(DataGridView gridView)
        {
            this.gridView = gridView;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            return this;
        }

        public BindDataGridView setClickContent(IClickContent ClickContent)
        {
            this.ClickContent = ClickContent;
            return this;
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                var row = gridView.Rows[index].DataBoundItem;
                if (ClickContent != null)
                {
                    ClickContent.DataGridViewClick(row);
                }
            }
            gridView.Focus();    
        }
    }

    public interface IClickContent
    {
        void DataGridViewClick(object obj);
    }
}
