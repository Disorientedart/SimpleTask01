using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = string.Empty;

            Console.WriteLine(args[0]);
            foreach(char letter in args[0])
            {
                reverse = string.Concat(letter, reverse);
            }

            Console.WriteLine(reverse);
            Console.Read();
        }
    }
}
