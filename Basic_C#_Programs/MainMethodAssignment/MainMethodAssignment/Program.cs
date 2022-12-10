using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class math
            Math MyMethod = new Math();

            //taking user input, converting type string to integer
            Console.WriteLine("Pick a number: ");
            int x = Convert.ToInt32(Console.ReadLine()); 

            //calls method One
            Console.WriteLine(MyMethod.One(x));

            //asks user for a decimal, converts type string to decimal
            Console.WriteLine("Pick a decimal number: ");
            decimal y = Convert.ToDecimal(Console.ReadLine());

            //calls the other method One, takes in a decimal, outputs an integer
            Console.WriteLine(MyMethod.One(y));

            //asks user for a number but it;s actually a string
            Console.WriteLine("Pick a new number: ");
            string w = Console.ReadLine();

            //this One takes a string, converts to an integer to do some math,
            //converts back to a string
            Console.WriteLine(MyMethod.One(w));
            Console.ReadLine();
        }
    }
}
