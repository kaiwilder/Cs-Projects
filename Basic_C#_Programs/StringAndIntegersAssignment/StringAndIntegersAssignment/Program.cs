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
                List<int> Numbers = new List<int>() { 5, 10, 15, 20, 25 };   //instantiated list
                Console.WriteLine("Pick a number to divide by");
                int divisor = Convert.ToInt32(Console.ReadLine());           //saves user input

                foreach (int number in Numbers)
                {
                    int quotient = number / divisor;                         //divides each number byt the user input
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException)                                    
            {
                Console.WriteLine("Please do not divide by zero");           //if 0 is input, prints  this line
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number");            //if not a number is input, prints this line
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                               //if any other exception occurs, prints the systems error message 
            }
            finally
            {
                Console.WriteLine("Program Complete");                        //after the program has run entirely prints this line
                Console.ReadLine();
            }
        }
    }
}
