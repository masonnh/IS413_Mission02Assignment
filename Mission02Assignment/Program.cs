using System;

namespace Mission02Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of a random number generator
            Random r = new Random();

            // array that holds rolls for 2 die
            int[] rollTotals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // welcome and prompt the user for number of rolls to throw
            Console.WriteLine("Welcome to the dice throwing simulator!");
            // go to a new line
            Console.WriteLine("");

            Console.Write("How many dice rolls would you like to simulate? ");

            // grab the number from the user
            string rollCountStr = Console.ReadLine();
            int rollCount;
            int.TryParse(rollCountStr, out rollCount);

            // for loop to roll each die according to the counter
            for (int i = 0; i < rollCount; i++)
            {
                // generate 2 rolls of a random value 1 through 6 and add them together to get the roll total
                int roll1 = r.Next(6) + 1;
                int roll2 = r.Next(6) + 1;
                int rollTotal = roll1 + roll2;

                // add 1 to the rowTotals array at the correct index. rollTotals of 2 are saved at index 1
                rollTotals[rollTotal - 2]++;
            }

            // go to a new line
            Console.WriteLine("");
            // give the user some messages
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCount + ".");
            // go to a new line
            Console.WriteLine("");

            // display results
            for (int i=0; i<11; i++)
            {
                // calculate the percentage of totalRolls for each rollTotal in rowTotals array
                int percentage = 100 * rollTotals[i] / rollCount;

                // start the display
                Console.Write(i + 2 + ": ");

                // for each percentage point, add an *
                for (int j=0; j<percentage; j++)
                {
                    Console.Write("*");
                }
                // go to a new line
                Console.WriteLine("");
            }

            // go to a new line
            Console.WriteLine("");
            // end game
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
