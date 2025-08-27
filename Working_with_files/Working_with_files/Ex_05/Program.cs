using System;

using System.IO;
using System.Collections.Generic;   

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\text";
            try
            {
                IEnumerable<string> folders  = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);

            }
        }

    }
}