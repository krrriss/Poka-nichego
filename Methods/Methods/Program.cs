using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var x = GetCoordinate("Введите 1-ю координату вектора");
            var y = GetCoordinate("Введите 2-ю координату вектора");

            var vectorLength = Math.Sqrt(Square(x) + Square(y));

            Console.WriteLine("Длина вектора равна " + vectorLength);

            int sum = Square(1) + Square(5) + Square(7);
        


        }

        static double GetCoordinate(string message)
        {
            Console.WriteLine(message);
            return double .Parse(Console.ReadLine());
        }

        //static double Square(double x)
        //{  return x * x; 
        //}
        static double Square(double x) => x * x;

        static int Square(int x) => x * x;

    }
}
