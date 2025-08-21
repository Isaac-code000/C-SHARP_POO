using System;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {

            string original = "abcde FHIJ ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("abc");   
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(5, 3); // Extracts "FHI"
            string s6 = original.Replace("abc", "XYZ");

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original" + original + "|");
            Console.WriteLine("Upper" + s1 + "|");
            Console.WriteLine("Lower" + s2 + "|");
            Console.WriteLine("Trim" + s3 + "|");
            Console.WriteLine("IndexOf bc" + n1);
            Console.WriteLine("LastIndexOf bc" + n1 + "|");
            Console.WriteLine("SubsString(3)" + s4 + "|");
            Console.WriteLine("Substring(5, 3)" + s5 + "|");
            Console.WriteLine("Replace abc with XYZ" + s6 + "|");
            Console.WriteLine("IsNullOrEmpty: " + b1 + "|");
            Console.WriteLine("IsNullOrWhiteSpace: " + b2 + "|");
        }
    }
}