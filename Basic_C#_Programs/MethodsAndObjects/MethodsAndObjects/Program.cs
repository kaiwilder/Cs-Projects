using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Employee object called Name
            Employee Name = new Employee();
            //initializing Employee Object
            Name.FirstName = "Sample";
            Name.LastName = "Student";
            //using the superclass method SayName()
            Name.SayName();
            Console.ReadLine();
        }
    }
}
