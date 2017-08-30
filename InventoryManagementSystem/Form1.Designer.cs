namespace InventoryManagementSystem
{
    partial class Form1
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
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(39, 72);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DisplayMember = "DH";
            this.gridLookUpEdit1.Properties.ShowFooter = false;
            this.gridLookUpEdit1.Properties.ShowNullValuePromptWhenFocused = true;
            this.gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpEdit1.Properties.ValueMember = "DH";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(494, 24);
            this.gridLookUpEdit1.TabIndex = 0;
            this.gridLookUpEdit1.Enter += new System.EventHandler(this.gridLookUpEdit1_Enter);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DH,
            this.MC,
            this.SL,
            this.JE});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.AutoPopulateColumns = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // DH
            // 
            this.DH.Caption = "单号";
            this.DH.FieldName = "DH";
            this.DH.Name = "DH";
            this.DH.Visible = true;
            this.DH.VisibleIndex = 0;
            // 
            // MC
            // 
            this.MC.Caption = "名称";
            this.MC.FieldName = "MC";
            this.MC.Name = "MC";
            this.MC.Visible = true;
            this.MC.VisibleIndex = 1;
            // 
            // SL
            // 
            this.SL.Caption = "数量";
            this.SL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SL.FieldName = "SL";
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 2;
            // 
            // JE
            // 
            this.JE.Caption = "金额";
            this.JE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.JE.FieldName = "JE";
            this.JE.Name = "JE";
            this.JE.Visible = true;
            this.JE.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 356);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn DH;
        private DevExpress.XtraGrid.Columns.GridColumn MC;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
        private DevExpress.XtraGrid.Columns.GridColumn JE;
    }
}