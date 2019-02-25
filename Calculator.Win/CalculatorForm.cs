using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraPrinting.Native.DrillDown;
using HistoryRepository;


namespace Calculator.Win
{
    public partial class CalculatorForm : Form
    {

        public event EventHandler Edit;
        public event EventHandler Delete;
        public event EventHandler Add;

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
            }
            catch (ErrorException ex)
            {
                Console.WriteLine(ex.Message);
            }

            txtTask.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "calculatorHistoryDataSet.History". При необходимости она может быть перемещена или удалена.
            this.historyTableAdapter.Fill(this.calculatorHistoryDataSet.History);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
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
        }


        private void EditRow(object sender, EventArgs e)
        {
         
            object Value = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Id");
            AddOrEditRowDialod.ShowDialog( "Редактирование",new History().GetRecord(Int32.Parse(Value.ToString())));
        }

        private void AddRow(object sender, EventArgs e)
        {
            AddOrEditRowDialod.ShowDialog("Создание",null);
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
                menu.Items.Add(new DXMenuItem("Удалить",Delete));
                menu.Items.Add(new DXMenuItem("Изменить",Edit));
                menu.Items.Add(new DXMenuItem("Добавить",Add));
                e.Menu = menu; 
            }
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
    }
}