using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.IO;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Files
{
    class DirectoryDirectoryInfo
    {
       public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\newfolder");


           /* var files = Directory.GetFiles(@"D:\Videos", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }*/

            var directories = Directory.GetDirectories(@"D:\Videos", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryInfo = new DirectoryInfo("..");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
} 