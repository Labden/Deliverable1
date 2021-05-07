using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue;
            decimal fidgetSpinners = 3.5m;
            decimal memes = 5.0m;

            do
            {
                Console.WriteLine("Would you like to get the measurement conversion for Milhip in inches or feet?");

                Console.WriteLine("(1)Inches");
                Console.WriteLine("(2)Feet");
                int measurementType = Int32.Parse(Console.ReadLine());

                if (measurementType == 1)
                {
                    Console.WriteLine("Let's convert inches to fidget spinners! Enter an amount of inches:");
                    decimal userInches = Decimal.Parse(Console.ReadLine());

                    decimal fidgetSpinnersConversion = userInches * fidgetSpinners;

                    Console.WriteLine($"{fidgetSpinnersConversion} fidget spinners");
                }
                else if (measurementType == 2)
                {
                    Console.WriteLine("Let's convert feet to memes! Enter an amount of feet:");
                    decimal userFeet = Decimal.Parse(Console.ReadLine());

                    decimal memesConversion = userFeet * memes;

                    Console.WriteLine($"{memesConversion} memes");
                }

                Console.WriteLine("Do you want to continue?");
                userWantsToContinue = Console.ReadLine().ToUpper();

            } while (userWantsToContinue == "Y");
        }
    }
}
