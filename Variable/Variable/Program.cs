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


/*
 * README
 * 
 * What is a variable?
 * A varaible is representation of information.
 * 
 * In order to access and process an information, it needs to be stored, that's where variables come in.
 * It is used for storing information.
 * 
 * In C# there are different types of variable, we need to specify variable types, 
 * one variable type will not necessarily be compatible with another variable type.
 * 
 * Variable types have reserved keywords which canot be used for any other purposes.
 * Type tells us what kind of data it will store,
 * for example, 
 * "int" will store integer data (numbers), 
 * "string" allows us to store textual information (string myName = "Ashwin"),
 * "bool" allows us to store boolean values ("true/false" OR "0/1")
 * 
 * Variable names should be meaningful, which identifies the purpose of that variable,
 * for example, storing count of the number of books, then the variable should be "countOfBooks".
 * 
 * We can convert variable types,
 * for example,
 * string number = "2";
 * int numberConverted = Convert.ToInt32(number);
 * 
 * Console.Writeline() can be used to print the variable values in console.
 * 
 */
