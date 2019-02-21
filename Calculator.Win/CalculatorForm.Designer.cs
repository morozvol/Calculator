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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.cmbHistory = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(431, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(72, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(84, 27);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(341, 20);
            this.txtTask.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Выражение";
            // 
            // cmbHistory
            // 
            this.cmbHistory.FormattingEnabled = true;
            this.cmbHistory.HorizontalScrollbar = true;
            this.cmbHistory.Location = new System.Drawing.Point(84, 59);
            this.cmbHistory.Name = "cmbHistory";
            this.cmbHistory.Size = new System.Drawing.Size(341, 147);
            this.cmbHistory.TabIndex = 3;
            this.cmbHistory.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 24);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 218);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbHistory);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox cmbHistory;
        private System.Windows.Forms.Button button2;
    }
}

