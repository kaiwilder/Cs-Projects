using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;     

namespace ConstructorAssignment
{
    public class Constructor
    {
        public string name { get; set; }
        public int num { get; set; }

        public Constructor() : this("Tim", 10)
        {
        }
        public Constructor(string name, int num)
        {
            this.name = name;
            this.num = num;
        }
    }
}                               
