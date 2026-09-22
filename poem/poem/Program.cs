using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Корней Чуковский");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закаляка");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Дали Мурочке тетрадь,\r\nСтала Мура рисовать.\r\n«Это — козочка рогатая.\r\nЭто — ёлочка мохнатая.\r\nЭто — дядя с бородой.\r\nЭто — дом с трубой».");

            Console.WriteLine("«Ну, а это что такое,\r\nНепонятное, чудное,\r\nС десятью ногами,\r\nС десятью рогами?»");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("«Это Бяка-Закаляка\r\nКусачая,\r\nЯ сама из головы её выдумала».");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("«Что ж ты бросила тетрадь,\r\nПерестала рисовать?»");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("«Я её боюсь!»");
            Console.ResetColor();
        }
    }
}
