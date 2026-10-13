using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную x");
            double x = double.Parse(Console.ReadLine());

            double y = Calculate(x);

            Console.WriteLine(Math.Round(y, 3));

        }

        static double Calculate(double x)


        {
            double num1 = x * x + 10;
            double num2 = Math.Sqrt(x * x + 1);

            return num1 / num2;
        }
    }
}
