﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\sample.txt");
            using StreamWriter str =fi.CreateText();//create a text file 
            Console.WriteLine("File has been created");
            str.WriteLine("hello There");
            str.WriteLine("HI");
            Console.WriteLine("Written");
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("sample2.txt",
                FileMode.CreateNew,FileAccess.Write);
            StreamWriter sw= new StreamWriter(fs);
            Console.WriteLine("Enter the text which"+ " you want to write to the file ");
            string? str=Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0,SeekOrigin.Begin);
            string str=sr.ReadLine();
            while(str != null)
            {
                Console.WriteLine(str);
                str =sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo fil = new FileInfo("C:\\Users\\Administrator\\Desktop\\sample.txt");
            FileInfo fil2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\sample2.txt");
            fil.CopyTo("C:\\Users\\Administrator\\Desktop\\temp1\\sample.txt");
            fil2.MoveTo("C:\\Users\\Administrator\\Desktop\\temp1\\sample2.txt");
        }
        public void Delete()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\temp1\\sample.txt");
            fi.Delete();
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\sample.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.LastWriteTime);
        }
    }
}
