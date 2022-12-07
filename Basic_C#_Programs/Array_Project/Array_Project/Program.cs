using System;
using System.Collections.Generic;


namespace Array_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = { "apple", "orange", "pear", "banana" };
            Console.WriteLine("Select an index of the array (0-3)");
            int string1 = Convert.ToInt32(Console.ReadLine());

            
            if(string1 == 0)
            {
                Console.WriteLine(stringArray1[0]);
            }
            else if (string1 == 1)
            {
                Console.WriteLine(stringArray1[1]);
            }
            else if (string1 == 2)
            {
                Console.WriteLine(stringArray1[2]);
            }
            else if (string1 == 3)
            {
                Console.WriteLine(stringArray1[3]);
            }
            else
            {
                Console.WriteLine("Please pick a number between 0 and 3");
            }

            



            int[] intArray1 = { 3, 7, 15, 26, };
            Console.WriteLine("Select an index of the array (0-3)");
            int nums = Convert.ToInt32(Console.ReadLine());

            if (nums == 0)
            {
                Console.WriteLine(intArray1[0]);
            }
            if (nums == 1)
            {
                Console.WriteLine(intArray1[1]);
            }
            if (nums == 2)
            {
                Console.WriteLine(intArray1[2]);
            }
            if (nums == 3)
            {
                Console.WriteLine(intArray1[3]);
            }
            else
            {
                Console.WriteLine("Please pick a number between 0 and 3");
            }
            

            List<string> stringList = new List<string>();
            stringList.Add("apple");
            stringList.Add("orange");
            stringList.Add("pear");
            stringList.Add("banana");
            Console.WriteLine("Select an index for the list: ");
            int list1 = Convert.ToInt32(Console.ReadLine());

            if (list1 == 0)
            {
                Console.WriteLine(stringList[0]);
            }
            if (list1 == 1)
            {
                Console.WriteLine(stringList[1]);
            }
            if (list1 == 2)
            {
                Console.WriteLine(stringList[2]);
            }
            if (list1 == 3)
            {
                Console.WriteLine(stringList[3]);
            }
            else
            {
                Console.WriteLine("Please pick a number between 0 and 3");
            }
            Console.ReadLine();
        }
    }
}
