using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello, Jesse.\" \n Hello on a new line. \n \t Hello on a tab";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();


            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Kai");

            //Console.WriteLine(sb);
            //Console.ReadLine();


            //Console app assignment below

            string a = "My name ";
            string b = "is ";
            string c = "Kai.";           

            Console.WriteLine(a + b + c);        //Concatenating string a b and c

            string name = "Kai";                 //makes the string name uppercase
            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();                      //using string builder to alter the string, not create a new one that takes up memory
            sb.Append("This is my string Builder Paragragh, ");
            sb.Append("Written one line at a time. ");
            sb.Append("If this rewrites the string, why does it print the previously written strings?");

            Console.WriteLine(sb);


            Console.ReadLine();



        }
    }
}
