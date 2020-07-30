using System;

namespace ExpressionsAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal simpleExpression1 = 5 - 10;
            decimal simpleExpression2 = 4 * 10;

            decimal complexExpression = (((6 * 7) - 4) + simpleExpression1) / simpleExpression2;

            Console.WriteLine("simple expression 1 = {0}", simpleExpression1);
            Console.WriteLine("simple expression 2 = {0}", simpleExpression2);
            Console.WriteLine("complex expression = {0}", complexExpression);
        }
    }
}
