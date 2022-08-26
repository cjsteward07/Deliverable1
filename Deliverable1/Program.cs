using System;

namespace deliverable1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int loop = 1;

            const int SLICES_IN_SANDWHICH = 2;
            const int PB_IN_SANDWHICH = 2;
            const int JELLY_IN_SANDWHICH = 4;

            const int SLICES_IN_LOAF = 28;
            const int PB_IN_JAR = 32;
            const int JELLY_IN_JAR = 48;

            while (loop >= 1)
            {
                Console.WriteLine("How many people are we making PB and J sandwiches for? ");
                int peopleCount = int.Parse(Console.ReadLine());

                int slicesOfBread = SLICES_IN_SANDWHICH * peopleCount;
                int tbpsOfPeanutButter = PB_IN_SANDWHICH * peopleCount;
                int tspOfJelly = JELLY_IN_SANDWHICH * peopleCount;

                double loavesNeeded = Math.Ceiling((double)slicesOfBread/SLICES_IN_LOAF);
                double pbNeeded = Math.Ceiling((double)tbpsOfPeanutButter/PB_IN_JAR);
                double jellyNeeded = Math.Ceiling((double)tspOfJelly/JELLY_IN_JAR);

                Console.Clear();

                Console.WriteLine($"For {peopleCount} people you'll need: \n");
                Console.WriteLine($"{slicesOfBread} slices of bread");
                Console.WriteLine($"{tbpsOfPeanutButter} tablespoons of peanut butter");
                Console.WriteLine($"{tspOfJelly} teaspoons of jelly \n");

                Console.WriteLine("Which is: \n");
                Console.WriteLine($"{loavesNeeded} loaves of bread");
                Console.WriteLine($"{pbNeeded} jars of peanut butter");
                Console.WriteLine($"{jellyNeeded} jars of jelly \n \n");

                Console.WriteLine("Would you like to restart? Enter 'yes' or 'y' to continue, or enter any other key to exit:");
                string restartInput = Console.ReadLine();
                if (restartInput == "yes" || restartInput == "y")
                {
                    Console.Clear();
                }
                else
                {
                    loop = 0;
                    Console.Clear();
                    Console.WriteLine("Goodbye! \n");
                }
            }
        }
    }
}