﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool helpCheck = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positives = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This would be the end of the program.");

            Console.Read();
        }
    }
}