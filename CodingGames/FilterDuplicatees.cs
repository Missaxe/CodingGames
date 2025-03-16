using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    public class FilterDuplicatees
    {
        protected internal int  amazingWomen ; 
        public  int[] FilterDuplicates(int[] data)
        {
           
        
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < data.Length; i++)
            {
                result.Add(data[i]);
            }
            return result.ToArray();
      
        }
    }
}
