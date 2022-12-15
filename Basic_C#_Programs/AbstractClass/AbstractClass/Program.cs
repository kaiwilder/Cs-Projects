using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee EName = new Employee();

            EName.firstName = "Sample";
            EName.lastName = "Student";

            EName.SayName();

            IQuitTable quitter = new Employee();
            quitter.Quit();

            Console.ReadLine();
        }
    }
}
