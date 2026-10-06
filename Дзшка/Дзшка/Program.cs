using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дзшка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число x:");
            int x = int.Parse(Console.ReadLine());

            int hundreds = x / 100;
            int ten = (x / 10) % 10;
            int units = x % 10;

            int n = 100 * hundreds + 10 * units + ten;

            Console.WriteLine(n);



        }
    }
}
