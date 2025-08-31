using System;
using System.Collections.Generic;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>
            {
                "apple",
                "banana",
                "orange",
                "grape",
                "kiwi"
            };

            SortedSet<int> a = new SortedSet<int> { 1, 2, 3, 4, 5 };
            SortedSet<int> b = new SortedSet<int>() { 5, 4, 7, 9, 10 };
            SortedSet<int> c = new SortedSet<int>(a);

            c.UnionWith(b);

            Console.WriteLine("Union a with b");
            PrintSet(c);

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.WriteLine("Intersect a with b");
            PrintSet(d);

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.WriteLine("Except a with b");
            PrintSet(e);


            Console.WriteLine(fruits.Contains("apple"));
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }

        static void PrintSet<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }

}
