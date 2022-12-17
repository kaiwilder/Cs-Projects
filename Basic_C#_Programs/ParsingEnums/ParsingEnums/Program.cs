using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Day of the Week: ");
                string value = Console.ReadLine();
                Days day = (Days)Enum.Parse(typeof(Days), value);
                if (day == Days.Sunday)
                {
                    Console.WriteLine("You said today is Sunday");
                }
                else if (day == Days.Monday)
                {
                    Console.WriteLine("You said today is Monday");
                }
                else if (day == Days.Tuesday)
                {
                    Console.WriteLine("You said today is Tuesday");
                }
                else if (day == Days.Wednesday)
                {
                    Console.WriteLine("You said today is Wednesday");
                }
                else if (day == Days.Thursday)
                {
                    Console.WriteLine("You said today is Thursday");
                }
                else if (day == Days.Friday)
                {
                    Console.WriteLine("You said today is Friday");
                }
                else if (day == Days.Saturday)
                {
                    Console.WriteLine("You said today is Saturday");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
        }
    }
}
