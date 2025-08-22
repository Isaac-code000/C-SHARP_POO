using System;


namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // TimeSpan armazena uma duração ou diferencas de tempo na forma de ticks
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0,30,0);
            TimeSpan t3 = new TimeSpan(1,30,0);
            TimeSpan t4 = new TimeSpan(1,0,30,0);
            TimeSpan t5 = new TimeSpan(1,10,30,0,321);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(60);
            TimeSpan t10 = TimeSpan.FromTicks(90000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);


        }
    }

}
