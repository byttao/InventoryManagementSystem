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
    public partial class FPimport : DevExpress.XtraEditors.XtraForm
    {
        public FPimport()
        {
            InitializeComponent();
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Excel 97-2003文件(*.xls)|*.xls|Excel 2007文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                buttonEdit1.Text = openFileDialog.FileName;
            }
        }
    }
}
