using System;

namespace ControlFlowDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();

            if (player.Equals("AI"))
            {
                Console.WriteLine("The player is AI.");
            } else if (player.Equals("Human"))
            {
                Console.WriteLine("The player is human.");
            } else
            {
                Console.WriteLine("The player is not human nor AI.");
            }

            if (player.Equals("Robot"))
            {
                Console.WriteLine("The player is Robot!");
            }
        }
    }
}
