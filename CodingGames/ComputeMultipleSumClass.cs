using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class ComputeMultipleSumClass
    {
        public static int ComputeMultipleSum(int n)
        {
            List<int> elementsToSum = new List<int>();   
            List<int> list = new List<int>() { 3, 5, 7 };
            for (int i = 0; i < list.Count; i++)
            {
                
                var divison = n/list[i];
                if(n % list[i] == 0)
                {
                    divison --;

                }
                while(divison>=1)
                {
                    elementsToSum.Add(divison * list[i]);
                    divison--;

                }

            }
            var resultSum = elementsToSum.Sum();
            return resultSum;
        }
    }
}
