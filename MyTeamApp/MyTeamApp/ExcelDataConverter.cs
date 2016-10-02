using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.IO;

namespace MyTeamApp
{
    public class ExcelDataConverter
    {
        private Excel.Application _myApp = null;
        private Excel.Workbook _myBook = null;
        private Excel.Worksheet _mySheet = null;
        private string _excelFile;
        private StringBuilder _outputBuilder;


        public void ExportData(string filePath, int sheetNumber, string outputFile)
        {
            _outputBuilder = new StringBuilder();
            _excelFile = filePath;
            _myApp = new Excel.Application();
            _myApp.Visible = false;
            _myBook = _myApp.Workbooks.Open(_excelFile);
            _mySheet = (Excel.Worksheet)_myBook.Sheets[sheetNumber]; // Explict cast is not required here
            ConvertData();
            SaveTo(outputFile);
            _myBook.Close(false);
            _myApp.Quit();
        }

        private void ConvertData()
        {
            AddRow1();
            AddRow2To10();
        }

        private void AddRow1()
        {
            string cell22 = _mySheet.Cells[2, 2].Value.ToString();
            string cell26 = _mySheet.Cells[2, 6].Value.ToString();
            string line = string.Format("{0} {1}", cell22, cell26);
            _outputBuilder.AppendLine(line);
        }

        private void AddRow2To10()
        {
            for (int i = 2; i <= 10; i++)
            {
                string cell22 = _mySheet.Cells[i, 2].Value.ToString();
                string cell26 = _mySheet.Cells[i, 6].Value.ToString();
                string line = string.Format("{0} {1}", cell22, cell26);
                _outputBuilder.AppendLine(line);
            }
        }

        private void SaveTo(string outputFile)
        {
            File.WriteAllText(outputFile, _outputBuilder.ToString());
        }

    }
    
}
