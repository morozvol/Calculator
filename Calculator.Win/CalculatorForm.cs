using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Globalization;



namespace Calculator.Win
{
    public partial class CalculatorForm : Form
    {

        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            History.History history =new History.History();

            CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");

            Core.Calculator calculator = new Core.Calculator(txtTask.Text, culture, txtTask.Text);

           var result = calculator.CalculateExpression();

            var lastRecord = history.GetLastRecord();
            txtTask.Text = String.Format("{0}={1}{2}", lastRecord.Task,
                                         lastRecord.Result,
                                         lastRecord.Error);
            
            //if (result != "Error")
            //{
            //    txtTask.Text += String.Format(" = {0}", result);
            //}

            cmbHistory.Items.Insert(0, txtTask.Text);

            txtTask.Text = String.Empty;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}