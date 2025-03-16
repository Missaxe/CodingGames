using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class IsOnEvenPositionClass
    {
        public static bool IsOnEvenPosition(List<int> numbers, int value )
        {
            if (numbers.Count == 0) return false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if ( numbers[i] == value ) return true;
            }
            return false; 

        }
    }
}
