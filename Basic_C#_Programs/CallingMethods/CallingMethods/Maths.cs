using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Maths
    {
        public int Addition(int x)        //creating a method that adds 5 to the user input number
        {
            return 5 + x;
        }
        public int Multiply(int x)        //creating a method that multiplies 5 by the user input number
        {
            return 5 * x;
        }
        public int Divide(int x)          //creating a method that divides the user input number by 2
        {
            return x / 2;
        }
    }
}
