namespace Tyuiu.KorolkovDS.Sprint6.Task2.V23
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
            textBoxTerm_KDS = new TextBox();
            textBoxUsl_KDS = new TextBox();
            textBoxData_KDS = new TextBox();
            textBoxStart_KDS = new TextBox();
            textBoxStop_KDS = new TextBox();
            textBoxStartV_KDS = new TextBox();
            textBoxStopV_KDS = new TextBox();
            buttonDone_KDS = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            textBoxDataOut_KDS = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // textBoxTerm_KDS
            // 
            textBoxTerm_KDS.Location = new Point(12, 12);
            textBoxTerm_KDS.Multiline = true;
            textBoxTerm_KDS.Name = "textBoxTerm_KDS";
            textBoxTerm_KDS.Size = new Size(125, 34);
            textBoxTerm_KDS.TabIndex = 0;
            textBoxTerm_KDS.Text = "Условие";
            // 
            // textBoxUsl_KDS
            // 
            textBoxUsl_KDS.Location = new Point(12, 52);
            textBoxUsl_KDS.Multiline = true;
            textBoxUsl_KDS.Name = "textBoxUsl_KDS";
            textBoxUsl_KDS.ReadOnly = true;
            textBoxUsl_KDS.Size = new Size(302, 230);
            textBoxUsl_KDS.TabIndex = 1;
            textBoxUsl_KDS.Text = "Протабулировать функцию";
            // 
            // textBoxData_KDS
            // 
            textBoxData_KDS.Location = new Point(12, 288);
            textBoxData_KDS.Name = "textBoxData_KDS";
            textBoxData_KDS.ReadOnly = true;
            textBoxData_KDS.Size = new Size(125, 27);
            textBoxData_KDS.TabIndex = 2;
            textBoxData_KDS.Text = "Ввод данных";
            // 
            // textBoxStart_KDS
            // 
            textBoxStart_KDS.Location = new Point(12, 321);
            textBoxStart_KDS.Name = "textBoxStart_KDS";
            textBoxStart_KDS.ReadOnly = true;
            textBoxStart_KDS.Size = new Size(125, 27);
            textBoxStart_KDS.TabIndex = 3;
            textBoxStart_KDS.Text = "Старт";
            // 
            // textBoxStop_KDS
            // 
            textBoxStop_KDS.Location = new Point(143, 321);
            textBoxStop_KDS.Name = "textBoxStop_KDS";
            textBoxStop_KDS.ReadOnly = true;
            textBoxStop_KDS.Size = new Size(125, 27);
            textBoxStop_KDS.TabIndex = 4;
            textBoxStop_KDS.Text = "Стоп";
            // 
            // textBoxStartV_KDS
            // 
            textBoxStartV_KDS.Location = new Point(12, 357);
            textBoxStartV_KDS.Name = "textBoxStartV_KDS";
            textBoxStartV_KDS.Size = new Size(125, 27);
            textBoxStartV_KDS.TabIndex = 5;
            textBoxStartV_KDS.KeyPress += textBoxStartV_KDS_KeyPress;
            // 
            // textBoxStopV_KDS
            // 
            textBoxStopV_KDS.Location = new Point(143, 357);
            textBoxStopV_KDS.Name = "textBoxStopV_KDS";
            textBoxStopV_KDS.Size = new Size(125, 27);
            textBoxStopV_KDS.TabIndex = 6;
            textBoxStopV_KDS.TextChanged += textBox2_TextChanged;
            textBoxStopV_KDS.KeyPress += textBoxStopV_KDS_KeyPress;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(326, 344);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(150, 52);
            buttonDone_KDS.TabIndex = 7;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(326, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(150, 281);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 50F;
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 75;
            // 
            // textBoxDataOut_KDS
            // 
            textBoxDataOut_KDS.Location = new Point(326, 19);
            textBoxDataOut_KDS.Name = "textBoxDataOut_KDS";
            textBoxDataOut_KDS.Size = new Size(125, 27);
            textBoxDataOut_KDS.TabIndex = 9;
            textBoxDataOut_KDS.Text = "Вывод данных";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(499, 52);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(464, 281);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 413);
            Controls.Add(chart1);
            Controls.Add(textBoxDataOut_KDS);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDone_KDS);
            Controls.Add(textBoxStopV_KDS);
            Controls.Add(textBoxStartV_KDS);
            Controls.Add(textBoxStop_KDS);
            Controls.Add(textBoxStart_KDS);
            Controls.Add(textBoxData_KDS);
            Controls.Add(textBoxUsl_KDS);
            Controls.Add(textBoxTerm_KDS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 23 | Корольков Д. С.";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTerm_KDS;
        private TextBox textBoxUsl_KDS;
        private TextBox textBoxData_KDS;
        private TextBox textBoxStart_KDS;
        private TextBox textBoxStop_KDS;
        private TextBox textBoxStartV_KDS;
        private TextBox textBoxStopV_KDS;
        private Button buttonDone_KDS;
        private DataGridView dataGridView1;
        private TextBox textBoxDataOut_KDS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
