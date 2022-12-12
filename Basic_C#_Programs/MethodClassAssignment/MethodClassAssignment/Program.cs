using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math MyMethod = new Math();

            Console.WriteLine("Enter 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            MyMethod.Three(a, b);
            MyMethod.Three(num1: a, num2: b);
            Console.ReadLine();
        }
    }
}
