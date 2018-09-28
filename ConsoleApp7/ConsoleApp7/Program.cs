using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop example
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine(x);
                x++;
            }



            Console.WriteLine("\n\n\nPick two numbers to be added together between 1 and 10");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 + num2;
            //Lucky number 7 guess
            bool correctAdd = false;

            do
            {

                switch (num3)
                {
                    case 2:
                        Console.WriteLine("Bad Choice, 2 is not right!");
                        Console.WriteLine("Guess 2 more numbers?");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        num3 = num1 + num2;

                        break;

                    case 7:
                        Console.WriteLine("You guessed lucky number 7! You are right!!");
                        correctAdd = true;
                        break;

                    case 4:
                        Console.WriteLine("Bad Choice, 4 is not right!");
                        Console.WriteLine("Guess 2 more numbers?");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        num3 = num1 + num2;
                        break;

                    default:
                        Console.WriteLine("Bad Choice! Try adding again!");
                        Console.WriteLine("Guess 2 more numbers?");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());
                        num3 = num1 + num2;
                        break;
                }
            }
            while (!correctAdd);
            Console.Read();
        }
    }
}