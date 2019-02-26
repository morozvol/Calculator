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
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorHistoryDataSet = new Calculator.Win.CalculatorHistoryDataSet();
            this.historyTableAdapter = new Calculator.Win.CalculatorHistoryDataSetTableAdapters.HistoryTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Error = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHostName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(504, 27);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(72, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(157, 30);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(341, 20);
            this.txtTask.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(85, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Выражение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 24);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.calculatorHistoryDataSet;
            // 
            // calculatorHistoryDataSet
            // 
            this.calculatorHistoryDataSet.DataSetName = "CalculatorHistoryDataSet";
            this.calculatorHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
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
            this.gridControl1.DataSource = this.historyBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(25, 65);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(622, 295);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCondition,
            this.Result,
            this.Error,
            this.colDateTime,
            this.colLogin,
            this.colHostName});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView2.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView2_PopupMenuShowing);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colCondition
            // 
            this.colCondition.FieldName = "Condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.Visible = true;
            this.colCondition.VisibleIndex = 0;
            // 
            // Result
            // 
            this.Result.FieldName = "Result";
            this.Result.Name = "Result";
            this.Result.Visible = true;
            this.Result.VisibleIndex = 1;
            // 
            // Error
            // 
            this.Error.FieldName = "Error";
            this.Error.Name = "Error";
            this.Error.Visible = true;
            this.Error.VisibleIndex = 2;
            // 
            // colDateTime
            // 
            this.colDateTime.FieldName = "DateTime";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Visible = true;
            this.colDateTime.VisibleIndex = 3;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 4;
            // 
            // colHostName
            // 
            this.colHostName.FieldName = "HostName";
            this.colHostName.Name = "colHostName";
            this.colHostName.Visible = true;
            this.colHostName.VisibleIndex = 5;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 402);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorHistoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button2;
        private CalculatorHistoryDataSet calculatorHistoryDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private CalculatorHistoryDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
        private DevExpress.XtraGrid.Columns.GridColumn Error;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colHostName;
    }
}

