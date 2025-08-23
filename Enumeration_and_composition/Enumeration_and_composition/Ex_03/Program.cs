using System;

using Ex_03.Entities;
using System.Globalization;


namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter content: ");
            string content = Console.ReadLine();
            Post post = new Post(title, content, DateTime.Now);
            Console.Write("How many comments to this post? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter comment #{0} text: ", i + 1);
                string commentText = Console.ReadLine();
                Coment comment = new Coment(commentText);
                post.AddComent(comment);
            }
            Console.WriteLine();
            Console.WriteLine(post);
        }
    }

}

