using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBooks = 1;
            string myName = "Ashwin";
            bool isCompatible = true;

            string number = "2";
            int numberConverted = Convert.ToInt32(number);

            Console.WriteLine("Count of books = {0}", countOfBooks);
            Console.WriteLine("myName = {0}", myName);
            Console.WriteLine("isCompatible = {0}", isCompatible);
            Console.WriteLine("number (string) = {0}", number);
            Console.WriteLine("numberConverted (int) = {0}", numberConverted);
        }
    }
}