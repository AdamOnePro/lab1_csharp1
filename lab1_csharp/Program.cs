using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
             int convertnumber = Convert.ToInt32(Math.Pow(number, 2));
            Console.WriteLine("Answer:");
            Console.WriteLine(convertnumber);



        }
    }
}
