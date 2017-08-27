using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class FPinput : Form
    {
        private string dbPath = Properties.Settings.Default.Accname;
        private DateTime dt;
        public FPinput()
        {
            InitializeComponent();

            using (SqliteDataContext dc = new SqliteDataContext(dbPath))
            {
                var query = dc.GetTable<JCB基础表>().Select(u => u);
                foreach (var a in query)
                {
                    label2.Text = a.MC名称;
                    label3.Text = a.SH税号;
                    DRKRQ.Value = a.YF月份;
                    DKPRQ.Value = a.YF月份;
                    dt = a.YF月份;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            TSH.Text = TSH.Text.ToUpper();
        }

        private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        {
            THJ.Text = (TJE.Value+ TSE.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xhmax = 0;
            using (SqliteDataContext dc = new SqliteDataContext(dbPath))
            {
                if (dc.GetTable<JXFP进项发票>().Count() > 0)
                {
                    var query = dc.GetTable<JXFP进项发票>().Max(p => p.XH序号);
                    xhmax = query;
                }
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + dbPath + ".db;Version=3;");
            m_dbConnection.Open();
            string sql = "insert into JXFP进项发票 (XH序号,FPDM发票代码,FPHM发票号码,SH税号,KPSJ开票时间,JE金额,SE税额,RZSJ认证时间) values " +
                         "( " + (xhmax + 1) + ", '" + TFPDM.Text + "', '" + TFPHM.Text + "', '" + TSH.Text + "', '" +
                         DKPRQ.Value.ToString("yyyy-MM-dd") + "', " + TJE.Value + " , " + TSE.Value + ", '" + DRKRQ.Value.ToString("yyyy-MM-dd") + "')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            MessageBox.Show("导入成功！");
            TFPDM.Text = "";
            TFPHM.Text = "";
            DRKRQ.Value = dt;
            DKPRQ.Value = dt;
            TJE.Value = 0;
            TSE.Value = 0;
            TSH.Text = "";
        }
    }
}
