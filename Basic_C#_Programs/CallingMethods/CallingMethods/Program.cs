using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Pick a number: ");
        int x = Convert.ToInt32(Console.ReadLine()); //stores the user input

        Maths MyMethod = new Maths();               //creates an object within maths class

        Console.WriteLine(MyMethod.Addition(x));    //calls the addition method
        Console.WriteLine(MyMethod.Multiply(x));    //calls the multiply method
        Console.WriteLine(MyMethod.Divide(x));      //calls the divide method
        Console.ReadLine();
        }
    }
}