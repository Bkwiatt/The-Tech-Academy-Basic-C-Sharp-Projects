using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gather Information
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt16(Console.ReadLine());


            //Check package specs
            if(width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                decimal totalCost = Convert.ToDecimal((width + height + length) * weight) / 100m;

                Console.WriteLine("Your estimated total for shipping this package is: $" + totalCost.ToString("F"));
                Console.WriteLine("Thank you");
            }

            Console.Read();

        }
    }
}
