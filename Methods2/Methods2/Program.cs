using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate();

            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate() => F(2, 3, 5) + F(5, 7, 12) + F(11, 13, 24);

        static double F(double x, double y, double z) => (Math.Sin(x) + Math.Sin(y)) / z;

    }
}
