using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 10; n++)
            {
                for (int a = 0; a <= n; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
