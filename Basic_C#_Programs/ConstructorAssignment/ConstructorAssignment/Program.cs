using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filler = "this is my constant variable.";

            var sentence = "This is my var variable";

            Console.WriteLine("{0} and {1}", sentence, filler);

            Constructor obj = new Constructor();
            Console.WriteLine(obj.name);
            Console.ReadLine();
        }
    }
}
