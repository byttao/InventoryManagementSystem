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
    public partial class ch_Home : Form
    {
        public ch_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new FPimport().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new XFPimport().Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            new XFPimport().Show();
        }
    }
}
