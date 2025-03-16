using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class DiscountSoldes
    {
        public static int CalculateTotalPrice(int[] prices, int discount)
        {
            int[] pricesSortedd = prices.OrderDescending().ToArray();
            int elementDiscount = pricesSortedd.FirstOrDefault();


            if (elementDiscount > 0)
            {
                var newprice = pricesSortedd[0] * (1 - (float)discount / 100);
                pricesSortedd[0] = Convert.ToInt32(Math.Floor(newprice));
                                 
            }

            int resconverted = pricesSortedd.Sum();
            return resconverted;

        }
    }
}
