using System;
using System.Windows.Forms;
using Calculator.HistoryRepository;

namespace Calculator.Win
{
    public partial class AddOrEditDialog : Form
    {
        private Record _record, _result;

        public AddOrEditDialog(Record record)
        {
            InitializeComponent();
            _record = record;
        } 

        private void button2_Click(object sender, System.EventArgs e)
        { 
                if (IsValid(txtCondition.Text, txtResult.Text, txtError.Text, dateTime.Text, txtLogin.Text,
                    txtHostName.Text))
                {
                    double res;
                    double? My_Value = double.TryParse(txtResult.Text, out res)
                        ? (double?)res
                        : null;

                    _result = new Record(txtCondition.Text, My_Value,
                        txtError.Text, dateTime.Value, txtLogin.Text, txtHostName.Text);
                    Close();
                }
        }

        public Record GetResult()
        {
            return _result;
        }

        private bool IsValid(string conditon, string result, string error, string dateTime, string login, string hostName)
        {
            if (dateTime == "" || login == "" || hostName == "" || (result == "" && error == "")) return false;
            double buf;
            Double.TryParse(result, out buf);
            return true;
        }

       
        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            if (_record != null)
            {
                txtCondition.Text = _record.Task;
                txtResult.Text = _record.Result.ToString();
                txtError.Text = _record.Error;
                dateTime.Text = _record.DateTime.ToString();
                txtLogin.Text = _record.Login;
                txtHostName.Text = _record.HostName;
            }
        }
    }
}


