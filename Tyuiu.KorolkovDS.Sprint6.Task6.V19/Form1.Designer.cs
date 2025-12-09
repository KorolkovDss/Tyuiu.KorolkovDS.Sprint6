namespace Tyuiu.KorolkovDS.Sprint6.Task6.V19
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
            components = new System.ComponentModel.Container();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            buttonOpenFile = new Button();
            openFileDialog = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            textBoxLoadFromFile = new TextBox();
            groupBoxOutPutData = new GroupBox();
            textBoxInPut = new TextBox();
            textBoxOut = new TextBox();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(12, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(72, 67);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(553, 72);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(235, 196);
            textBoxResult.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(90, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(72, 67);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Open File";
            toolTip1.SetToolTip(buttonOpenFile, "Open needing file");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(312, 72);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.Size = new Size(235, 196);
            textBoxLoadFromFile.TabIndex = 3;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Location = new Point(12, 85);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(294, 320);
            groupBoxOutPutData.TabIndex = 4;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Path";
            // 
            // textBoxInPut
            // 
            textBoxInPut.Location = new Point(312, 39);
            textBoxInPut.Name = "textBoxInPut";
            textBoxInPut.ReadOnly = true;
            textBoxInPut.Size = new Size(125, 27);
            textBoxInPut.TabIndex = 5;
            textBoxInPut.Text = "In Put Data";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(553, 39);
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(125, 27);
            textBoxOut.TabIndex = 6;
            textBoxOut.Text = "Out Put Data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOut);
            Controls.Add(textBoxInPut);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(textBoxLoadFromFile);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxResult);
            Controls.Add(buttonDone);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxResult;
        private Button buttonOpenFile;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog;
        private TextBox textBoxLoadFromFile;
        private GroupBox groupBoxOutPutData;
        private TextBox textBoxInPut;
        private TextBox textBoxOut;
    }
}
