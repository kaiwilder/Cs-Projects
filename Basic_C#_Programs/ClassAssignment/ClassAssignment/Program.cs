using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }
        static void Main(string[] args)
        {
            int g;
            Sum (out g);
            Console.WriteLine("The sum of" +
                " the value is: {0}", g);
            Console.ReadLine();
        }
    }
}
