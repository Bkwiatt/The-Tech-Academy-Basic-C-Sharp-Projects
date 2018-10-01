using System;
using System.Collections.Generic;

namespace LoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating array and adding a string from a variable into the array and printing the array
            Console.WriteLine("Please enter a name to be added to a list of names");
            string name1 = Console.ReadLine();
            string[] randomArray = { "jimmy", "jeff", "kevin", "austin", "bobby", name1 };

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine(randomArray[i]);
            }





            //----------------INFINITE LOOP EXAMPLE------------------
            //Console.WriteLine("Please enter to start INFINITE loop");
            //Console.Read();

            //for (int i = 0; i < 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //----------------INFINITE LOOP EXAMPLE------------------







            //----------------Fixed LOOP EXAMPLE------------------
            //-----------------With <= Operator-------------------
            Console.WriteLine("\n\nPlease enter to start <= loop");
            Console.ReadLine();

            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
            //----------------------------------------------------



            //-----------------With < Operator-------------------
            Console.WriteLine("\n\nPlease enter to start < loop");
            Console.ReadLine();

            for (int i = 0; i < 100; i = i + 10)
            {
                Console.WriteLine(i);
            }
            //----------------------------------------------------



            //-----------------List Loops and Search-------------------
            Console.WriteLine("\n\nPress enter to display fruit list");
            Console.ReadLine();
            List<string> fruitList = new List<string>();
            fruitList.Add("banana");
            fruitList.Add("apple");
            fruitList.Add("strawberry");
            fruitList.Add("grapes");
            fruitList.Add("kiwi");
            fruitList.Add("orange");

            foreach (string fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Select an item in the list: ");
            string fruitSelected = Console.ReadLine();

            //Creating the list search functionality 
            if (fruitList.Contains(fruitSelected))
            {
                foreach (string fruits in fruitList)
                {
                    if (fruits == fruitSelected)
                    {
                        Console.WriteLine("\nIndex in list: " + fruitList.IndexOf(fruits));
                        break;
                    }
                }
            }
            else { Console.WriteLine("\nThat is not an option!"); }
            //-----------------END List Loops and Search-------------------





            //-----------------List with duplication-------------------
            Console.WriteLine("\n\nPress enter to display team list with duplications");
            Console.ReadLine();
            List<string> teamList = new List<string>();
            teamList.Add("cubs");
            teamList.Add("red sox");
            teamList.Add("yankees");
            teamList.Add("cubs");
            teamList.Add("yankees");
            teamList.Add("yankees");

            foreach (string teams in teamList)
            {
                Console.WriteLine(teams);
            }

            Console.WriteLine("Select an item in the list: ");
            string teamSelected = Console.ReadLine();
            List<int> indexList = new List<int>();


            if (teamList.Contains(teamSelected))
            {
                //Couldn't use foreach loop here - for whatever reason, .indexOf would return only the first index found in the loop
                for (int i = 0; i < teamList.Count; i++)
                    if (teamList[i] == teamSelected)
                        Console.WriteLine(i);
            }
            else { Console.WriteLine("That is not an option!"); }
            //-----------------END List with duplication-------------------


            //-----------------List with duplication - foreach-------------------
            Console.WriteLine("\n\nPress enter to display team list with duplications");
            Console.ReadLine();

            foreach (string teams in teamList)
            {
                Console.WriteLine(teams);
            }

            Console.WriteLine("Press enter to evaluate");
            Console.ReadLine();

            List<string> teamVals = new List<string>();
            foreach (string teams in teamList)
            {
                if (teamVals.Contains(teams))
                {
                    Console.WriteLine(teams + " - Already appeared in list");
                }
                else { Console.WriteLine(teams + "- Has not yet appeared in list"); }
                teamVals.Add(teams);
            }
            //-----------------List with duplication - foreach-------------------

            Console.Read();

        }
    }
}

