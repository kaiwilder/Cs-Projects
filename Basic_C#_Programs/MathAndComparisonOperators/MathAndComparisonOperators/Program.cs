using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int num1 = 200 / 3;
            //Console.WriteLine(num1);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;

            //bool isWarm = currentTemp <= roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();



            //Below is the Console app assignment on page 185 


            //Console.WriteLine("Enter value: ");                            //takes user input, * 50, prints result
            //string userInput = Console.ReadLine();
            //double dubVar = Convert.ToDouble(userInput);                   //must convert to double to take higher inputs
            //double product = dubVar * 50;
            //Console.WriteLine(userInput + " * 50 = " + product);
            //Console.ReadLine();

            //Console.WriteLine("Enter value: ");                            //takes user input, adds 25, prints result
            //string userInput = Console.ReadLine();
            //double dubVar = Convert.ToDouble(userInput);                   //must convert to double to take higher inputs
            //double sum = dubVar + 25;
            //Console.WriteLine(userInput + " + 25 = " + sum);
            //Console.ReadLine();

            //Console.WriteLine("Enter value: ");                            //takes user input, / 12.5, prints result
            //string userInput = Console.ReadLine();
            //double dubVar = Convert.ToDouble(userInput);                   //must convert to double to take higher inputs
            //double quotient = dubVar / 12.5;
            //Console.WriteLine(userInput + " / 12.5 = " + quotient);
            //Console.ReadLine();

            //Console.WriteLine("Enter value: ");                            //takes user input, determins if >= 50, prints result
            //string userInput = Console.ReadLine();
            //double dubVar = Convert.ToDouble(userInput);                   //must convert to double to take higher inputs
            //bool trueFalse = dubVar >= 50;                                 //converts to boolean to recieve true false answer
            //Console.WriteLine(userInput + " >= 50 = " + trueFalse);
            //Console.ReadLine();

            Console.WriteLine("Enter value: ");                              //takes user input, / 7, prints remainder
            string userInput = Console.ReadLine();
            double dubVar = Convert.ToDouble(userInput);                     //must convert to double to take higher inputs
            double remainder = dubVar % 7;
            Console.WriteLine(userInput + " % 7 = " + remainder);
            Console.ReadLine();
        }
    }
}
