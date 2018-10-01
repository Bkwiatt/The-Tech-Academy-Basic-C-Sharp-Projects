using System;
using System.Collections.Generic;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = new List<int>();

            nums.Add(22);
            nums.Add(31);
            nums.Add(42);
            nums.Add(10);
            nums.Add(8);

            try
            {
                Console.WriteLine("Please enter a number to divide into all numbers in a list: ");
                int dividend = Convert.ToInt32(Console.ReadLine());

                foreach (int x in nums)
                {
                    Console.WriteLine(x + " divided by" + dividend + " equals " + (x / dividend));
                }

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
            }

            Console.WriteLine("Main Program will now continue");
            


            Console.Read();



        }
    }
}
