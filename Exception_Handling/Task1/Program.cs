
using System;

namespace Task1
{
    internal static class Program
    {
        static char ReturnFirstCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException(nameof(str));

            char firstChar = str[0];
            return firstChar;
        }
        private static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the string");
            input = Console.ReadLine();
            Console.WriteLine("The first character of string is : {0} ", ReturnFirstCharacter(input));
        }
    }
}