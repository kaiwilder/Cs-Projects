using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate: ");
            int rate1 = Convert.ToInt32(Console.ReadLine());                       //takes input for hourly rate and converts to an integer

            Console.WriteLine("Hours worked per week: ");
            int hours1 = Convert.ToInt32(Console.ReadLine());                      //takes input for hours worked and converts to an integer

            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate: ");
            int rate2 = Convert.ToInt32(Console.ReadLine());                       //takes input for hourly rate and converts to an integer

            Console.WriteLine("Hours worked per week: ");
            int hours2 = Convert.ToInt32(Console.ReadLine());                      //takes input for hours worked and converts to an integer

            double salary1 = (rate1 * hours1) * 52;
            Console.WriteLine("Annual Salary of Person1: \n" + salary1);           //prints total salary for person 1

            double salary2 = (rate2 * hours2) * 52;
            Console.WriteLine("Annual Salary of Person2: \n" + salary2);           //prints total salary for person 2

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = salary1 > salary2;                                      //if salary1 is higher than salary2, prints true 
            Console.WriteLine(compare);                                            //if salary2 is higher than salary1, prints false
            Console.ReadLine();
        }
    }
}
