using System;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using HistoryRepository;


namespace Calculator.Win
{
    public partial class CalculatorForm : Form
    {
        public event EventHandler Edit;
        public event EventHandler Delete;
        public event EventHandler Add;

       private History _history = new History();

        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");

            Core.Calculator calculator = new Core.Calculator(txtTask.Text, culture, txtTask.Text);
            try
            {
                var result = calculator.CalculateExpression();
                if (result != "Error") _history.AddRecord(txtTask.Text, Double.Parse(result, culture));
            }
            catch (ErrorException ex)
            {
                _history.AddRecord(txtTask.Text, ex.Message);
            }
            historyTableAdapter.Fill(calculatorHistoryDataSet.History);
            txtTask.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.historyTableAdapter.Fill(this.calculatorHistoryDataSet.History);
        }


        private void DeleteRow(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "Вы точно хотите удалить запись из истории",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (res == DialogResult.Yes)
            {
                var id = (int) gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Id");
                _history.DeleteRecord(id);
                historyTableAdapter.Fill(calculatorHistoryDataSet.History);
            }
        }


        private void EditRow(object sender, EventArgs e)
        {
            var Value = (int) gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Id");
            var updateResult = AddOrEditRowDialod.ShowDialog("Редактирование", new History().GetRecord(Value));
            if (updateResult != null)
            {
                _history.updateRecord(updateResult, Value);
                historyTableAdapter.Fill(calculatorHistoryDataSet.History);
            }
        }

        private void AddRow(object sender, EventArgs e)
        {
            AddOrEditRowDialod.ShowDialog("Создание", null);
            historyTableAdapter.Fill(calculatorHistoryDataSet.History);
        }

        private void gridView2_PopupMenuShowing(object sender,
            DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                GridViewMenu menu = new GridViewMenu(gridView2);
                Delete += DeleteRow;
                Edit += EditRow;
                Add += AddRow;
                menu.Items.Add(new DXMenuItem("Удалить", Delete));
                menu.Items.Add(new DXMenuItem("Изменить", Edit));
                menu.Items.Add(new DXMenuItem("Добавить", Add));
                e.Menu = menu;
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
        }
    }
}