using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Математика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X координату первой точки");
            double AX1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Y координату первой точки");
            double AY1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите X2 координату второй точки");
            double BX2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Y2 координату второй точки");
            double BY2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите X3 координату третьей точки");
            double CX3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Y3 координату третьей точки");
            double CY3 = double.Parse(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow((BX2 - AX1), 2) + Math.Pow((BY2 - AY1), 2));

            double AC = Math.Sqrt(Math.Pow((CX3 - AX1), 2) + Math.Pow((CY3 - AY1), 2));

            double BC = Math.Sqrt(Math.Pow((CX3 - BX2), 2) + Math.Pow((CY3 - BY2), 2));

            double P = AB + AC + BC;

            double p = P / 2.0;

            double S = Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));

            Console.WriteLine("Периметр треугольника " + Math.Round(P,3));
            Console.WriteLine("Площадь треугольника " + Math.Round(S,3));

        }
    }
}
