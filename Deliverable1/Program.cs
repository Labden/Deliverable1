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
                Console.WriteLine("Would you like to get the measurement conversion for Milhip in inches, feet, fidget spinners, or memes?");

                Console.WriteLine("(1)Inches");
                Console.WriteLine("(2)Feet");
                Console.WriteLine("(3)Fidget Spinners");
                Console.WriteLine("(4)Memes");
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
                else if (measurementType == 3)
                {
                    Console.WriteLine("Let's convert fidget spinners to inches! Enter an amount of fidget spinners:");
                    decimal userFidgetSpinners = Decimal.Parse(Console.ReadLine());

                    decimal inchesConversion = userFidgetSpinners * 1 / 3.5m;

                    Console.WriteLine($"{inchesConversion} inches");
                }
                else if (measurementType == 4)
                {
                    Console.WriteLine("Let's convert memes to feet! Enter an amount of memes:");
                    decimal userMemes = decimal.Parse(Console.ReadLine());

                    decimal feetConversion = userMemes * .2m;

                    Console.WriteLine($"{feetConversion} feet");
                }

                Console.WriteLine("Do you want to continue?");
                userWantsToContinue = Console.ReadLine().ToUpper();
            } while (userWantsToContinue == "Y");
        }
    }
}
