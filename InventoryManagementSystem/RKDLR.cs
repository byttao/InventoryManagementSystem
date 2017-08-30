using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace InventoryManagementSystem
{
    public partial class RKDLR : Form
    {
        private DataTable dt = new DataTable();
        private DataTable ZGDT = new DataTable();
        private string dbPath = Properties.Settings.Default.Accname;
        List<JXFP进项发票> jxfp;
        private int num = 0;
        private int N;
        private string rq = Properties.Settings.Default.YF;

        public RKDLR()
        {
            InitializeComponent();
            dt.Columns.Add("MC", typeof(string));
            dt.Columns.Add("DW", typeof(string));
            dt.Columns.Add("SL", typeof(decimal));
            dt.Columns.Add("DJ", typeof(decimal));
            dt.Columns.Add("JE", typeof(decimal));
            dt.Columns.Add("BZ", typeof(string));

            ZGDT.Columns.Add("单号", typeof(string));
            ZGDT.Columns.Add("发票号码", typeof(string));
            ZGDT.Columns.Add("名称", typeof(string));
            ZGDT.Columns.Add("剩余数量", typeof(decimal));
            ZGDT.Columns.Add("剩余金额", typeof(decimal));
            gridControl1.DataSource = dt;
            datarefresh();
            this.repositoryItemGridLookUpEdit1.Enter += new System.EventHandler(this.gridLookUpEdit1_Enter);
        }

        void datarefresh()
        {
            using (SqliteDataContext dc = new SqliteDataContext(dbPath))
            {
                if (dc.GetTable<JXFP进项发票>().Count() > 0)
                {
                    jxfp = dc.GetTable<JXFP进项发票>().Select(p => p).ToList();
                    N = jxfp.Count;
                    UpRKDH(dc,1,"内销");
                    if (jxfp[num].RKDH入库单号 != "")
                    {
                        
                    }
                    Lfpdm.Text = jxfp[num].FPDM发票代码;
                    Lfphm.Text = jxfp[num].FPHM发票号码;
                    Lqysh.Text = jxfp[num].SH税号;
                    Lfpje.Text = jxfp[num].JE金额.ToString("#,##0.00");
                    Txhqy.Text = jxfp[num].MC名称 == null ? "" : jxfp[num].MC名称;
                    Lrkrq.Text=DateTime.Parse(jxfp[num].RZSJ认证时间.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
                    Lkprq.Text = jxfp[num].KPSJ开票时间.ToString("yyyy-MM-dd");
                }
                comboBox1.DataSource = dc.GetTable<FPLX发票类型>().Select(p => new { p.XH序号, p.LX类型 });
                comboBox1.DisplayMember = "LX类型";
                comboBox1.ValueMember = "XH序号";
                comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
                comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

                var zg = (from c in dc.GetTable<ZG暂估>()
                          join d in dc.GetTable<CH存货>()
                          on c.CH存货 equals d.XH序号
                          where c.ZGSHL暂估数量 > c.DPSL到票数量
                          select new
                          {
                              YF = c.YF月份,
                              BH = c.BH编号,
                              HH = c.HH行号,
                              FPHM = c.FPHM发票号码,
                              MC = d.MC名称,
                              //DW = d.DW单位 ,
                              SYSL = c.ZGSHL暂估数量 - c.DPSL到票数量,
                              SYJE = c.ZGJE暂估金额 - c.DPJE到票金额
                          }).ToList();

                foreach (var c in zg)
                {
                    DataRow dr = ZGDT.NewRow();
                    dr[0] = "Z" + c.YF + c.BH.ToString().PadLeft(4, '0') + "-" + c.HH;
                    dr[1] = c.FPHM;
                    dr[2] = c.MC;
                    dr[3] = c.SYSL;
                    dr[4] = c.SYJE;
                    ZGDT.Rows.Add(dr);
                }

                SetGridLookUpEditMoreColumnFilter(repositoryItemGridLookUpEdit1);
                repositoryItemGridLookUpEdit1.DataSource = ZGDT;
            }
        }

        void UpRKDH(SqliteDataContext dc1,int xh, string lxmc= "")
        {
            string fplx="";
            foreach (var d in (from c in dc1.GetTable<FPLX发票类型>()
                where c.XH序号 == xh
                select c.DM代码))
            {
                fplx = d.ToString();
                Lbt.Text = lxmc+ comboBox1.Text + " 入库单";
            }
            if (jxfp[num].RKDH入库单号 == null)
            {
                if ((from c in dc1.GetTable<RKD入库单>()
                     where c.YF月份 == rq && c.LX类型 == xh
                     select (c.BH编号)).Count() > 0)
                {

                    Lrkdh.Text = fplx + rq + ((from c in dc1.GetTable<RKD入库单>()
                                              where c.YF月份 == rq && c.LX类型==xh
                                              select (c.BH编号)).Max() + 1).ToString().PadLeft(4, '0');
                }
                else
                    Lrkdh.Text = fplx + rq + "0001";
            }
            else Lrkdh.Text = jxfp[num].RKDH入库单号;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpRKDH(new SqliteDataContext(dbPath), int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        /// <summary>
        /// 设置GridLookUpEdit多列过滤
        /// </summary>
        /// <param name="repGLUEdit">GridLookUpEdit的知识库，eg:gridlookUpEdit.Properties</param>
        void SetGridLookUpEditMoreColumnFilter(DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repGLUEdit)
        {
            repGLUEdit.EditValueChanging += (sender, e) =>
            {
                this.BeginInvoke(new System.Windows.Forms.MethodInvoker(() => {
                    GridLookUpEdit edit = sender as GridLookUpEdit;
                    DevExpress.XtraGrid.Views.Grid.GridView view = edit.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
                    //获取GriView私有变量
                    System.Reflection.FieldInfo extraFilter = view.GetType().GetField("extraFilter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    List<DevExpress.Data.Filtering.CriteriaOperator> columnsOperators = new List<DevExpress.Data.Filtering.CriteriaOperator>();
                    foreach (GridColumn col in view.VisibleColumns)
                    {
                        if (col.Visible && col.ColumnType == typeof(string))
                            columnsOperators.Add(new DevExpress.Data.Filtering.FunctionOperator(DevExpress.Data.Filtering.FunctionOperatorType.Contains,
                                new DevExpress.Data.Filtering.OperandProperty(col.FieldName),
                                new DevExpress.Data.Filtering.OperandValue(edit.Text)));
                    }
                    string filterCondition = new DevExpress.Data.Filtering.GroupOperator(DevExpress.Data.Filtering.GroupOperatorType.Or, columnsOperators).ToString();
                    extraFilter.SetValue(view, filterCondition);
                    //获取GriView中处理列过滤的私有方法
                    System.Reflection.MethodInfo ApplyColumnsFilterEx = view.GetType().GetMethod("ApplyColumnsFilterEx", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    ApplyColumnsFilterEx.Invoke(view, null);
                }));
            };
        }

        private void gridLookUpEdit1_Enter(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { ((GridLookUpEdit)sender).ShowPopup(); }));
        }
    }
}
