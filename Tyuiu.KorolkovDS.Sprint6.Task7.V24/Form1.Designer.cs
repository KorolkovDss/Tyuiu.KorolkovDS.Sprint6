namespace Tyuiu.KorolkovDS.Sprint6.Task7.V24
{
    partial class Form1
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
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            buttonSaveFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(12, 390);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(150, 48);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(168, 390);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(150, 48);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "OpenFile";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(12, 12);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(342, 357);
            dataGridViewIn.TabIndex = 2;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(360, 12);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(342, 357);
            dataGridViewOut.TabIndex = 3;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Location = new Point(324, 390);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(150, 48);
            buttonSaveFile.TabIndex = 4;
            buttonSaveFile.Text = "Save File";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSaveFile);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonDone);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private Button buttonDone;
        private Button buttonOpenFile;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Button buttonSaveFile;
    }
}
