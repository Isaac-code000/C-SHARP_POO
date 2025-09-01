using System;


namespace Ex_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> students = new Dictionary<string, string>();

            students["isaac"]= "isaac.@gmail.com";
            students["maria"] = "maria.@gmail.com";
            students["ana"] = "ana.@gmail.com";

            Console.WriteLine(students["isaac"]);

            students["isaac"] = "isaac_new.@gmail.com";

            Console.WriteLine(students["isaac"]);


            foreach(KeyValuePair<string,string> item in students)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

        }
    }
}