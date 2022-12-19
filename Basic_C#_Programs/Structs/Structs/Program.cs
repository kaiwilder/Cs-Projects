using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        public struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number num1;

            num1.Amount = 300;
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
