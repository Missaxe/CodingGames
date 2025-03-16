using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    static class ClozestTo0
    {
        public static int ClozestToZero(int[] ints)
        {
            List<int> list = new List<int>(ints);
            if(!list.Contains(0)) list.Add(0);
            list.Sort();
            int indexAero = list.IndexOf(0);
            int elementBefore = list[indexAero - 1];
            int elementAfter = list[indexAero + 1 ];
            if(Math.Abs(elementBefore - 0) < Math.Abs(elementAfter - 0))
            {
                return elementBefore ;

            }
            return elementAfter ;
        }
    }
}
