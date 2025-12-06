namespace Tyuiu.KorolkovDS.Sprint6.Task1.V4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxterm_KDS = new TextBox();
            textBox1 = new TextBox();
            textBoxInPutData_KDS = new TextBox();
            textBoxStartV_KDS = new TextBox();
            textBoxStopV_KDS = new TextBox();
            textBoxStart_KDS = new TextBox();
            textBoxStop_KDS = new TextBox();
            textBoxOutPutData_KDS = new TextBox();
            textBoxRes_KDS = new TextBox();
            buttonDone_KDS = new Button();
            SuspendLayout();
            // 
            // textBoxterm_KDS
            // 
            textBoxterm_KDS.Location = new Point(12, 12);
            textBoxterm_KDS.Name = "textBoxterm_KDS";
            textBoxterm_KDS.ReadOnly = true;
            textBoxterm_KDS.Size = new Size(125, 27);
            textBoxterm_KDS.TabIndex = 0;
            textBoxterm_KDS.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(486, 266);
            textBox1.TabIndex = 1;
            textBox1.Text = "Протабулировать функцию";
            // 
            // textBoxInPutData_KDS
            // 
            textBoxInPutData_KDS.Location = new Point(12, 317);
            textBoxInPutData_KDS.Name = "textBoxInPutData_KDS";
            textBoxInPutData_KDS.ReadOnly = true;
            textBoxInPutData_KDS.Size = new Size(125, 27);
            textBoxInPutData_KDS.TabIndex = 2;
            textBoxInPutData_KDS.Text = "Ввод данных";
            // 
            // textBoxStartV_KDS
            // 
            textBoxStartV_KDS.Location = new Point(12, 350);
            textBoxStartV_KDS.Name = "textBoxStartV_KDS";
            textBoxStartV_KDS.ReadOnly = true;
            textBoxStartV_KDS.Size = new Size(125, 27);
            textBoxStartV_KDS.TabIndex = 3;
            textBoxStartV_KDS.Text = "Начало шага:";
            // 
            // textBoxStopV_KDS
            // 
            textBoxStopV_KDS.Location = new Point(143, 350);
            textBoxStopV_KDS.Name = "textBoxStopV_KDS";
            textBoxStopV_KDS.ReadOnly = true;
            textBoxStopV_KDS.Size = new Size(125, 27);
            textBoxStopV_KDS.TabIndex = 4;
            textBoxStopV_KDS.Text = "Конец шага";
            // 
            // textBoxStart_KDS
            // 
            textBoxStart_KDS.Location = new Point(12, 383);
            textBoxStart_KDS.Name = "textBoxStart_KDS";
            textBoxStart_KDS.Size = new Size(125, 27);
            textBoxStart_KDS.TabIndex = 5;
            // 
            // textBoxStop_KDS
            // 
            textBoxStop_KDS.Location = new Point(143, 383);
            textBoxStop_KDS.Name = "textBoxStop_KDS";
            textBoxStop_KDS.Size = new Size(125, 27);
            textBoxStop_KDS.TabIndex = 6;
            // 
            // textBoxOutPutData_KDS
            // 
            textBoxOutPutData_KDS.Location = new Point(544, 12);
            textBoxOutPutData_KDS.Name = "textBoxOutPutData_KDS";
            textBoxOutPutData_KDS.ReadOnly = true;
            textBoxOutPutData_KDS.Size = new Size(125, 27);
            textBoxOutPutData_KDS.TabIndex = 7;
            textBoxOutPutData_KDS.Text = "Вывод данных:";
            // 
            // textBoxRes_KDS
            // 
            textBoxRes_KDS.Location = new Point(544, 45);
            textBoxRes_KDS.Multiline = true;
            textBoxRes_KDS.Name = "textBoxRes_KDS";
            textBoxRes_KDS.ReadOnly = true;
            textBoxRes_KDS.Size = new Size(229, 320);
            textBoxRes_KDS.TabIndex = 8;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(544, 383);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(149, 43);
            buttonDone_KDS.TabIndex = 9;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_KDS);
            Controls.Add(textBoxRes_KDS);
            Controls.Add(textBoxOutPutData_KDS);
            Controls.Add(textBoxStop_KDS);
            Controls.Add(textBoxStart_KDS);
            Controls.Add(textBoxStopV_KDS);
            Controls.Add(textBoxStartV_KDS);
            Controls.Add(textBoxInPutData_KDS);
            Controls.Add(textBox1);
            Controls.Add(textBoxterm_KDS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 4 | Корольков Д. С.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxterm_KDS;
        private TextBox textBox1;
        private TextBox textBoxInPutData_KDS;
        private TextBox textBoxStartV_KDS;
        private TextBox textBoxStopV_KDS;
        private TextBox textBoxStart_KDS;
        private TextBox textBoxStop_KDS;
        private TextBox textBoxOutPutData_KDS;
        private TextBox textBoxRes_KDS;
        private Button buttonDone_KDS;
    }
}
