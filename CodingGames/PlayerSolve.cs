using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class PlayerSolve
    {
        public static string Standard = "STANDARD";
        public static string Special = "SPECIAL";
        public static string Rejected = "REJECTED";
        public static string NotHandled = "NOT HANDLED";
        public static string Solve(int width, int height, int length, int mass)
        {
            if (!IsHeavy(mass) && !IsBulky(width, height, length))
                return Standard;
            if (IsHeavy(mass) || IsBulky(width, height, length))
             return Special;
            if (IsHeavy(mass) && IsBulky(width, height, length))
                return Rejected;
            return NotHandled;
        }
        public static bool IsBulky(int width, int height, int length)
        {
            int bulkyThreshold = 1000000;
            int volume = width * height * length;
            return ((volume >= bulkyThreshold)
                     || width >= 150
                     || height >= 150
                     || length >= 150);
        }

        public static bool IsHeavy(int mass)
        {
            return mass >= 20;

        }
    }
}
