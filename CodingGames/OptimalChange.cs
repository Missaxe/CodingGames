using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class OptimalChange
    {

        public Change? OpltimalChange(long s)
        {
            Change ch = new Change
            {
                bill10 = s / 10
            };
            long  reste10division = s % 10; 

            if (reste10division > 0 && reste10division % 2 == 0)
            {
                ch.coin2 = s / 2 ;
 
            }
            long restMinus5 = reste10division - 5;
            if (restMinus5 >= 0)
            {
                ch.bill5 = 1;
                ch.coin2 = restMinus5 / 2 ;
         
            }
            return ch;


        }
    }

    public class Change
    {
        public long bill10;
        public long bill5 ;
        public long coin2 ;

    }
}
