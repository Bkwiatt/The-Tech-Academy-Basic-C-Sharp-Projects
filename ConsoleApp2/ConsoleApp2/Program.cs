﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please input a number to be mulitplied by 50");
            int num1 = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine(num1);

            Console.WriteLine("Please input a number to get 25 added to it");
            int num2 = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine(num2);

            Console.WriteLine("Please input a number to check if it is greater than 50");
            int num3 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = num3 > 50;
            Console.WriteLine(trueOrFalse);


            Console.WriteLine("Please input a number to check for remainder when divided by 7");
            int num4 = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine(num4);

            Console.Read();
        }
    }
}