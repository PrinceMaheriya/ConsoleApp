using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface PDFService
    {
        void GeneratePDF();
    }

    interface ExcelService
    {
        void GenerateExcel();
    }

    public class GenrateReport : PDFService, ExcelService
    {
        private string filetext;

        public GenrateReport( string file_text)
        {
            filetext = file_text;
        }
        //Commentout 
        //DataTable dbtble = new DataTable("CustomerDetails");
        //DataColumn dbColumn;
        //dbColumn = new DataColumn();
        //dbColumn.DataType = typeof(Int32);
        //        dbColumn.ColumnName = "ID";
        //        dbColumn.Caption = "Customer Id";
        //        dbColumn.ReadOnly = false;
        //        dbColumn.Unique = true;
        //        dbtble.Columns.Add(dbColumn);

        //        dbColumn = new DataColumn();
        //dbColumn.DataType = typeof(string);
        //        dbColumn.ColumnName = "Name";
        //        dbColumn.Caption = "Customer Name";
        //        dbColumn.ReadOnly = false;
        //        dbColumn.Unique = false;
        //        dbtble.Columns.Add(dbColumn);

        public void GenerateExcel()
        {
            StreamWriter sw;
            sw = File.CreateText(@"D:\customer.xls");
            sw.WriteLine(filetext);
            sw.Close();
        }

        public void GeneratePDF()
        {
            try
            {
                

                StreamWriter sw;

                string fileName = @"D:\Customer.pdf";
                sw = File.CreateText(fileName);


                string FileData = filetext;
                sw.WriteLine(FileData);
                sw.Close();


            }
            catch(Exception ex)
            {
                StreamWriter stw;
                string filePath = @"D:\log.txt";
                stw = File.CreateText(filePath);
                stw.WriteLine("GeneratePDF Failed : {0}", ex.Message);
                stw.Close();
            }
        }

        public void GenerateWordDoc()
        {
            try
            {
                StreamWriter sw;
                sw = File.CreateText(@"D:\Customer.doc");
                sw.WriteLine(filetext);
                sw.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("GenerateWordDoc Failed : {0}", ex.Message);
            }
        }
    }
}
