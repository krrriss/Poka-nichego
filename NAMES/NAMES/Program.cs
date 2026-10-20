using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = "клоун";

            var result1 = word.Remove(1, 4) + word.Substring(3, 1) + word.Substring(1, 2) + word.Remove(0, 4);
            var result2 = word.Remove(1, 4) + word.Substring(2, 1) + word.Substring(1, 1) + word.Substring(3, 2);

            Console.WriteLine($"В начале было слово \"{word}\".");
            Console.WriteLine($"Мы получили слова \"{result1}\" и \"{result2}\".");
        }
    }
}
