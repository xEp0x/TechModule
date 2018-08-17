using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _05.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesInDirectory = Directory.GetFiles(@"c:\");
            var allFileSize = 0.0;

            foreach (var file in filesInDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                allFileSize += fileInfo.Length;
            }

            allFileSize = allFileSize / (1024 * 1024);

            File.WriteAllText(@"c:\temp\output5.txt", allFileSize.ToString() + " MB");
        }
    }
}
