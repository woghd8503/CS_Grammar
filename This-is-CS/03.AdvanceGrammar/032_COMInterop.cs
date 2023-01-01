using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace _0003._AdvanceGrammar
{
    class MainApp
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

            for(int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)worksheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)worksheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }

            worksheet.SaveAs2
        }
    }
}
