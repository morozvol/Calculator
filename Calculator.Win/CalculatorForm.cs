using System;
using System.Windows.Forms;
using System.Globalization;
using Calculator.HistoryRepository;


namespace Calculator.Win
{
    public partial class CalculatorForm : Form
    {
        private CultureInfo _culture;

        private History _history = new History();

        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _culture = CultureInfo.GetCultureInfo("ru-RU");

            Core.Calculator calculator = new Core.Calculator(txtTask.Text, _culture, txtTask.Text);
            try
            {
                var result = calculator.CalculateExpression();
                if (result != "Error") _history.AddRecord(txtTask.Text, Double.Parse(result, _culture));
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
           
            historyTableAdapter.Fill(calculatorHistoryDataSet.History);
            gridView2.CloseEditor();
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
            AddOrEditDialog dialog = new AddOrEditDialog(_history.GetRecord(Value, _culture));
            dialog.Text = "Редактирование";
           dialog.ShowDialog();
           var updateResult = dialog.GetResult();
           
            if (updateResult != null)
            {
                _history.updateRecord(updateResult, Value);
                historyTableAdapter.Fill(calculatorHistoryDataSet.History);
            }
        }

        private void AddRow(object sender, EventArgs e)
        {
            AddOrEditDialog dialog = new AddOrEditDialog(null);
            dialog.Text = "Создание";
            dialog.ShowDialog();
            _history.AddRecord(dialog.GetResult());
            historyTableAdapter.Fill(calculatorHistoryDataSet.History);
        }
    }
}