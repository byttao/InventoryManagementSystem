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
    public partial class MainParent : Form
    {
        string dbPath = Properties.Settings.Default.Accname;//链接对应数据库

        public MainParent()
        {
            InitializeComponent();
            if (new Login().ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            int i = Properties.Settings.Default.NowAcc;
            using (SqliteDataContext dc = new SqliteDataContext("MyDatabase"))
            {
                var query = dc.GetTable<ZT账套>().Where(u => u.XH序号 == i).Select(u => u);
                foreach (var u in query)
                {
                    barStaticItem1.Caption = "账套：" + u.MC名称;
                }
            }
            ch_Home ch = new ch_Home
            {
                TopLevel = false,
                Visible = true,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            DevExpress.XtraBars.Navigation.NavigationPage page = new DevExpress.XtraBars.Navigation.NavigationPage();
            page.Controls.Add(ch);
            page.PageText = "主界面";
            navigationPane1.Pages.Add(page);
        }
      

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
