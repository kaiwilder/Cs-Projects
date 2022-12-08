using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int>() { 5, 10, 15, 20, 25 };
                Console.WriteLine("Pick a number to divide by");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int number in Numbers)
                {
                    int quotient = number / divisor;
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number");
            }
            finally
            {
                Console.WriteLine("Continuing with calculations..");
                Console.ReadLine();
            }
        }
    }
}
