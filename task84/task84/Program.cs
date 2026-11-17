using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {

                Console.WriteLine("Введите число k: ");
                int k = int.Parse(Console.ReadLine());

                int result = 1;

                if (k <= 8 & k >= 1)
                {
                    while (n > 0)
                    {
                        int digit = n % 10;
                        if (digit > k)
                        {
                            result = result * digit;
                        }
                        n = n / 10;

                    }
                    Console.WriteLine("Произведение цифр: " + result);
                }
                else { Console.WriteLine("Число k введено неверно"); }

            }
            else { Console.WriteLine("Число n введено неверно"); }






        }
    }
}
