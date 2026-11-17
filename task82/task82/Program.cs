using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество административных единиц:");
            int n = int.Parse(Console.ReadLine());

            decimal totalArea = 0;

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Введите количество жителей в тысячах:");
                int people = int.Parse(Console.ReadLine());


                Console.WriteLine("Введите плотность населения:");
                int populationDensity = int.Parse(Console.ReadLine());

                decimal area = people / populationDensity;

                totalArea = totalArea + area;

            }
            
            Console.WriteLine("Площадь страны: " + totalArea  + "км2");

           
        }
    }
}
