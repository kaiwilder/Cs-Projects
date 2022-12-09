using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Assignment part 1
            //    //Creating an array of strings
            //    string[] names = { "Kai", "Rowan", "Blaise", "Pheobe" };
            //    Console.WriteLine("Input some text please : ");
            //    string input = Console.ReadLine();

            //    //Loop iterates thru each sring and adds the input to the end of each string
            //    for (int i = 0; i < names.Length; i++)
            //    {
            //        names[i] += input;
            //    }
            //    //a second loop that prints each string one at a time
            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);
            //    }
            //    Console.ReadLine();

            //    //Assignment part 2
            //    //An infinite loop
            //    for (int i = 0; i < names.Length; i++)  //leaving out i++ creates an infinite loop
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //    Console.ReadLine();

            //    //Assignment part 3
            //    //Loop uses < operator
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    Console.ReadLine();

            //    //Loop uses <= operator
            //    for (int j = 0; j <= 7; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    Console.ReadLine();


            ////Assignment part 4
            ////creating a list with unique values
            //List<string> fruits = new List<string>();
            //fruits.Add("apple");
            //fruits.Add("orange");
            //fruits.Add("pear");
            //fruits.Add("banana");

            //Console.WriteLine("Guess a fruit: ");
            //string guess = Console.ReadLine();
            ////a loop that iterates thru the list, displays index of matching text
            //foreach (string fruit in fruits)
            //{
            //    if (guess == fruit) //if the guess is in the list
            //    {
            //        Console.WriteLine(guess + " found at index: " + fruits.IndexOf(fruit));
            //        break;
            //    }
            //}
            //if (!fruits.Contains(guess))
            //{
            //    Console.WriteLine("Fruit not found");   //if the guess in NOT in the list
            //}
            //Console.ReadLine();

            //The below code works, but is not the most efficient way to code this
            //    if (guess == "apple")
            //    {
            //        Console.WriteLine("index 0");
            //        break;        //stops loop if match is found
            //    }
            //    else if (guess == "orange")
            //    {
            //        Console.WriteLine("index 1");
            //        break;        //stops loop if match is found
            //    }
            //    else if (guess == "pear")
            //    {
            //        Console.WriteLine("index 2");
            //        break;        //stops loop if match is found
            //    }
            //    else if (guess == "banana")
            //    {
            //        Console.WriteLine("index 3");
            //        break;        //stops loop if match is found
            //    }
            //    else
            //    {      //if text doesn't match list this line prints on screen
            //        Console.WriteLine("Whoops! Your fruit is not in the list");
            //        break;
            //    }


            //Assignment part 5
            //a list of strings with 2 identical values
            List<string> cars = new List<string>() { "Volvo", "BMW", "Ford", "Mazda", "BMW" };
            Console.WriteLine("Select Volvo, BMW, Ford, or Mazda");
            string c = Console.ReadLine();

            //a loop that iterates thru the list
            for (int i = 0; i < cars.Count; i++)   //using i as the index number because IndexOf() only 
            {                                      //outputs first instance of a value
                if (cars[i] == c)
                {
                    Console.WriteLine(c + " found at index: " + i);
                }
            }
            
            if (!cars.Contains(c))
            {
                Console.WriteLine("Car not found in list");
            }
            Console.ReadLine();


            //Assignment part 6

            //List<string> letters = new List<string>() { "A", "B", "C", "D", "C"};
            //List<string> newLetters = new List<string>();

            //foreach (string letter in letters)
            //{
            //    if (newLetters.Contains(letter)) 
            //    {
            //        Console.WriteLine("This value already exists in the list");
            //    }
            //    else if (!newLetters.Contains(letter))
            //    {
            //        Console.WriteLine("This value is not already in the list");
            //        newLetters.Add(letter);
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
