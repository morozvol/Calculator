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
            this.calcLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorHistoryDataSet = new Calculator.Win.CalculatorHistoryDataSet();
            this.calcTracingRecordGetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calcLogTableAdapter = new Calculator.Win.CalculatorHistoryDataSetTableAdapters.CalcLogTableAdapter();
            this.calcTracingRecordGetTableAdapter = new Calculator.Win.CalculatorHistoryDataSetTableAdapters.CalcTracingRecordGetTableAdapter();
            this.gcCalcTracing = new DevExpress.XtraGrid.GridControl();
            this.gvCalcTracing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOperand_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperand_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTracingResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gcCalcLog = new DevExpress.XtraGrid.GridControl();
            this.gvCalcLog = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime_calculation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHost_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTracingRecordGetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalcTracing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalcTracing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalcLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalcLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            // calcTracingRecordGetBindingSource
            // 
            this.calcTracingRecordGetBindingSource.DataMember = "CalcTracingRecordGet";
            this.calcTracingRecordGetBindingSource.DataSource = this.calculatorHistoryDataSet;
            // 
            // calcLogTableAdapter
            // 
            this.calcLogTableAdapter.ClearBeforeFill = true;
            // 
            // calcTracingRecordGetTableAdapter
            // 
            this.calcTracingRecordGetTableAdapter.ClearBeforeFill = true;
            // 
            // gcCalcTracing
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gcCalcTracing, 3);
            this.gcCalcTracing.DataSource = this.calcTracingRecordGetBindingSource;
            this.gcCalcTracing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCalcTracing.Location = new System.Drawing.Point(3, 398);
            this.gcCalcTracing.MainView = this.gvCalcTracing;
            this.gcCalcTracing.Name = "gcCalcTracing";
            this.gcCalcTracing.Size = new System.Drawing.Size(1030, 162);
            this.gcCalcTracing.TabIndex = 9;
            this.gcCalcTracing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCalcTracing,
            this.gridView3,
            this.gridView1});
            // 
            // gvCalcTracing
            // 
            this.gvCalcTracing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOperand_1,
            this.colOperand_2,
            this.colOperator,
            this.colTracingResult});
            this.gvCalcTracing.GridControl = this.gcCalcTracing;
            this.gvCalcTracing.Name = "gvCalcTracing";
            this.gvCalcTracing.OptionsView.ShowGroupPanel = false;
            // 
            // colOperand_1
            // 
            this.colOperand_1.Caption = "операнд1";
            this.colOperand_1.FieldName = "operand_1";
            this.colOperand_1.Name = "colOperand_1";
            this.colOperand_1.Visible = true;
            this.colOperand_1.VisibleIndex = 0;
            // 
            // colOperand_2
            // 
            this.colOperand_2.Caption = "операнд 2";
            this.colOperand_2.FieldName = "operand_2";
            this.colOperand_2.Name = "colOperand_2";
            this.colOperand_2.Visible = true;
            this.colOperand_2.VisibleIndex = 1;
            // 
            // colOperator
            // 
            this.colOperator.Caption = "оператор";
            this.colOperator.FieldName = "operator";
            this.colOperator.Name = "colOperator";
            this.colOperator.Visible = true;
            this.colOperator.VisibleIndex = 2;
            // 
            // colTracingResult
            // 
            this.colTracingResult.Caption = "результат";
            this.colTracingResult.FieldName = "result";
            this.colTracingResult.Name = "colTracingResult";
            this.colTracingResult.Visible = true;
            this.colTracingResult.VisibleIndex = 3;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcCalcTracing;
            this.gridView3.Name = "gridView3";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcCalcTracing;
            this.gridView1.Name = "gridView1";
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
            this.label.Size = new System.Drawing.Size(66, 23);
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
            this.btnCalculate.Location = new System.Drawing.Point(958, 23);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gcCalcLog
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gcCalcLog, 3);
            this.gcCalcLog.DataSource = this.calcLogBindingSource;
            this.gcCalcLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCalcLog.Location = new System.Drawing.Point(3, 52);
            this.gcCalcLog.MainView = this.gvCalcLog;
            this.gcCalcLog.Name = "gcCalcLog";
            this.gcCalcLog.Size = new System.Drawing.Size(1030, 340);
            this.gcCalcLog.TabIndex = 5;
            this.gcCalcLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCalcLog,
            this.gridView4,
            this.gridView2});
            // 
            // gvCalcLog
            // 
            this.gvCalcLog.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCondition,
            this.colResult,
            this.colError,
            this.colTime_calculation,
            this.colLogin,
            this.colHost_name});
            this.gvCalcLog.GridControl = this.gcCalcLog;
            this.gvCalcLog.Name = "gvCalcLog";
            this.gvCalcLog.OptionsView.ShowGroupPanel = false;
            this.gvCalcLog.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvCalcLog.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gvCalcLog_SelectionChanged);
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
            this.colCondition.Caption = "Выражение";
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
            this.colResult.Caption = "Результат";
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
            this.colError.Caption = "Ошибка";
            this.colError.FieldName = "error";
            this.colError.Name = "colError";
            this.colError.OptionsColumn.AllowEdit = false;
            this.colError.OptionsColumn.ShowInExpressionEditor = false;
            this.colError.OptionsEditForm.UseEditorColRowSpan = false;
            this.colError.Visible = true;
            this.colError.VisibleIndex = 2;
            // 
            // colTime_calculation
            // 
            this.colTime_calculation.Caption = "Дата и время вычисления";
            this.colTime_calculation.DisplayFormat.FormatString = "MM.dd.yyyy  hh:mm";
            this.colTime_calculation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTime_calculation.FieldName = "time_calculation";
            this.colTime_calculation.Name = "colTime_calculation";
            this.colTime_calculation.OptionsColumn.AllowEdit = false;
            this.colTime_calculation.OptionsColumn.ShowInExpressionEditor = false;
            this.colTime_calculation.OptionsEditForm.UseEditorColRowSpan = false;
            this.colTime_calculation.Visible = true;
            this.colTime_calculation.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Имя пользователя";
            this.colLogin.FieldName = "login";
            this.colLogin.Name = "colLogin";
            this.colLogin.OptionsColumn.AllowEdit = false;
            this.colLogin.OptionsColumn.ShowInExpressionEditor = false;
            this.colLogin.OptionsEditForm.UseEditorColRowSpan = false;
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colHost_name
            // 
            this.colHost_name.Caption = "Имя компьютера";
            this.colHost_name.FieldName = "host_name";
            this.colHost_name.Name = "colHost_name";
            this.colHost_name.OptionsColumn.AllowEdit = false;
            this.colHost_name.OptionsColumn.ShowInExpressionEditor = false;
            this.colHost_name.OptionsEditForm.UseEditorColRowSpan = false;
            this.colHost_name.Visible = true;
            this.colHost_name.VisibleIndex = 5;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gcCalcLog;
            this.gridView4.Name = "gridView4";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcCalcLog;
            this.gridView2.Name = "gridView2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gcCalcLog, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTask, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gcCalcTracing, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 563);
            this.tableLayoutPanel1.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.calcLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTracingRecordGetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalcTracing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalcTracing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCalcLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCalcLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private CalculatorHistoryDataSet calculatorHistoryDataSet;
        private System.Windows.Forms.BindingSource calcLogBindingSource;
        private CalculatorHistoryDataSetTableAdapters.CalcLogTableAdapter calcLogTableAdapter;
        private System.Windows.Forms.BindingSource calcTracingRecordGetBindingSource;
        private CalculatorHistoryDataSetTableAdapters.CalcTracingRecordGetTableAdapter calcTracingRecordGetTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCalcTracing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcCalcLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCalcLog;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn colTime_calculation;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colHost_name;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCalcTracing;
        private DevExpress.XtraGrid.Columns.GridColumn colOperand_1;
        private DevExpress.XtraGrid.Columns.GridColumn colOperand_2;
        private DevExpress.XtraGrid.Columns.GridColumn colOperator;
        private DevExpress.XtraGrid.Columns.GridColumn colTracingResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

