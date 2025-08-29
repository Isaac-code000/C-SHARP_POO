using System;
using Ex_04.Entities;

namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComboDevice cd = new ComboDevice("1234");
            cd.Scanner();
            cd.ProcessDoc("abcd");
            cd.Print("Test print");

        }
    }
}
