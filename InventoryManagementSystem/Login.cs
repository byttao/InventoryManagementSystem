using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Login :  Form
    {

        string dbPath = @"MyDatabase";//链接基本数据库
        public Login()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "当前日期："+ DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Properties.Settings.Default.NowAcc = int.Parse(comboBox1.SelectedValue.ToString());
                //MainParent MP = new MainParent();
                //MP.Show();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                using (SqliteDataContext dc = new SqliteDataContext(dbPath))
                {
                    var query = dc.GetTable<YH用户>().Where(u => u.YHMC用户名称 == textBox1.Text).Select(u => u);
                    foreach (var u in query)
                    {
                        if (u.YHMM用户密码 == textBox2.Text)
                        {
                            var accounts = (from c in dc.GetTable<ZT账套>() select c).ToList();
                            comboBox1.DataSource = accounts;
                            comboBox1.DisplayMember = "MC名称";
                            comboBox1.ValueMember = "XH序号";
                            return;
                        }
                    }
                }
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0:N2}", Byte.MaxValue % 100)); //C#
        }
    }


}
