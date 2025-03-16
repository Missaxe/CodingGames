using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class SearchValueClass
    {
        public static List<int> SearchValue(List<int> numbers , int value)
        {
            int firstVal = 0 ;
            int secondVal = 0;
            int thirdVal = 0 ;
            int fourthVal = 0;
            
            int half = numbers.Count / 2;
            List<int> firstHalf = numbers.Take(half).ToList();
            List<int> secondHalf = numbers.Skip(half).Take(half).ToList();

            for (int i = 0 ; i<numbers.Count -1; i=i+2)
            {
                if (numbers[i] == value)
                {
                    firstVal = 1;
                    break;
                }

            }
            for (int j = 1; j < numbers.Count; j = j + 2)
            {
                if (numbers[j].ToString().Contains(value.ToString()))
                {
                    secondVal = 1;
                    break;
                }

            }
            for (int k = 0; k < firstHalf.Count; k++)
            {
                if (firstHalf[k] == value)
                {
                    thirdVal = 1;
                    break;
                }

            }
            for (int l = 0; l < secondHalf.Count ; l++)
            {
                if (secondHalf[l] == value)
                {
                    fourthVal = 1;
                    break;
                }

            }
            List<int> result = [firstVal, secondVal, thirdVal, fourthVal];


            return result;

        }
    }
}
