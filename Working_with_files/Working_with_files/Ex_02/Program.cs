using System;
using System.IO;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\text\one.txt";
          
            StreamReader sr = null;

            try
            {
                
                sr = File.OpenText(path);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:" + e.Message);
            }
            finally { }
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
