using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class RKDLR : Form
    {
        private DataTable dt = new DataTable();
        
        public RKDLR()
        {
            InitializeComponent();
            dt.Columns.Add("MC", typeof(string));
            dt.Columns.Add("DW", typeof(string));
            dt.Columns.Add("SL", typeof(decimal));
            dt.Columns.Add("DJ", typeof(decimal));
            dt.Columns.Add("JE", typeof(decimal));
            dt.Columns.Add("BZ", typeof(string));
            gridControl1.DataSource = dt;
        }

        private void RKDLR_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && gridControl1.Focused== true)
            {
                gridView1.DeleteSelectedRows();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar== (char)Keys.Delete )
            //{
            //    MessageBox.Show("Test");
            //    List<int> selectedRows;
            //    //筛选选中的行，非数据行的不要。
            //    selectedRows = gridView1.GetSelectedRows().Where((t) => t >= 0).ToList();
            //    foreach (int i in selectedRows)
            //    {
            //        gridView1.GetDataRow(i).Delete();
            //    }
            //}
        }
    }
}
