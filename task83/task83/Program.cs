using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace task83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            double a = double.Parse(Console.ReadLine());


            if (a < 2 & a > 1)
            {
                int number = 1;
                double result = 1.0 + 1.0 / number;

                while (result >= a)
                {
                    number = number + 1;

                    result = 1.0 + 1.0 / number;
                }
                Console.WriteLine("1 + 1/" + number);
            }
            else
            {
                Console.WriteLine("Число введено неверно");
            }
                
            

        }
    }
}
