using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class TopStocks
    {
        public static string[] GetTopStocks(string[] stocks, float[,] prices)
        {
            Dictionary<string, float> result = new Dictionary<string,float>();
     
          
                for(int j = 0; j < prices.GetLength(1); j++)
                {
                    float sumVal = prices[0, j] + prices[1,j];
                    float averageVal = sumVal / 2;
                    result.Add(stocks[j], averageVal);

                }

            
            var sortedDc = result.OrderByDescending(d => d.Value).ToDictionary();
            return sortedDc.Take(3).Select(x => x.Key).Order().ToArray();
        

        }
    }
}
