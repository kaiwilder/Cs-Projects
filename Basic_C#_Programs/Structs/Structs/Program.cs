using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        //created my struct
        public struct Number
        {
            //assigned a property called Amount
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            //created the object
            Number num1;

            //assigned a value to Amount and printed it to the console
            num1.Amount = 300;
            Console.WriteLine(num1.Amount);
            Console.ReadLine();
        }
    }
}
