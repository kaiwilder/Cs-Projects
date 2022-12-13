using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods MyMethod = new Methods();

            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            MyMethod.Divide(num1);

            Console.WriteLine("Enter another number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyMethod.Divide(a, out int num2));

            Statics.DisplayStatement();
            Console.ReadLine();
        }
    }
}
