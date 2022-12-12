using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Optionals MyMethod = new Optionals();

            Console.WriteLine("Enter up to 2 numbers, the second is optional. They will be multiplied together.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyMethod.Two(a, b));
            Console.ReadLine();
        }
    }
}
