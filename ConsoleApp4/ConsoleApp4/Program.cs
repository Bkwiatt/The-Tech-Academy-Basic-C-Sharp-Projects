using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Wage?");
            int wage1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week?");
            int weeklyHours1 = Convert.ToInt16(Console.ReadLine());

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Wage?");
            int wage2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Hours Worked Per Week?");
            int weeklyHours2 = Convert.ToInt16(Console.ReadLine());


            //Calculate Salaries
            int salary1 = wage1 * weeklyHours1;
            int salary2 = wage2 * weeklyHours2;
            Console.WriteLine("Weekly salary of Person 1:\n" + salary1);
            Console.WriteLine("Weekly salary of Person 2:\n" + salary2);


            //Who make more?
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = salary1 > salary2;
            Console.WriteLine(trueOrFalse);

            Console.Read();
        }
    }
}