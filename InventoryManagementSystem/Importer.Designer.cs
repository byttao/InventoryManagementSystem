namespace InventoryManagementSystem
{
    partial class Importer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FPDM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KPRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RZRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1062, 441);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FPDM,
            this.FPHM,
            this.SH,
            this.KPRQ,
            this.JE,
            this.SE,
            this.RZRQ});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JE", this.JE, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SE", this.SE, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FPDM
            // 
            this.FPDM.Caption = "发票代码";
            this.FPDM.Name = "FPDM";
            this.FPDM.Visible = true;
            this.FPDM.VisibleIndex = 0;
            // 
            // FPHM
            // 
            this.FPHM.Caption = "发票号码";
            this.FPHM.Name = "FPHM";
            this.FPHM.Visible = true;
            this.FPHM.VisibleIndex = 1;
            // 
            // SH
            // 
            this.SH.Caption = "销货方税号";
            this.SH.Name = "SH";
            this.SH.Visible = true;
            this.SH.VisibleIndex = 2;
            // 
            // KPRQ
            // 
            this.KPRQ.Caption = "开票时间";
            this.KPRQ.DisplayFormat.FormatString = "yyyy-mm-dd";
            this.KPRQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.KPRQ.Name = "KPRQ";
            this.KPRQ.Visible = true;
            this.KPRQ.VisibleIndex = 3;
            // 
            // JE
            // 
            this.JE.Caption = "金额";
            this.JE.DisplayFormat.FormatString = "#,##0.00";
            this.JE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JE.Name = "JE";
            this.JE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "小计：", "SUM={0:#,##0.00}")});
            this.JE.Visible = true;
            this.JE.VisibleIndex = 4;
            // 
            // SE
            // 
            this.SE.Caption = "税额";
            this.SE.DisplayFormat.FormatString = "#,##0.00";
            this.SE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SE.Name = "SE";
            this.SE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "SUM={0:#,##0.00}")});
            this.SE.Visible = true;
            this.SE.VisibleIndex = 5;
            // 
            // RZRQ
            // 
            this.RZRQ.Caption = "认证日期";
            this.RZRQ.DisplayFormat.FormatString = "yyyy-mm-dd";
            this.RZRQ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RZRQ.Name = "RZRQ";
            this.RZRQ.Visible = true;
            this.RZRQ.VisibleIndex = 6;
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 441);
            this.Controls.Add(this.gridControl1);
            this.Name = "Importer";
            this.Text = "Importer";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FPDM;
        private DevExpress.XtraGrid.Columns.GridColumn FPHM;
        private DevExpress.XtraGrid.Columns.GridColumn SH;
        private DevExpress.XtraGrid.Columns.GridColumn KPRQ;
        private DevExpress.XtraGrid.Columns.GridColumn JE;
        private DevExpress.XtraGrid.Columns.GridColumn SE;
        private DevExpress.XtraGrid.Columns.GridColumn RZRQ;
    }
}