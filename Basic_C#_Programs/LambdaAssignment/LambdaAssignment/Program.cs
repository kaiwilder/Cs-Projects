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
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){ID = 1, firstName = "Joe", lastName = "Jacob"},
                new Employee(){ID = 2, firstName = "Joe", lastName = "Johnson"},
                new Employee(){ID = 3, firstName = "Susan", lastName = "Smith"},
                new Employee(){ID = 4, firstName = "Samantha", lastName = "Picket"},
                new Employee(){ID = 5, firstName = "Carrie", lastName = "Adams"},
                new Employee(){ID = 6, firstName = "Vanessa", lastName = "Crane"},
                new Employee(){ID = 7, firstName = "Lucy", lastName = "Cooper"},
                new Employee(){ID = 8, firstName = "Adam", lastName = "Smith"},
                new Employee(){ID = 9, firstName = "Julie", lastName = "Sharp"},
                new Employee(){ID = 10, firstName = "Harrison", lastName = "James"},
            };
            List <Employee> newEmployeeList = new List<Employee>();
            foreach (Employee person in employeeList) 
            {
                if (employeeList.firstName == "Joe")
                    newEmployeeList.Add(person);
            }
            List<string> LambdaExpression = employeeList.FindAll(x => Employee == "Joe");

            List<string> LastList = employeeList.FindAll(x => Employee.ID > 5);
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
