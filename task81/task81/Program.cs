using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task81
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите курс доллара: ");
            double rubles = double.Parse(Console.ReadLine());

            if (rubles < 0 | rubles == 0)
            {
                Console.WriteLine("курс неверен");
            }
            else
            { Console.WriteLine("Доллары" + " " + "Рубли");

                for (int dollars = 10; dollars <= 1000; dollars = dollars + 10)
                {

                    double rublesDollars = dollars * rubles;
                    Console.WriteLine($"{dollars}  {rublesDollars}");

                }
            }
        }
    }

}
