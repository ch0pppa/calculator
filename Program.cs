using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson13_hw1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("Your integer is? ");
            number = int.Parse(Console.ReadLine());


            if (number % 2 != 0)

            {
                Console.WriteLine("Your integer is an odd");
                return;
            }

            { 
                Console.WriteLine("Your integer is an even");
            }
        }
            
    }
}
