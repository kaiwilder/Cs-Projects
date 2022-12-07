using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());                                 //Accepts user input for weight, converts to integer and saves value to be used later
            if (weight > 50)                                                                  //defines a condition, ends the program if the value is over 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else                                                                              //if the value is 50 or less, program moves to the next condition
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());                              //Accepts user input for width, converts to integer and saves value to be used later

                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                int total = width + height + length;
                if (total > 50)
                {
                    Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    int quote = ((height * width * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is : $" + total + ".00 \nThank you!");
                }

                Console.ReadLine();

                //if (width > 50)                                                               //defines a condition, ends the program if the value is over 50
                //{
                //    Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day.");
                //}
                //else                                                                          //if the value is 50 or less, program moves to the next condition
                //{
                //    Console.WriteLine("Please enter the package height: ");
                //    int height = Convert.ToInt32(Console.ReadLine());                         //Accepts user input for height, converts to integer and saves value to be used later
                //    if (height > 50)                                                          //defines a condition, ends the program if the value is over 50
                //    {
                //        Console.WriteLine("Package too tall to be shipped via Package Express. Have a good day.");
                //    }
                //    else                                                                      //if the value is 50 or less, program moves to the next condition
                //    {
                //        Console.WriteLine("Please enter the package length: ");
                //        int length = Convert.ToInt32(Console.ReadLine());                     //Accepts user input for length, converts to integer and saves value to be used later
                //        if (length > 50)                                                      //defines a condition, ends the program if the value is over 50
                //        {
                //            Console.WriteLine("Package too long to be shipped via Package Express. Have a good day.");
                //        }
                //        else                                                                  //since all conditions to move on have been accepted, the total is calculated
                //        {
                //            int total = ((height * width * length) * weight) / 100;
                //            Console.WriteLine("Your estimated total for shipping this package is : $" + total + ".00 \nThank you!");
                //        }                                                                     //prints total along with above statement
            }
        }
    }
}
