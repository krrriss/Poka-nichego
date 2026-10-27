using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = InputNumber("k");
            var m = InputNumber("m");
            var n = InputNumber("n");

            Console.WriteLine("Значение логического выражения: " + isStatementTrue(k, m, n));

        }

        static int InputNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }

        static bool isStatementTrue(int k, int m, int n) =>
            (k % 11 == 0 && (m % 11 != 0) && (n % 11 != 0)) || (m % 11 == 0 && (k % 11 != 0) && (n % 11 != 0)) || (n % 11 == 0 && (m % 11 != 0) && (k % 11 != 0));
    }

}
