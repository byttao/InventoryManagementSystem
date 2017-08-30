using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
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
    public partial class Form1 : Form
    {
        private string dbPath = Properties.Settings.Default.Accname;
        private DataTable DT=new DataTable();
        public Form1()
        {
            InitializeComponent();
            DT.Columns.Add("DH", typeof(string));
            DT.Columns.Add("FPHM", typeof(string));
            DT.Columns.Add("MC", typeof(string));
            DT.Columns.Add("DW", typeof(string));
            DT.Columns.Add("SL", typeof(decimal));
            DT.Columns.Add("JE", typeof(decimal));

            using (SqliteDataContext dc = new SqliteDataContext(dbPath))
            {
                var zg = (from c in dc.GetTable<ZG暂估>()
                    join d in dc.GetTable<CH存货>()
                    on c.CH存货 equals d.XH序号
                    where c.ZGSHL暂估数量 > c.DPSL到票数量
                    select new
                    {
                        YF = c.YF月份 ,
                        BH=c.BH编号,
                        HH=c.HH行号,
                        FPHM = c.FPHM发票号码,
                        MC = d.MC名称,
                        //DW = d.DW单位 ,
                        SYSL = c.ZGSHL暂估数量 - c.DPSL到票数量,
                        //SYJE = c.ZGJE暂估金额 - c.DPJE到票金额
                    }).ToList();
                foreach (var c in zg)
                {
                    DataRow dr = DT.NewRow();
                    dr[0] = "Z" + c.YF + c.BH.ToString().PadLeft(4, '0') + "-" + c.HH;
                    dr[1] = c.FPHM;
                    dr[2] = c.MC;
                    //dr[3] = c.DW;
                    dr[4] = c.SYSL;
                    //dr[5] = c.SYJE;
                    DT.Rows.Add(dr);
                }
                gridLookUpEdit1.Properties.DataSource = DT;
                SetGridLookUpEditMoreColumnFilter(gridLookUpEdit1.Properties);
            }
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
