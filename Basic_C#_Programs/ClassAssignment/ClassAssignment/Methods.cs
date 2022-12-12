using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Methods
    {   //a void method
        public void Divide(int num1)
        {
            Console.WriteLine(num1 / 2);
        }
        //a method with output parameters (i think?)
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
