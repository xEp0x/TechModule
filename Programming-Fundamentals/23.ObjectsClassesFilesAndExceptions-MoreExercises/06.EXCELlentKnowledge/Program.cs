﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Excell = Microsoft.Office.Interop.Excel;    //Excell s dwojno l zashtoto inache ne raboti

namespace _06.EXCELlentKnowledge
{
    class Excel
    {
        static void Main(string[] args)
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excell.Application xlApp = new Excell.Application();
            Excell.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Jo\Documents\visual studio 2017\Projects\23.ObjectsClassesFilesAndExceptions-MoreExercises\06.EXCELlentKnowledge\bin\Debug\sample_table.xlsx");
            Excell._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excell.Range xlRange = xlWorksheet.UsedRange;

            //int rowCount = xlRange.Rows.Count;
            //int colCount = xlRange.Columns.Count;

            int rowCount = 5;
            int colCount = 5;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!            
            File.WriteAllText(@"output.txt", string.Empty);

            for (int i = 1; i <= rowCount; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 1; j <= colCount; j++)
                {
                    //new line                
                    //if (j == 1)
                    //{
                    //    //Console.Write("\r\n");
                    //    sb.Append($"\r\n");
                    //}

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        //Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                        sb.Append($"{xlRange.Cells[i, j].Value2}|");
                    }
                }
                var str = sb.ToString();
                File.AppendAllText(@"output.txt", str + "\n");
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
