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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.calcLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorHistoryDataSet = new Calculator.Win.CalculatorHistoryDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_calculation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhost_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltime_calculation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhost_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcLogTableAdapter = new Calculator.Win.CalculatorHistoryDataSetTableAdapters.CalcLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(932, 30);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(72, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTask
            // 
            this.txtTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTask.Location = new System.Drawing.Point(75, 30);
            this.txtTask.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(851, 20);
            this.txtTask.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(3, 30);
            this.label.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Выражение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(932, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 24);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(22, 67);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(619, 293);
            this.gridSplitContainer1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.DataSource = this.calcLogBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 59);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1001, 471);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCondition,
            this.colResult,
            this.colError,
            this.coltime_calculation,
            this.colLogin,
            this.colhost_name});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
                new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Descending)});
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colId.OptionsColumn.ShowInExpressionEditor = false;
            this.colId.OptionsEditForm.UseEditorColRowSpan = false;
            // 
            // colCondition
            // 
            this.colCondition.FieldName = "Condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.OptionsColumn.AllowEdit = false;
            this.colCondition.OptionsColumn.ShowInExpressionEditor = false;
            this.colCondition.OptionsEditForm.UseEditorColRowSpan = false;
            this.colCondition.Visible = true;
            this.colCondition.VisibleIndex = 0;
            // 
            // Result
            // 
            this.colResult.FieldName = "Result";
            this.colResult.Name = "Result";
            this.colResult.OptionsColumn.AllowEdit = false;
            this.colResult.OptionsColumn.ShowInExpressionEditor = false;
            this.colResult.OptionsEditForm.UseEditorColRowSpan = false;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 1;
            // 
            // Error
            // 
            this.colError.FieldName = "Error";
            this.colError.Name = "Error";
            this.colError.OptionsColumn.AllowEdit = false;
            this.colError.OptionsColumn.ShowInExpressionEditor = false;
            this.colError.OptionsEditForm.UseEditorColRowSpan = false;
            this.colError.Visible = true;
            this.colError.VisibleIndex = 2;
            // 
            // colDateTime
            // 
            this.coltime_calculation.FieldName = "time_calculation";
            this.coltime_calculation.Name = "colDateTime";
            this.coltime_calculation.OptionsColumn.AllowEdit = false;
            this.coltime_calculation.OptionsColumn.ShowInExpressionEditor = false;
            this.coltime_calculation.OptionsEditForm.UseEditorColRowSpan = false;
            this.coltime_calculation.Visible = true;
            this.coltime_calculation.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.OptionsColumn.AllowEdit = false;
            this.colLogin.OptionsColumn.ShowInExpressionEditor = false;
            this.colLogin.OptionsEditForm.UseEditorColRowSpan = false;
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colHostName
            // 
            this.colhost_name.FieldName = "host_name";
            this.colhost_name.Name = "colHostName";
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
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTask, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 563);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // menuStrip2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip2, 3);
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1007, 20);
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
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 16);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteRow);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 16);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.EditRow);
            // 
            // calcLogTableAdapter
            // 
            this.calcLogTableAdapter.ClearBeforeFill = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_calculation;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colhost_name;
        private CalculatorHistoryDataSet calculatorHistoryDataSet;
        private System.Windows.Forms.BindingSource calcLogBindingSource;
        private CalculatorHistoryDataSetTableAdapters.CalcLogTableAdapter calcLogTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition1;
        private DevExpress.XtraGrid.Columns.GridColumn colResult1;
        private DevExpress.XtraGrid.Columns.GridColumn colError1;
        private DevExpress.XtraGrid.Columns.GridColumn coltime_calculation1;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin1;
        private DevExpress.XtraGrid.Columns.GridColumn colhost_name1;
    }
}

