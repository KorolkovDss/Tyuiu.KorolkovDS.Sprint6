namespace Tyuiu.KorolkovDS.Sprint6.Task4.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            textBoxTerm = new TextBox();
            textBoxTerm2 = new TextBox();
            textBox3 = new TextBox();
            textBoxStartV = new TextBox();
            textBoxStopV = new TextBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxOutPutDataFile = new TextBox();
            textBoxOutPutData = new TextBox();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(288, 393);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(158, 45);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxTerm
            // 
            textBoxTerm.Location = new Point(12, 12);
            textBoxTerm.Name = "textBoxTerm";
            textBoxTerm.ReadOnly = true;
            textBoxTerm.Size = new Size(125, 27);
            textBoxTerm.TabIndex = 1;
            textBoxTerm.Text = "Условие";
            // 
            // textBoxTerm2
            // 
            textBoxTerm2.Location = new Point(12, 45);
            textBoxTerm2.Multiline = true;
            textBoxTerm2.Name = "textBoxTerm2";
            textBoxTerm2.ReadOnly = true;
            textBoxTerm2.Size = new Size(256, 210);
            textBoxTerm2.TabIndex = 2;
            textBoxTerm2.Text = "Протабулировать функцию и сохранить ее в файл";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 261);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            textBox3.Text = "Ввод данных";
            // 
            // textBoxStartV
            // 
            textBoxStartV.Location = new Point(12, 306);
            textBoxStartV.Name = "textBoxStartV";
            textBoxStartV.ReadOnly = true;
            textBoxStartV.Size = new Size(125, 27);
            textBoxStartV.TabIndex = 4;
            textBoxStartV.Text = "Начало";
            // 
            // textBoxStopV
            // 
            textBoxStopV.Location = new Point(143, 306);
            textBoxStopV.Name = "textBoxStopV";
            textBoxStopV.ReadOnly = true;
            textBoxStopV.Size = new Size(125, 27);
            textBoxStopV.TabIndex = 5;
            textBoxStopV.Text = "Конец";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 339);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 6;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(143, 339);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 7;
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(288, 45);
            chartFunc.Name = "chartFunc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(321, 321);
            chartFunc.TabIndex = 8;
            // 
            // textBoxOutPutDataFile
            // 
            textBoxOutPutDataFile.Location = new Point(630, 45);
            textBoxOutPutDataFile.Multiline = true;
            textBoxOutPutDataFile.Name = "textBoxOutPutDataFile";
            textBoxOutPutDataFile.Size = new Size(225, 393);
            textBoxOutPutDataFile.TabIndex = 9;
            // 
            // textBoxOutPutData
            // 
            textBoxOutPutData.Location = new Point(288, 12);
            textBoxOutPutData.Name = "textBoxOutPutData";
            textBoxOutPutData.Size = new Size(125, 27);
            textBoxOutPutData.TabIndex = 10;
            textBoxOutPutData.Text = "Вывод данных";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(452, 393);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 45);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 450);
            Controls.Add(buttonSave);
            Controls.Add(textBoxOutPutData);
            Controls.Add(textBoxOutPutDataFile);
            Controls.Add(chartFunc);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStopV);
            Controls.Add(textBoxStartV);
            Controls.Add(textBox3);
            Controls.Add(textBoxTerm2);
            Controls.Add(textBoxTerm);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxTerm;
        private TextBox textBoxTerm2;
        private TextBox textBox3;
        private TextBox textBoxStartV;
        private TextBox textBoxStopV;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private TextBox textBoxOutPutDataFile;
        private TextBox textBoxOutPutData;
        private Button buttonSave;
    }
}
