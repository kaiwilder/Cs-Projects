using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ID = 1;
            emp1.firstName = "Joe";
            emp1.lastName = "Jacob";

            Employee emp2 = new Employee();
            emp2.ID = 2;
            emp2.firstName = "Joe";
            emp2.lastName = "Johnson";

            Employee emp3 = new Employee();
            emp3.ID = 3;
            emp3.firstName = "Susan";
            emp3.lastName = "Smith";

            Employee emp4 = new Employee();
            emp4.ID = 4;
            emp4.firstName = "Samantha";
            emp4.lastName = "Picket";

            Employee emp5 = new Employee();
            emp5.ID = 5;
            emp5.firstName = "Carrie";
            emp5.lastName = "Adams";

            Employee emp6 = new Employee();
            emp6.ID = 6;
            emp6.firstName = "Vanessa";
            emp6.lastName = "Cooper";

            Employee emp7 = new Employee();
            emp7.ID = 7;
            emp7.firstName = "Lucy";
            emp7.lastName = "Jack";

            Employee emp8 = new Employee();
            emp8.ID = 8;
            emp8.firstName = "Adam";
            emp8.lastName = "Smith";

            Employee emp9 = new Employee();
            emp9.ID = 9;
            emp9.firstName = "Julie";
            emp9.lastName = "Sharp";

            Employee emp10 = new Employee();
            emp10.ID = 10;
            emp10.firstName = "Harrison";
            emp10.lastName = "Kurt";

            Console.WriteLine(emp1);
            Console.ReadLine();
        }
    }
}
