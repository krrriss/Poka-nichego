using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n > 1000: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 1000)
            {
                int k = 1;
                int newNumber = 0;

                while (n / k >= 10)
                {
                    k = k * 10;
                }


                while (k > 0)
                {
                    int digit = n / k;

                    n = n % k;

                    k = k / 10;

                    if (digit % 2 != 0)
                    {
                        newNumber = newNumber * 10 + digit;
                    }


                }

                Console.WriteLine("Новое число: " + newNumber);
            }
            else
            {
                Console.WriteLine("Неправильно введено n");
            }
        }
    }
}
