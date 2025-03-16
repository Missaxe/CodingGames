using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class Danser
    {
        private const int ModuleBase = 6;
        private const int FallBack = -999;
        public static int GetPositionAt(int number)
        {
            int restDivision = number % ModuleBase;
            return restDivision switch
            {
                0 => 0,
                1 => 1,
                2 => -1,
                3 => -4,
                4 => -5,
                5 => -3,
                _ => FallBack

            };
        }
    }
}
