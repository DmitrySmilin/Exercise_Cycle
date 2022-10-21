using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("width");
            int width = int.Parse(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < width + i; j++)
                {
                    Console.Write("#");
                }
                for (int j = 0; j <= width - i; j++)
                {
                    Console.Write("*");
                    //Console.Write("{*}", j);
                    //if (j % 2 != 0) { Console.Write("{*}" , j  ); }

                }
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}

