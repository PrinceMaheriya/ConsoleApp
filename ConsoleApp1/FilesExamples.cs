using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class FilesExamples
    {
        const string fileName = "TestFile.txt";

        public static void CreateTextFile()

        {
            Console.WriteLine($"CreateTextFile Is File Exists : {File.Exists(fileName)}");

            if (!File.Exists(fileName))
            {
                //File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("It's a text file generated through CreateTextFile." + DateTime.Now);
                }
            }

            OverWriteTextFile();

            ReadFileData();
        }

        public static void OverWriteTextFile()
        {
            //if (File.Exists(fileName))
            //{
            //    File.AppendAllText(fileName, "This function write all text using File.WriteAllText method." + DateTime.Now +Environment.NewLine);
            //}

            //File.AppendAllText(fileName, DateTime.Now + Environment.NewLine +"This is 2nd line" + Environment.NewLine);

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine("Line 1");
                sw.WriteLine("Line 2");
                sw.WriteLine("Line 3");
            }
        }

        public static void ReadFileData()
        {
            if(File.Exists(fileName))
            {
              Console.WriteLine("ReadFileData : {0}",File.ReadAllText(fileName));
            }

            //you can also change the file creation time using below method:
            File.SetCreationTime(fileName, new DateTime(2023, 01, 01));

            //file general info
            Console.WriteLine(File.GetCreationTime(fileName));
            Console.WriteLine(File.GetLastAccessTime(fileName));
            Console.WriteLine(File.GetLastWriteTime(fileName));

            //File.SetAttributes(fileName, FileAttributes.ReadOnly);
            Console.WriteLine(File.GetAttributes(fileName));

            //file info using fileinfo
            FileInfo fi = new FileInfo(fileName);
            Console.WriteLine($"{fi.Length}");
            Console.WriteLine($"{fi.Directory}");
            Console.WriteLine($"{fi.IsReadOnly}");
        }
    }
}
