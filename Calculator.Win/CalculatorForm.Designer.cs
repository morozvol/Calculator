using System.Windows.Forms.VisualStyles;

namespace Calculator.Win
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.calcLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorHistoryDataSet = new Calculator.Win.CalculatorHistoryDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_calculation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhost_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.calcLogTableAdapter = new Calculator.Win.CalculatorHistoryDataSetTableAdapters.CalcLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(400, 400);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // txtTask
            // 
            this.txtTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTask.Location = new System.Drawing.Point(75, 26);
            this.txtTask.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtTask.MaxLength = 256;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(877, 20);
            this.txtTask.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Left;
            this.label.Location = new System.Drawing.Point(3, 26);
            this.label.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 30);
            this.label.TabIndex = 6;
            this.label.Text = "Выражение";
            // 
            // menuStrip2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip2, 3);
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1036, 20);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(62, 16);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.AddRow);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 16);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.EditRow);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 16);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteRow);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(958, 30);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gridControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.DataSource = this.calcLogBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 356);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // calcLogBindingSource
            // 
            this.calcLogBindingSource.DataMember = "CalcLog";
            this.calcLogBindingSource.DataSource = this.calculatorHistoryDataSet;
            // 
            // calculatorHistoryDataSet
            // 
            this.calculatorHistoryDataSet.DataSetName = "CalculatorHistoryDataSet";
            this.calculatorHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCondition,
            this.colResult,
            this.colError,
            this.coltime_calculation,
            this.colLogin,
            this.colhost_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colId
            // 
            this.colId.FieldName = "id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colId.OptionsColumn.ShowInExpressionEditor = false;
            this.colId.OptionsEditForm.UseEditorColRowSpan = false;
            this.colId.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            // 
            // colCondition
            // 
            this.colCondition.FieldName = "condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.OptionsColumn.AllowEdit = false;
            this.colCondition.OptionsColumn.ShowInExpressionEditor = false;
            this.colCondition.OptionsEditForm.UseEditorColRowSpan = false;
            this.colCondition.Visible = true;
            this.colCondition.VisibleIndex = 0;
            // 
            // colResult
            // 
            this.colResult.FieldName = "result";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.AllowEdit = false;
            this.colResult.OptionsColumn.ShowInExpressionEditor = false;
            this.colResult.OptionsEditForm.UseEditorColRowSpan = false;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 1;
            // 
            // colError
            // 
            this.colError.FieldName = "error";
            this.colError.Name = "colError";
            this.colError.OptionsColumn.AllowEdit = false;
            this.colError.OptionsColumn.ShowInExpressionEditor = false;
            this.colError.OptionsEditForm.UseEditorColRowSpan = false;
            this.colError.Visible = true;
            this.colError.VisibleIndex = 2;
            // 
            // coltime_calculation
            // 
            this.coltime_calculation.FieldName = "time_calculation";
            this.coltime_calculation.GroupFormat.FormatString = "MM.dd.yy hh:mm";
            this.coltime_calculation.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coltime_calculation.Name = "coltime_calculation";
            this.coltime_calculation.OptionsColumn.AllowEdit = false;
            this.coltime_calculation.OptionsColumn.ShowInExpressionEditor = false;
            this.coltime_calculation.OptionsEditForm.UseEditorColRowSpan = false;
            this.coltime_calculation.Visible = true;
            this.coltime_calculation.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "login";
            this.colLogin.Name = "colLogin";
            this.colLogin.OptionsColumn.AllowEdit = false;
            this.colLogin.OptionsColumn.ShowInExpressionEditor = false;
            this.colLogin.OptionsEditForm.UseEditorColRowSpan = false;
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colhost_name
            // 
            this.colhost_name.FieldName = "host_name";
            this.colhost_name.Name = "colhost_name";
            this.colhost_name.OptionsColumn.AllowEdit = false;
            this.colhost_name.OptionsColumn.ShowInExpressionEditor = false;
            this.colhost_name.OptionsEditForm.UseEditorColRowSpan = false;
            this.colhost_name.Visible = true;
            this.colhost_name.VisibleIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTask, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 563);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBox1, 3);
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 421);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1030, 139);
            this.listBox1.TabIndex = 9;
            // 
            // calcLogTableAdapter
            // 
            this.calcLogTableAdapter.ClearBeforeFill = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CalculatorHistoryDataSet calculatorHistoryDataSet;
        private System.Windows.Forms.BindingSource calcLogBindingSource;
        private CalculatorHistoryDataSetTableAdapters.CalcLogTableAdapter calcLogTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcondition;
        private DevExpress.XtraGrid.Columns.GridColumn colresult;
        private DevExpress.XtraGrid.Columns.GridColumn colerror;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_calculation;
        private DevExpress.XtraGrid.Columns.GridColumn collogin;
        private DevExpress.XtraGrid.Columns.GridColumn colhost_name;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
    }
}

