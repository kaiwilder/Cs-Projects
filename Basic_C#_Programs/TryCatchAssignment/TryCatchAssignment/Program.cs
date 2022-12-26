using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                int year = 2022 - age;
                if (age <= 0)
                {
                    throw new AgeException();
                }
                Console.WriteLine("You were born in {0}", year);
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("Age cannot be zero or less, babies can't type.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please use whole numbers only");
                Console.ReadLine();
            }
            
        }
    }
}
