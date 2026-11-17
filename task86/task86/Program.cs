using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                int sum = 0;

                for (int num = a; num <= b; num++)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            sum = sum + i;
                        }
                    }

                }

                Console.WriteLine("Сумма всех делителей: " + sum);
            }
            else { Console.WriteLine("Введите a < b"); }


        }
    }
}
