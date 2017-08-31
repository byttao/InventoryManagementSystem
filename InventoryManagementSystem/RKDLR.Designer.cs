namespace InventoryManagementSystem
{
    partial class RKDLR
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbPre = new DevExpress.XtraBars.BarButtonItem();
            this.bbNext = new DevExpress.XtraBars.BarButtonItem();
            this.bbSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridlookupBZ = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Lrkdh = new System.Windows.Forms.Label();
            this.Lfpdm = new System.Windows.Forms.Label();
            this.Lfphm = new System.Windows.Forms.Label();
            this.Lqysh = new System.Windows.Forms.Label();
            this.Lfpje = new System.Windows.Forms.Label();
            this.Lkprq = new System.Windows.Forms.Label();
            this.Txhqy = new System.Windows.Forms.TextBox();
            this.Lrkrq = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lbt = new System.Windows.Forms.Label();
            this.CCSL = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.CCJE = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridlookupBZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCJE)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbPre,
            this.bbNext,
            this.bbSave});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbPre, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbNext, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 2;
            this.bar1.Text = "Tools";
            // 
            // bbPre
            // 
            this.bbPre.Caption = "上一条(&P)";
            this.bbPre.Id = 0;
            this.bbPre.ImageUri.Uri = "DoublePrev";
            this.bbPre.Name = "bbPre";
            this.bbPre.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bbNext
            // 
            this.bbNext.Caption = "下一条(&N)";
            this.bbNext.Id = 1;
            this.bbNext.ImageUri.Uri = "DoubleNext";
            this.bbNext.Name = "bbNext";
            // 
            // bbSave
            // 
            this.bbSave.Caption = "保存(&S)";
            this.bbSave.Id = 2;
            this.bbSave.ImageUri.Uri = "Save";
            this.bbSave.Name = "bbSave";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1100, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 559);
            this.barDockControlBottom.Size = new System.Drawing.Size(1100, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 520);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1100, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 520);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(815, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "入库单号：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "销货企业：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "企业税号：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(466, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 18);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "开票日期：";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(466, 130);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "入库日期：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(731, 96);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 18);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "发票代码：";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(731, 130);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 18);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "发票号码：";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(33, 163);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GridlookupBZ,
            this.CCSL,
            this.CCJE});
            this.gridControl1.Size = new System.Drawing.Size(1041, 316);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MC,
            this.DW,
            this.SL,
            this.DJ,
            this.JE,
            this.BZ});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // MC
            // 
            this.MC.Caption = "名称";
            this.MC.FieldName = "MC";
            this.MC.Name = "MC";
            this.MC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MC", "行数：{0}")});
            this.MC.Visible = true;
            this.MC.VisibleIndex = 0;
            // 
            // DW
            // 
            this.DW.Caption = "单位";
            this.DW.FieldName = "DW";
            this.DW.Name = "DW";
            this.DW.Visible = true;
            this.DW.VisibleIndex = 1;
            // 
            // SL
            // 
            this.SL.Caption = "数量";
            this.SL.ColumnEdit = this.CCSL;
            this.SL.DisplayFormat.FormatString = "#,##0.0000";
            this.SL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SL.FieldName = "SL";
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 2;
            // 
            // DJ
            // 
            this.DJ.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.DJ.AppearanceCell.Options.UseBackColor = true;
            this.DJ.Caption = "单价";
            this.DJ.DisplayFormat.FormatString = "#,##0.000000";
            this.DJ.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DJ.FieldName = "DJ";
            this.DJ.Name = "DJ";
            this.DJ.OptionsColumn.AllowEdit = false;
            this.DJ.OptionsColumn.AllowFocus = false;
            this.DJ.OptionsColumn.TabStop = false;
            this.DJ.Visible = true;
            this.DJ.VisibleIndex = 3;
            // 
            // JE
            // 
            this.JE.Caption = "金额";
            this.JE.ColumnEdit = this.CCJE;
            this.JE.DisplayFormat.FormatString = "N2";
            this.JE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JE.FieldName = "JE";
            this.JE.Name = "JE";
            this.JE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JE", "SUM={0:N2}")});
            this.JE.Visible = true;
            this.JE.VisibleIndex = 4;
            // 
            // BZ
            // 
            this.BZ.Caption = "备注";
            this.BZ.ColumnEdit = this.GridlookupBZ;
            this.BZ.FieldName = "BZ";
            this.BZ.Name = "BZ";
            this.BZ.Visible = true;
            this.BZ.VisibleIndex = 5;
            // 
            // GridlookupBZ
            // 
            this.GridlookupBZ.AutoHeight = false;
            this.GridlookupBZ.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridlookupBZ.DisplayMember = "单号";
            this.GridlookupBZ.Name = "GridlookupBZ";
            this.GridlookupBZ.NullText = "";
            this.GridlookupBZ.ShowFooter = false;
            this.GridlookupBZ.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.GridlookupBZ.ValueMember = "单号";
            this.GridlookupBZ.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(35, 491);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(75, 18);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "发票金额：";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(731, 491);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(75, 18);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "发票类型：";
            // 
            // Lrkdh
            // 
            this.Lrkdh.AutoSize = true;
            this.Lrkdh.Location = new System.Drawing.Point(896, 47);
            this.Lrkdh.Name = "Lrkdh";
            this.Lrkdh.Size = new System.Drawing.Size(55, 15);
            this.Lrkdh.TabIndex = 8;
            this.Lrkdh.Text = "label1";
            // 
            // Lfpdm
            // 
            this.Lfpdm.AutoSize = true;
            this.Lfpdm.Location = new System.Drawing.Point(812, 98);
            this.Lfpdm.Name = "Lfpdm";
            this.Lfpdm.Size = new System.Drawing.Size(55, 15);
            this.Lfpdm.TabIndex = 8;
            this.Lfpdm.Text = "label1";
            // 
            // Lfphm
            // 
            this.Lfphm.AutoSize = true;
            this.Lfphm.Location = new System.Drawing.Point(812, 132);
            this.Lfphm.Name = "Lfphm";
            this.Lfphm.Size = new System.Drawing.Size(55, 15);
            this.Lfphm.TabIndex = 8;
            this.Lfphm.Text = "label1";
            // 
            // Lqysh
            // 
            this.Lqysh.AutoSize = true;
            this.Lqysh.Location = new System.Drawing.Point(112, 132);
            this.Lqysh.Name = "Lqysh";
            this.Lqysh.Size = new System.Drawing.Size(55, 15);
            this.Lqysh.TabIndex = 8;
            this.Lqysh.Text = "label1";
            // 
            // Lfpje
            // 
            this.Lfpje.AutoSize = true;
            this.Lfpje.Location = new System.Drawing.Point(112, 493);
            this.Lfpje.Name = "Lfpje";
            this.Lfpje.Size = new System.Drawing.Size(55, 15);
            this.Lfpje.TabIndex = 8;
            this.Lfpje.Text = "label1";
            // 
            // Lkprq
            // 
            this.Lkprq.AutoSize = true;
            this.Lkprq.Location = new System.Drawing.Point(539, 98);
            this.Lkprq.Name = "Lkprq";
            this.Lkprq.Size = new System.Drawing.Size(55, 15);
            this.Lkprq.TabIndex = 8;
            this.Lkprq.Text = "label1";
            // 
            // Txhqy
            // 
            this.Txhqy.Location = new System.Drawing.Point(115, 93);
            this.Txhqy.Name = "Txhqy";
            this.Txhqy.Size = new System.Drawing.Size(326, 25);
            this.Txhqy.TabIndex = 9;
            // 
            // Lrkrq
            // 
            this.Lrkrq.AutoSize = true;
            this.Lrkrq.Location = new System.Drawing.Point(539, 132);
            this.Lrkrq.Name = "Lrkrq";
            this.Lrkrq.Size = new System.Drawing.Size(55, 15);
            this.Lrkrq.TabIndex = 8;
            this.Lrkrq.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(815, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // Lbt
            // 
            this.Lbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbt.BackColor = System.Drawing.Color.Transparent;
            this.Lbt.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbt.ForeColor = System.Drawing.Color.DarkGreen;
            this.Lbt.Location = new System.Drawing.Point(393, 21);
            this.Lbt.Name = "Lbt";
            this.Lbt.Size = new System.Drawing.Size(288, 36);
            this.Lbt.TabIndex = 19;
            this.Lbt.Text = "内销 入库单";
            this.Lbt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CCSL
            // 
            this.CCSL.AutoHeight = false;
            this.CCSL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CCSL.DisplayFormat.FormatString = "n4";
            this.CCSL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CCSL.Mask.EditMask = "n4";
            this.CCSL.Name = "CCSL";
            // 
            // CCJE
            // 
            this.CCJE.AutoHeight = false;
            this.CCJE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CCJE.DisplayFormat.FormatString = "n2";
            this.CCJE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CCJE.Mask.EditMask = "n2";
            this.CCJE.Name = "CCJE";
            // 
            // RKDLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 559);
            this.Controls.Add(this.Lbt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Txhqy);
            this.Controls.Add(this.Lrkrq);
            this.Controls.Add(this.Lkprq);
            this.Controls.Add(this.Lfpje);
            this.Controls.Add(this.Lqysh);
            this.Controls.Add(this.Lfphm);
            this.Controls.Add(this.Lfpdm);
            this.Controls.Add(this.Lrkdh);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "RKDLR";
            this.Text = "RKDLR";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RKDLR_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridlookupBZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCJE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbPre;
        private DevExpress.XtraBars.BarButtonItem bbNext;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TextBox Txhqy;
        private System.Windows.Forms.Label Lrkrq;
        private System.Windows.Forms.Label Lkprq;
        private System.Windows.Forms.Label Lfpje;
        private System.Windows.Forms.Label Lqysh;
        private System.Windows.Forms.Label Lfphm;
        private System.Windows.Forms.Label Lfpdm;
        private System.Windows.Forms.Label Lrkdh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn MC;
        private DevExpress.XtraGrid.Columns.GridColumn DW;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
        private DevExpress.XtraGrid.Columns.GridColumn DJ;
        private DevExpress.XtraGrid.Columns.GridColumn JE;
        private DevExpress.XtraGrid.Columns.GridColumn BZ;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridlookupBZ;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraBars.BarButtonItem bbSave;
        private System.Windows.Forms.Label Lbt;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit CCSL;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit CCJE;
    }
}