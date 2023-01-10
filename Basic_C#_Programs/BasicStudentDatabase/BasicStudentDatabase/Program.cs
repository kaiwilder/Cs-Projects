using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Billy" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
