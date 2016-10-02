using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyTeamApp
{
    public partial class ExcelConverter : Form
    {
        private ExcelDataConverter _excelDataConverter;
        public ExcelConverter()
        {
            InitializeComponent();
            _excelDataConverter = new ExcelDataConverter();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtExcelFilename.Text = openFileDialog.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtExcelFilename.Text) || !File.Exists(txtExcelFilename.Text) ||
                string.IsNullOrEmpty(txtOutputTxtFile.Text))
            {
                MessageBox.Show("Please enter valid path for the excel input/output");
                return;
            }
            _excelDataConverter.ExportData(txtExcelFilename.Text, (int)numericSheet.Value, txtOutputTxtFile.Text);
        }

        private void btnOutputOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputTxtFile.Text = openFileDialog.FileName;
            }

        }
    }
}
