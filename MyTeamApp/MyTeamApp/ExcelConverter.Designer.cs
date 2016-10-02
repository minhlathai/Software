namespace MyTeamApp
{
    partial class ExcelConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtExcelFilename = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numericSheet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputOpenFile = new System.Windows.Forms.Button();
            this.txtOutputTxtFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.AutoSize = true;
            this.lblOpenFile.Location = new System.Drawing.Point(30, 52);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(49, 13);
            this.lblOpenFile.TabIndex = 0;
            this.lblOpenFile.Text = "Excel file";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(533, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtExcelFilename
            // 
            this.txtExcelFilename.Location = new System.Drawing.Point(85, 49);
            this.txtExcelFilename.Name = "txtExcelFilename";
            this.txtExcelFilename.Size = new System.Drawing.Size(442, 20);
            this.txtExcelFilename.TabIndex = 2;
            this.txtExcelFilename.Text = @"C:\input.xlsx";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(533, 47);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(36, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // numericSheet
            // 
            this.numericSheet.Location = new System.Drawing.Point(85, 75);
            this.numericSheet.Name = "numericSheet";
            this.numericSheet.Size = new System.Drawing.Size(50, 20);
            this.numericSheet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sheet Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output Txt File";
            // 
            // btnOutputOpenFile
            // 
            this.btnOutputOpenFile.Location = new System.Drawing.Point(533, 99);
            this.btnOutputOpenFile.Name = "btnOutputOpenFile";
            this.btnOutputOpenFile.Size = new System.Drawing.Size(36, 23);
            this.btnOutputOpenFile.TabIndex = 1;
            this.btnOutputOpenFile.Text = "...";
            this.btnOutputOpenFile.UseVisualStyleBackColor = true;
            this.btnOutputOpenFile.Click += new System.EventHandler(this.btnOutputOpenFile_Click);
            // 
            // txtOutputTxtFile
            // 
            this.txtOutputTxtFile.Location = new System.Drawing.Point(85, 101);
            this.txtOutputTxtFile.Name = "txtOutputTxtFile";
            this.txtOutputTxtFile.Size = new System.Drawing.Size(442, 20);
            this.txtOutputTxtFile.TabIndex = 2;
            this.txtOutputTxtFile.Text = @"C:\data-output.txt";
            // 
            // ExcelConverter
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 291);
            this.Controls.Add(this.numericSheet);
            this.Controls.Add(this.txtOutputTxtFile);
            this.Controls.Add(this.btnOutputOpenFile);
            this.Controls.Add(this.txtExcelFilename);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOpenFile);
            this.Name = "ExcelConverter";
            this.Text = "ExcelConverter";
            ((System.ComponentModel.ISupportInitialize)(this.numericSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtExcelFilename;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown numericSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutputOpenFile;
        private System.Windows.Forms.TextBox txtOutputTxtFile;
    }
}