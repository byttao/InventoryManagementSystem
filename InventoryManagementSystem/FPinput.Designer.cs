namespace InventoryManagementSystem
{
    partial class FPinput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPinput));
            this.THJ = new System.Windows.Forms.TextBox();
            this.DKPRQ = new System.Windows.Forms.DateTimePicker();
            this.DRKRQ = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TJE = new DevExpress.XtraEditors.CalcEdit();
            this.TSE = new DevExpress.XtraEditors.CalcEdit();
            this.TFPDM = new DevExpress.XtraEditors.TextEdit();
            this.TFPHM = new DevExpress.XtraEditors.TextEdit();
            this.calcEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.TSH = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TJE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFPDM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFPHM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // THJ
            // 
            this.THJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.THJ, 3);
            this.THJ.Enabled = false;
            this.THJ.Location = new System.Drawing.Point(840, 492);
            this.THJ.Name = "THJ";
            this.THJ.Size = new System.Drawing.Size(174, 25);
            this.THJ.TabIndex = 6;
            this.THJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DKPRQ
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DKPRQ, 2);
            this.DKPRQ.Location = new System.Drawing.Point(887, 96);
            this.DKPRQ.Name = "DKPRQ";
            this.DKPRQ.Size = new System.Drawing.Size(154, 25);
            this.DKPRQ.TabIndex = 3;
            // 
            // DRKRQ
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DRKRQ, 2);
            this.DRKRQ.Location = new System.Drawing.Point(186, 96);
            this.DRKRQ.Name = "DRKRQ";
            this.DRKRQ.Size = new System.Drawing.Size(154, 25);
            this.DRKRQ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("楷体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(77, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "入库日期：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 3);
            this.button1.Location = new System.Drawing.Point(796, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "导   入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DRKRQ, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.THJ, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.DKPRQ, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.TJE, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.TSE, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.TFPDM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TFPHM, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.calcEdit3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.TSH, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 711);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(254, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(254, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // TJE
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TJE, 2);
            this.TJE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TJE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TJE.Location = new System.Drawing.Point(681, 460);
            this.TJE.Name = "TJE";
            this.TJE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TJE.Properties.Mask.EditMask = "c";
            this.TJE.Size = new System.Drawing.Size(153, 24);
            this.TJE.TabIndex = 4;
            this.TJE.EditValueChanged += new System.EventHandler(this.calcEdit1_EditValueChanged);
            // 
            // TSE
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TSE, 2);
            this.TSE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSE.Location = new System.Drawing.Point(887, 460);
            this.TSE.Name = "TSE";
            this.TSE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TSE.Properties.Mask.BeepOnError = true;
            this.TSE.Properties.Mask.EditMask = "c";
            this.TSE.Size = new System.Drawing.Size(156, 24);
            this.TSE.TabIndex = 5;
            this.TSE.EditValueChanged += new System.EventHandler(this.calcEdit1_EditValueChanged);
            // 
            // TFPDM
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TFPDM, 3);
            this.TFPDM.EditValue = "";
            this.TFPDM.Location = new System.Drawing.Point(77, 44);
            this.TFPDM.Name = "TFPDM";
            this.TFPDM.Properties.Appearance.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Bold);
            this.TFPDM.Properties.Appearance.Options.UseFont = true;
            this.TFPDM.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?";
            this.TFPDM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TFPDM.Size = new System.Drawing.Size(204, 34);
            this.TFPDM.TabIndex = 0;
            // 
            // TFPHM
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TFPHM, 4);
            this.TFPHM.EditValue = "";
            this.TFPHM.Location = new System.Drawing.Point(796, 44);
            this.TFPHM.Name = "TFPHM";
            this.TFPHM.Properties.Appearance.Font = new System.Drawing.Font("Broadway", 15F, System.Drawing.FontStyle.Bold);
            this.TFPHM.Properties.Appearance.Options.UseFont = true;
            this.TFPHM.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?";
            this.TFPHM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TFPHM.Size = new System.Drawing.Size(163, 34);
            this.TFPHM.TabIndex = 1;
            // 
            // calcEdit3
            // 
            this.calcEdit3.Location = new System.Drawing.Point(3, 622);
            this.calcEdit3.Name = "calcEdit3";
            this.calcEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.calcEdit3.Size = new System.Drawing.Size(68, 24);
            this.calcEdit3.TabIndex = 14;
            // 
            // TSH
            // 
            this.TSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TSH.EditValue = "";
            this.TSH.Location = new System.Drawing.Point(254, 547);
            this.TSH.Name = "TSH";
            this.TSH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TSH.Properties.Appearance.Options.UseFont = true;
            this.TSH.Properties.Mask.EditMask = "[A-Za-z0-9]{0,18}";
            this.TSH.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TSH.Size = new System.Drawing.Size(263, 30);
            this.TSH.TabIndex = 7;
            this.TSH.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // FPinput
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1153, 758);
            this.MinimumSize = new System.Drawing.Size(1153, 758);
            this.Name = "FPinput";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TJE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFPDM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFPHM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox THJ;
        private System.Windows.Forms.DateTimePicker DKPRQ;
        private System.Windows.Forms.DateTimePicker DRKRQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CalcEdit TJE;
        private DevExpress.XtraEditors.CalcEdit TSE;
        private DevExpress.XtraEditors.TextEdit TFPDM;
        private DevExpress.XtraEditors.TextEdit TFPHM;
        private DevExpress.XtraEditors.TextEdit calcEdit3;
        private DevExpress.XtraEditors.TextEdit TSH;
    }
}