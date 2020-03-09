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
            int number = 0;
            int k = 9;
            for(int n = 1; n<=5;n++)
            {
                number = (n * k) % 24 + 1;
                Console.WriteLine (number);
            }

        }
    }
}
