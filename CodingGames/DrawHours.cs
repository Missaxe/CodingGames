using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class DrawHours
    {
        public static string DrawHourglass(string startingLine)
        {
            int n = startingLine.Length; // The width of the hourglass
            char ch = startingLine[0];  // The character used to draw the hourglass
            StringBuilder sb = new StringBuilder();
            // Create the upper part of the hourglass
            for (int i = 0; i < n; i += 2)
            {
                // Add leading spaces
                sb.Append(' ', i / 2);
                // Add the characters for the current line
                sb.Append(new string(ch, n - i));
                sb.AppendLine();
            }

            // Create the bottom part of the hourglass
            for (int i = n - 4; i >= 0; i -= 2)
            {
                // Add leading spaces
                sb.Append(' ', i / 2);
                // Add the characters for the current line
                sb.Append(new string(ch, n - i));
                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();  // Remove the extra newline at the end
        }
    }
}
