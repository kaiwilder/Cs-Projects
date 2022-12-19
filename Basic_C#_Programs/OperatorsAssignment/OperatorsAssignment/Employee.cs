using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int Id;

        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Id != e2.Id; 
        }
    }
}
