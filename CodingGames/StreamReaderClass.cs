using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class StreamReaderClass
    {
        public void Print(TextReader reader)
        {
            if (reader == null)
            {
                Console.WriteLine("Error: The reader is null.");
                return;
            }

            try
            {
                // Using 'using' to ensure proper disposal (automatic closing)
                using (reader)
                {
                    int code = reader.Read();
                    while (code != -1)
                    {
                        Console.Write((char)code);  // Print the character
                        code = reader.Read();  // Read the next character
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading from stream: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
