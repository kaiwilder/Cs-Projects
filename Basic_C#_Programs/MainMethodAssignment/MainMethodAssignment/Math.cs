using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        //This method takes in an integer and adds 5, returns the total
        public int One(int x)  
        {
            return 5 + x;
        }
        //takes in a decimal, converts total to an integer
        public decimal One(decimal y)
        {
            int z = Decimal.ToInt32(y);
            return 8 + z;
        }
        //supposed to take in a string, convert it to an integer to do math to it
        public string One(string w)
        {
            int a = Convert.ToInt32(w);
            string b = Convert.ToString(2 * a);
            return b;
        }
    }
}
