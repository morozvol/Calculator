using System;
using System.Windows.Forms;
using  HistoryRepository;

namespace Calculator.Win
{
    class AddOrEditRowDialod
    {
        public static Record ShowDialog(string caption, Record record)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 300,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
          
            Record result = null;
            var labelCondition = new Label() {Left = 10, Top = 50, Text = "Условие"};
            var labelResult = new Label() {Left = 10, Top = 75, Text = "Результат"};
            var labelError = new Label() {Left = 10, Top = 100, Text = "Ошибка"};
            var labelDateTime = new Label() {Left = 10, Top = 125, Text = "Время и дата"};
            var labelLogin = new Label() {Left = 10, Top = 150, Text = "Логин"};
            var labelHostName = new Label() {Left = 10, Top = 175, Text = "Имя компьютера"};

            var txtCondition = new TextBox() {Left = 125, Top = 50, Width = 350};
            var txtResult = new TextBox() {Left = 125, Top = 75, Width = 350, };
            var txtError = new TextBox() {Left = 125, Top = 100, Width = 350};
            var txtDateTime = new TextBox() {Left = 125, Top = 125, Width = 350};
            var txtLogin = new TextBox() {Left = 125, Top = 150, Width = 350};
            var txtHostName = new TextBox() {Left = 125, Top = 175, Width = 350};

            if (record != null)
            {
                //txtCondition.Text = record.Task;
                //txtResult.Text = record.Result.ToString();
                //txtError.Text = record.Error;
                //txtDateTime.Text = record.DateTime;
                //txtLogin.Text = record.Login;
                //txtHostName.Text = record.HostName;
            }
            var confirmation = new Button()
                {Text = "Сохранить", Left = 350, Width = 100, Top = 225, DialogResult = DialogResult.OK};
            confirmation.Click += (sender, e) =>
            {
                result = new Record(txtCondition.Text,Double.Parse(txtResult.Text),
                    txtError.Text,txtDateTime.Text,txtLogin.Text,txtHostName.Text);
                prompt.Close();
            };



            prompt.Controls.Add(confirmation);

            prompt.Controls.Add(txtCondition);
            prompt.Controls.Add(txtResult);
            prompt.Controls.Add(txtError);
            prompt.Controls.Add(txtDateTime);
            prompt.Controls.Add(txtLogin);
            prompt.Controls.Add(txtHostName);

            prompt.Controls.Add(labelCondition);
            prompt.Controls.Add(labelResult);
            prompt.Controls.Add(labelError);
            prompt.Controls.Add(labelDateTime);
            prompt.Controls.Add(labelLogin);
            prompt.Controls.Add(labelHostName);

            prompt.AcceptButton = confirmation;


            return result;
        }
    }
}