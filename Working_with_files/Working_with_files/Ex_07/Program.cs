using System;
using System.IO;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\direct\produtos.csv";
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("TV,900.00,1");
                    sw.WriteLine("Mouse,50.00,2");
                    sw.WriteLine("Tablet,350.50,3");
                }

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        double price = double.Parse(parts[1], System.Globalization.CultureInfo.InvariantCulture);
                        int quantity = int.Parse(parts[2]);

                        Directory.CreateDirectory(@"c:\direct\out");

                        using (StreamWriter sw2 = File.AppendText(@"c:\direct\out\summary.csv"))
                        {
                            sw2.WriteLine(name + "," + (price * quantity).ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
                        }
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
