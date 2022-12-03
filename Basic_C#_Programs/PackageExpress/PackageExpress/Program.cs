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
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package weight: ");
                int width = Convert.ToInt32(Console.ReadLine());

                if (width > 50)
                {
                    Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    Console.WriteLine("Please enter the package weight: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    if (height > 50)
                    {
                        Console.WriteLine("Package too tall to be shipped via Package Express. Have a good day.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the package weight: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        if (length > 50)
                        {
                            Console.WriteLine("Package too long to be shipped via Package Express. Have a good day.");
                        }
                        else
                        {
                            int total = ((height * width * length) * weight) / 100;
                            Console.WriteLine("Your estimated total for shipping this package is : $" + total + ".00 \nThank you!");
                        }
                    }
                }
            }
            Console.ReadLine();



        }
    }
}
