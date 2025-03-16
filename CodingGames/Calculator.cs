using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class Calculator
    {
        public static string Sum(params string[] numbers)
        {
            decimal total = 0;
            foreach (var number in numbers)
            {
                total = total + decimal.Parse(number);
            }
            return total.ToString();

        }
    }
}
