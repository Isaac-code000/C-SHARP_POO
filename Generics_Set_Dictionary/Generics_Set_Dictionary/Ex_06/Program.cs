using System;
using System.Collections.Generic;
using Ex_06.Entities;
using System.IO;
namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Log> logs = new HashSet<Log>();
            String path = @"c:\text\log.txt";


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(' ');
                        string name = fields[0];
                        DateTime moment = DateTime.Parse(fields[1]);
                        Log log = new Log(name, moment);
                        logs.Add(log);
                    }
                }
                Console.WriteLine("Total users: " + logs.Count);

            }
            catch (IOException e)
            {
                Console.WriteLine("An error as ocurred: " + e.Message);
            }
        }
    }
}