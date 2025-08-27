using System;
using System.IO;


namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\text\one.txt";
            string targetPath = @"c:\text\two.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:" + e.Message);
            }
        }
    }
}
