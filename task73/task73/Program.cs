using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var whiteRookPosition = Console.ReadLine();

            int whiteH, whiteV;
            DecodePosition(whiteRookPosition, out whiteH, out whiteV);

            if (whiteH < 1 || whiteH > 8 || whiteV < 1 || whiteV > 8)
            {
                Console.WriteLine("Неверная позиция белой ладьи");
                return;
            }

            Console.WriteLine("Введите позицию черного короля");
            var blackKingPosition = Console.ReadLine();

            int blackH, blackV;
            DecodePosition(blackKingPosition, out blackH, out blackV);

            if (blackH < 1 || blackH > 8 || blackV < 1 || blackV > 8)
            {
                Console.WriteLine("Неверная позиция черного короля");
                return;
            }

            if (blackKingPosition == whiteRookPosition)
            {
                Console.WriteLine("Фигуры не могут занимать одну клетку");
                return;
            }

            if (IsWhiteRookStrike(whiteRookPosition, blackKingPosition) ||
                IsBlackKingStrike(blackKingPosition, whiteRookPosition))
                Console.WriteLine("Фигуры находятся под боем друг друга");
            else
                Console.WriteLine("Фигуры не находятся под боем друг друга");
        }

        static void DecodePosition(string position, out int horizontal, out int vertical)
        {
            horizontal = int.Parse(position.Substring(1));
            vertical = (int)position[0] - 0x60;
        }

        static bool IsWhiteRookStrike(string whiteRookPosition, string position)
        {
            int whiteH, whiteV;
            DecodePosition(whiteRookPosition, out whiteH, out whiteV);

            int pH, pV;
            DecodePosition(position, out pH, out pV);

            return pH == whiteH || pV == whiteV;
        }

        static bool IsBlackKingStrike(string blackKingPosition, string position)
        {
            int blackH, blackV;
            DecodePosition(blackKingPosition, out blackH, out blackV);

            int pH, pV;
            DecodePosition(position, out pH, out pV);

            return Math.Abs(pH - blackH) <= 1 &&
                   Math.Abs(pV - blackV) <= 1;
        }

    }
}

