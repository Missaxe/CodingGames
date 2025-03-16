using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class ReshapStringClass
    {
        public static string Reshape(int n, string str)
        {
            // Check if the input string is null or empty
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Error: Input string is null or empty.");
                return string.Empty;  // Return an empty string if the input is invalid
            }

            // Remove spaces from the input string
            string cleanedStr = str.Replace(" ", "");

            // Check if the cleaned string is empty after removing spaces
            if (string.IsNullOrEmpty(cleanedStr))
            {
                Console.WriteLine("Error: The input string contains only spaces.");
                return string.Empty;  // Return an empty string if there's nothing left after removing spaces
            }

            // StringBuilder to build the result
            StringBuilder result = new StringBuilder();

            // Loop through the string and append segments of 'n' characters to the result
            for (int i = 0; i < cleanedStr.Length; i += n)
            {
                // Get the substring of length 'n' (or less if at the end)
                string segment = cleanedStr.Substring(i, Math.Min(n, cleanedStr.Length - i));

                // Append the segment followed by a newline
                result.AppendLine(segment);
            }

            return result.ToString();
        }
    }
}
