using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person1 = new Employee();
            Person1.FirstName = "James";
            Person1.LastName = "Smith";
            Person1.Id = 47368;

            Employee Person2 = new Employee();
            Person2.FirstName = "Jane";
            Person2.LastName = "Doe";
            Person2.Id = 58923;

            Console.WriteLine(Person1 == Person2);
            Console.ReadLine();

        }
    }
}
