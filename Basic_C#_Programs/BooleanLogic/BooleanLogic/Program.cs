using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && true && true || false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);             //either value can equal true buut not both
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);



            //using if, else if, and else 

            //string name = "Kai";

            //if (name == "Kai")
            //{
            //    Console.WriteLine("Your name is Kai");
            //}
            //else if (name == "Rowan")
            //{
            //    Console.WriteLine("Your name is Rowan");
            //}
            //else if (name == "Pheobe")
            //{
            //    Console.WriteLine("Your name is Pheobe");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not recognized");
            //}

            //string name = "Kai";
            //if (name != "Jesse")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}
            

            int age = 25;
            if (age > 20)
            {
                Console.WriteLine("Here is your wine!"); 
            }
            else
            {
                Console.WriteLine("No you may not have that wine."); 
            }

            
            if (age <= 20)
            {
                Console.WriteLine("No you may not have that wine.");
            }
            else
            {
                Console.WriteLine("Here is your wine!");
            }

            Console.ReadLine();
        }
    }
}
