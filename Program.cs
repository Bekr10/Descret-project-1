using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first numper");
            int numper1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second numper");
            int numper2 = int.Parse(Console.ReadLine());


            Console.WriteLine();

            for (int i = numper1; i <= numper2; i++)
            {
                byte numpers = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numpers++;
                    }

                }
                if (numpers == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

