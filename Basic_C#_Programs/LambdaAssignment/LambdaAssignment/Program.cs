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
                if (person.firstName == "Joe")
                    newEmployeeList.Add(person);
            }
            List<Employee> LambdaExpression = employeeList.FindAll(x => x.firstName == "Joe").ToList();
            foreach (Employee person in LambdaExpression)
            {
                    Console.WriteLine(person.firstName);
            }

            List<Employee> LastList = employeeList.FindAll(x => x.ID > 5).ToList();
            foreach (Employee person in LastList)
            {
                Console.WriteLine(person.ID);
            }
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
