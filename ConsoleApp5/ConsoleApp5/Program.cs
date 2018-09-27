using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer 'true' or 'false'");
            bool duiCheck = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt16(Console.ReadLine());


            //Check if qualified
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && duiCheck == false && tickets <= 3);

            Console.Read();
        }
    }
}
