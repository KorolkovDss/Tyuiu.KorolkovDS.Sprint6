namespace Tyuiu.KorolkovDS.Sprint6.Task0.V26
{
    partial class FormMain
    {
        
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
            textBoxTerm_KDS = new TextBox();
            ButtonDone_KDS = new Button();
            buttonquest_KDS = new Button();
            textBoxMain_KDS = new TextBox();
            textBoxData_KDS = new TextBox();
            textBoxDataX_KDS = new TextBox();
            pictureBoxFormula_KDS = new PictureBox();
            textBoxInPutX_KDS = new TextBox();
            textBox1 = new TextBox();
            textBoxResult_KDS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KDS).BeginInit();
            SuspendLayout();
            // 
            // textBoxTerm_KDS
            // 
            textBoxTerm_KDS.Location = new Point(33, 24);
            textBoxTerm_KDS.Multiline = true;
            textBoxTerm_KDS.Name = "textBoxTerm_KDS";
            textBoxTerm_KDS.ReadOnly = true;
            textBoxTerm_KDS.Size = new Size(72, 30);
            textBoxTerm_KDS.TabIndex = 0;
            textBoxTerm_KDS.Text = "Условие";
            // 
            // ButtonDone_KDS
            // 
            ButtonDone_KDS.Location = new Point(621, 394);
            ButtonDone_KDS.Name = "ButtonDone_KDS";
            ButtonDone_KDS.Size = new Size(123, 44);
            ButtonDone_KDS.TabIndex = 1;
            ButtonDone_KDS.Text = "Выполнить";
            ButtonDone_KDS.UseVisualStyleBackColor = true;
            ButtonDone_KDS.Click += ButtonDone_KDS_Click;
            // 
            // buttonquest_KDS
            // 
            buttonquest_KDS.Location = new Point(515, 394);
            buttonquest_KDS.Name = "buttonquest_KDS";
            buttonquest_KDS.Size = new Size(52, 44);
            buttonquest_KDS.TabIndex = 2;
            buttonquest_KDS.Text = "?";
            buttonquest_KDS.UseVisualStyleBackColor = true;
            buttonquest_KDS.Click += buttonquest_KDS_Click;
            // 
            // textBoxMain_KDS
            // 
            textBoxMain_KDS.Location = new Point(33, 60);
            textBoxMain_KDS.Multiline = true;
            textBoxMain_KDS.Name = "textBoxMain_KDS";
            textBoxMain_KDS.ReadOnly = true;
            textBoxMain_KDS.Size = new Size(723, 207);
            textBoxMain_KDS.TabIndex = 3;
            textBoxMain_KDS.Text = "Вычислить выражение по формуле";
            // 
            // textBoxData_KDS
            // 
            textBoxData_KDS.Location = new Point(33, 273);
            textBoxData_KDS.Multiline = true;
            textBoxData_KDS.Name = "textBoxData_KDS";
            textBoxData_KDS.ReadOnly = true;
            textBoxData_KDS.Size = new Size(125, 27);
            textBoxData_KDS.TabIndex = 4;
            textBoxData_KDS.Text = "Ввод данных";
            // 
            // textBoxDataX_KDS
            // 
            textBoxDataX_KDS.Location = new Point(33, 306);
            textBoxDataX_KDS.Name = "textBoxDataX_KDS";
            textBoxDataX_KDS.ReadOnly = true;
            textBoxDataX_KDS.Size = new Size(125, 27);
            textBoxDataX_KDS.TabIndex = 5;
            textBoxDataX_KDS.Text = "Переменная Х";
            // 
            // pictureBoxFormula_KDS
            // 
            pictureBoxFormula_KDS.Location = new Point(515, 73);
            pictureBoxFormula_KDS.Name = "pictureBoxFormula_KDS";
            pictureBoxFormula_KDS.Size = new Size(229, 144);
            pictureBoxFormula_KDS.TabIndex = 6;
            pictureBoxFormula_KDS.TabStop = false;
            pictureBoxFormula_KDS.Click += pictureBoxFormula_KDS_Click;
            // 
            // textBoxInPutX_KDS
            // 
            textBoxInPutX_KDS.Location = new Point(33, 350);
            textBoxInPutX_KDS.Name = "textBoxInPutX_KDS";
            textBoxInPutX_KDS.Size = new Size(125, 27);
            textBoxInPutX_KDS.TabIndex = 7;
            textBoxInPutX_KDS.TextChanged += textBoxInPutX_KDS_TextChanged;
            textBoxInPutX_KDS.KeyPress += textBoxInPutX_KDS_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 273);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "Выыод данных";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Location = new Point(515, 306);
            textBoxResult_KDS.Multiline = true;
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.ReadOnly = true;
            textBoxResult_KDS.Size = new Size(229, 71);
            textBoxResult_KDS.TabIndex = 9;
            textBoxResult_KDS.TextChanged += textBoxResult_KDS_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(textBoxResult_KDS);
            Controls.Add(textBox1);
            Controls.Add(textBoxInPutX_KDS);
            Controls.Add(pictureBoxFormula_KDS);
            Controls.Add(textBoxDataX_KDS);
            Controls.Add(textBoxData_KDS);
            Controls.Add(textBoxMain_KDS);
            Controls.Add(buttonquest_KDS);
            Controls.Add(ButtonDone_KDS);
            Controls.Add(textBoxTerm_KDS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 26 | Корольков Д. С.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTerm_KDS;
        private Button ButtonDone_KDS;
        private Button buttonquest_KDS;
        private TextBox textBoxMain_KDS;
        private TextBox textBoxData_KDS;
        private TextBox textBoxDataX_KDS;
        private PictureBox pictureBoxFormula_KDS;
        private TextBox textBoxInPutX_KDS;
        private TextBox textBox1;
        private TextBox textBoxResult_KDS;
    }
}
