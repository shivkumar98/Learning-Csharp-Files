using System;
using System.IO;

namespace Files
{
    class FileFileInfo
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\myfile.jpg";
            File.Copy(path, @"d:\temp\myfile.jpg",true);
            if (File.Exists(path))
            {
                Console.WriteLine("hello");
            }
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

            var fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo);


         
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }


        }
    }
}
