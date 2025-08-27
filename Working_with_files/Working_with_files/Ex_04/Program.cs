using System;

using System.IO;



namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\text\first.txt";
            string targetpath = @"c:\text\second.txt";

            try
            {
                    string[] lines = File.ReadAllLines(sourcepath);
                    using (StreamWriter sw = File.AppendText(targetpath))
                    {
                        foreach (string l in lines)
                        {
                            sw.WriteLine(l.ToUpper());
                        }
                    }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }

}