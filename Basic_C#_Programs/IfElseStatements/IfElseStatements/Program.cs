using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //using if, else if, and else 

            //string name = "Kai";

            //if (name == "Kai")
            //{
            //    Console.WriteLine("Your name is Kai");
            //}
            //else if (name == "Rowan")
            //{
            //    Console.WriteLine("Your name is Rowan");
            //}
            //else if (name == "Pheobe")
            //{
            //    Console.WriteLine("Your name is Pheobe");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not recognized");
            //}

            //string name = "Kai";
            //if (name != "Jesse")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}


            //int age = 25;
            //if (age > 20)
            //{
            //    Console.WriteLine("Here is your wine!");
            //}
            //else
            //{
            //    Console.WriteLine("No you may not have that wine.");
            //}


            //if (age <= 20)
            //{
            //    Console.WriteLine("No you may not have that wine.");
            //}
            //else
            //{
            //    Console.WriteLine("Here is your wine!");
            //}

            int num1 = 7;
            int num2 = 12;

            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
