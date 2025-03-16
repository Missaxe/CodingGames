using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class TranslateClass
    {
        //public static string Translate(string text)
        //{
        //    List<string> chars = ["a", "e", "i", "o", "u"];
        //    char valueA = 'a';
        //    char valueB = 'v';
        //    List<char> textChar = text.ToCharArray().ToList();
        //    List<char> result = text.ToCharArray().ToList();
        //    StringBuilder builderRes = new StringBuilder(text);
        //    for (int i = 1; i < textChar.Count - 1; i++)
        //    {
        //        var xx = chars.Contains(textChar[i - 1].ToString());
        //        var yy = chars.Contains(textChar[i].ToString());
        //        if (!chars.Contains(textChar[i-1].ToString()) &&  chars.Contains(textChar[i].ToString()))
        //        {
        //            int index = result.IndexOf(textChar[i]);
        //            result.Insert(index, valueA);
        //            result.Insert(index + 1 , valueB);


        //        }

        //    }
        //    return String.Join("",result);

        //}

        public static string Translate(string text)
        {
            // List of vowels
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            // Convert input text to a list of characters
            List<char> textChar = text.ToCharArray().ToList();

            // StringBuilder to build the result string
            StringBuilder result = new StringBuilder();

            // Loop through each character in the text
            for (int i = 0; i < textChar.Count; i++)
            {
                // Check if the current character is a vowel and the previous character is not a vowel
                if (i > 0 && vowels.Contains(textChar[i]) && !vowels.Contains(textChar[i - 1]))
                {
                    // Add "av" before the vowel
                    result.Append("av");
                }

                // Append the current character to the result
                result.Append(textChar[i]);
            }

            // Return the final translated string
            return result.ToString();
        }


    }
}
