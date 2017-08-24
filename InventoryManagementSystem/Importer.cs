using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LinqToExcel;

namespace InventoryManagementSystem
{
    public partial class Importer : Form
    {
        public Importer()
        {
            InitializeComponent();
            var execelfile = new ExcelQueryFactory("RZ.xls");
            var sheet = from a in execelfile.Worksheet(0) select a;
            int s = sheet.Count();
            MessageBox.Show(s.ToString());
        }
    }
}
