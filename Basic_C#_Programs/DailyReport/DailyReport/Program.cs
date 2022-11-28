using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");              //Prints The Tech Academy
            Console.WriteLine("\nStudent Daily Report");        //Skips a line and prints Student Daily Report
            Console.WriteLine("\nWhat is your name?");          //Skips a line and asks the question
            Console.ReadLine();                                 //Program waits for response

            Console.WriteLine("What course are you in?");
            Console.ReadLine();                                 //Program waits for response

            Console.WriteLine("What page number?");
            Console.ReadLine();                                 //Program waits for response

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            Console.ReadLine();                                //Program waits for response

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();                                 //Program waits for response

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();                                 //Program waits for response

            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();                                 //Program waits for response

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();                                 //Program waits to be closed

        }
    }
}
