using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data.SQLite;
using System.Data.Common;

namespace InventoryManagementSystem
{
    public partial class FPimport : Form
    {
        DataTable dt = new DataTable("认证发票");
        private string 账套名 = Properties.Settings.Default.Accname;
        public FPimport()
        {
            InitializeComponent();
            dt.Columns.Add("发票代码", typeof(string));
            dt.Columns.Add("发票号码", typeof(string));
            dt.Columns.Add("认证方纳税人识别号", typeof(string));
            dt.Columns.Add("销售方纳税人识别号", typeof(string));
            dt.Columns.Add("开票日期", typeof(DateTime));
            dt.Columns.Add("金额", typeof(decimal));
            dt.Columns.Add("税额", typeof(decimal));
            dt.Columns.Add("认证时间", typeof(DateTime));
            dt.Columns.Add("发票类别", typeof(string));
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "Excel 97-2003文件(*.xls)|*.xls|Excel 2007文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                buttonEdit1.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = buttonEdit1.Text;
            IWorkbook wk = null;
            FileStream fs = new FileStream(ss, FileMode.Open, FileAccess.Read);
            //获取后缀名
            string extension = ss.Substring(ss.LastIndexOf(".")).ToLower();
            //判断是否是excel文件
            if (extension == ".xlsx" || extension == ".xls")
            {
                //判断excel的版本
                if (extension == ".xlsx")
                {
                    wk = new XSSFWorkbook(fs);
                }
                else
                {
                    wk = new HSSFWorkbook(fs);
                }
            }
            HSSFSheet sheet = (HSSFSheet)wk.GetSheetAt(0);
            //获取excel的第一个sheet
            //获取Excel的最大行数
            int rowsCount = sheet.PhysicalNumberOfRows;
            dt.Rows.Clear();
            for (int i = 4; i < rowsCount; i++)
            {
                IRow row = sheet.GetRow(i);
                DataRow dr = dt.NewRow();
                dr[0] = row.GetCell(0).ToString();//发票代码
                dr[1] = row.GetCell(1).ToString();//发票号码
                dr[2] = row.GetCell(2).ToString();//购货方识别号
                dr[3] = row.GetCell(3).ToString();//销售方识别号
                dr[4] = DateTime.ParseExact(row.GetCell(4).ToString(), "yyyyMMdd",
                    new System.Globalization.CultureInfo("zh-CN"), System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                //开票日期
                dr[5] = decimal.Parse(row.GetCell(5).ToString());//金额
                dr[6] = decimal.Parse(row.GetCell(6).ToString());//税额
                dr[7] = DateTime.ParseExact(row.GetCell(7).ToString(), "yyyyMMdd",
                    new System.Globalization.CultureInfo("zh-CN"), System.Globalization.DateTimeStyles.AllowWhiteSpaces);
                //认证时间
                dr[8] = row.GetCell(8).ToString();//发票类型
                dt.Rows.Add(dr);
            }
            gridControl1.DataSource = dt;
            gridView1.BestFitColumns();
            gridView1.IndicatorWidth = 50;//设置显示行号的列宽

        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xhmax=0;
            using (SqliteDataContext dc = new SqliteDataContext(账套名))
            {
                if (dc.GetTable<JXFP进项发票>().Count() > 0)
                {
                    var query = dc.GetTable<JXFP进项发票>().Max(p => p.XH序号);
                    xhmax = query;
                }
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source="+ 账套名 + ".db;Version=3;");
            m_dbConnection.Open();
            DbTransaction trans = m_dbConnection.BeginTransaction();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string sql = "insert into JXFP进项发票 (XH序号,FPDM发票代码,FPHM发票号码,SH税号,KPSJ开票时间,JE金额,SE税额,RZSJ认证时间, LX类型) values " +
                    "( "+ (xhmax+i+1) +", '"+ dt.Rows[i][0] + "', '"+ dt.Rows[i][1] + "', '"+ dt.Rows[i][3] + "', '"+ dt.Rows[i][4] + "', "+ dt.Rows[i][5] +" , "+ dt.Rows[i][6] + ", '"+ dt.Rows[i][7] + "', 0)";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            trans.Commit();
            MessageBox.Show("发票导入成功！");
        }
    }
}
