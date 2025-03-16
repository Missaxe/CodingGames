using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class DuoDigit
    {
        public static string IsDuoDigit(int number)
        {
            try
            {
                HashSet<int> numbers = new HashSet<int>();
                char[] charsNumbers = number.ToString().ToCharArray();
                for (int i = 0; i < charsNumbers.Length; i++)
                {
                    var stringVal = charsNumbers[i].ToString();
                    _ = int.TryParse(stringVal, out int numInteger);
                    if (stringVal != "0" && numInteger == 0)
                    {
                        continue;
                    }
                    numbers.Add(numInteger);
                }
                if (numbers.Count <= 2) return "y";
                return "n";

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            finally
            {
                Console.WriteLine();

            }


          
        }
    }
}
