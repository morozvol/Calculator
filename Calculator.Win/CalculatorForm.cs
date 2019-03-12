using System;
using System.Windows.Forms;
using System.Globalization;
using Calculator.HistoryRepository;
using Calculator.Win.Properties;


namespace Calculator.Win
{
    public partial class CalculatorForm : Form
    {
        private CultureInfo _culture;

        private History _history = new History(Settings.Default.CalculatorHistoryConnectionString);

        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _culture = CultureInfo.GetCultureInfo("ru-RU");

            Core.Calculator calculator = new Core.Calculator(txtTask.Text, _culture, txtTask.Text);

            var result = calculator.CalculateExpression();
            _history.AddRecord(txtTask.Text, result);

            calcLogTableAdapter.Fill(calculatorHistoryDataSet.CalcLog);


          txtTask.Text = String.Empty;
        }
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            calcLogTableAdapter.Fill(calculatorHistoryDataSet.CalcLog);
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
                var id = (int) gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id");
                _history.DeleteRecord(id);
               calcLogTableAdapter.Fill(calculatorHistoryDataSet.CalcLog);
            }
        }

        private void EditRow(object sender, EventArgs e)
        {
            var Value = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id");
            AddOrEditDialog dialog = new AddOrEditDialog(_history.GetRecord(Value, _culture));
            dialog.Text = "Редактирование";
            dialog.ShowDialog();
            var updateResult = dialog.GetResult();

            if (updateResult != null)
            {
                _history.UpdateRecord(updateResult, Value);
                calcLogTableAdapter.Fill(calculatorHistoryDataSet.CalcLog);
            }
        }

        private void AddRow(object sender, EventArgs e)
        {
            AddOrEditDialog dialog = new AddOrEditDialog(null);
            dialog.Text = "Создание";
            dialog.ShowDialog();
            _history.AddRecord(dialog.GetResult());
            calcLogTableAdapter.Fill(calculatorHistoryDataSet.CalcLog);
        }

        public void gridView_Click(object sender, EventArgs e)
        {
            var id = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id");
            _history.GetTracing(id);
        }
    }
}