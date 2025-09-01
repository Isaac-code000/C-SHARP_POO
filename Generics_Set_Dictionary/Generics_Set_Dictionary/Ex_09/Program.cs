using System;
using System.Threading.Channels;



namespace Ex_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of file");
            string path = Console.ReadLine();


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> users = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        int number = int.Parse(fields[1]);
                        if (users.ContainsKey(name))
                        {
                            users[name] += number;
                        }
                        else
                        {
                            users[name] = number;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in users)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }

                }



            }
            catch (IOException e)
            {
                Console.WriteLine("An error as ocurred: " + e.Message);
            }

        }
    }
}