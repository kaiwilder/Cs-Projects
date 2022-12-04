using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;                   //as long as i is less than 6
            //while (i < 6)                //i will be printed in the console.
            //{                            //Once i reaches 6 the loop will not repeat
            //    Console.WriteLine(i);    //and will not be printed to the console
            //    i++;
            //}
            //Console.ReadLine();

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6);

            Console.ReadLine();
        }
    }
}
