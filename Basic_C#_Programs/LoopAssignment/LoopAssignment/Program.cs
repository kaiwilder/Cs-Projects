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
            {                              //The code within these {} will be executed at least once
                Console.WriteLine(i);
                i++;                       //it then gets the the while statement and learns the restrictions of the loop
            }
            while (i < 6);                 //it will still stop once i = 6, and won't print 6 to the console

            Console.ReadLine();
        }
    }
}
