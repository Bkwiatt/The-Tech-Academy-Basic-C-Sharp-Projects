using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating string array
            string[] stringArray = {"Hello", "Chicken", "Pizza", "Crayons"};

            Console.WriteLine("Enter an array index number between 1 and 4");
            int pickedNum = Convert.ToInt32(Console.ReadLine());
            //Subtracted 1 from the number selected so the user wont have to specify a 0
            Console.WriteLine(stringArray[pickedNum - 1]);

            Console.WriteLine("\n----------------------------------------------\n");

            //creating int array
            int[] intArray = {98,12,53,234,235,763,343,32,3,7};

            Console.WriteLine("Enter an array index number between 1 and " + intArray.Length);
            pickedNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intArray[pickedNum - 1]);

            Console.WriteLine("\n----------------------------------------------\n");


            //Creating a string list
            List<string> stringList = new List<string>();
            stringList.Add("Cubs");
            stringList.Add("Red Sox");
            stringList.Add("Yankees");
            stringList.Add("Brewers");
            stringList.Add("Braves");

            Console.WriteLine("Enter a list index number between 1 and " + stringList.Count);
            pickedNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[pickedNum - 1]);



            Console.Read();
    
        }
    }
}
