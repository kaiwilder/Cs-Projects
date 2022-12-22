using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogToTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime numHoursLater = currentTime.AddHours(num);
            Console.WriteLine(numHoursLater);

            //using (StreamWriter file = new StreamWriter(@"C:\Users\kaiwi\OneDrive\Desktop\log.txt", true))
            //{
            //    file.WriteLine(num);
            //}
            Console.ReadLine();
        }
    }
}
