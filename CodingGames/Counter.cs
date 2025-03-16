using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class Counter
    {
        private static int count = 0;
        private static readonly object _lock = new object();
        public static int Increment()
        {
            lock (_lock)
            {
                count++;
                return count;

            }
    
        }
    }
}
