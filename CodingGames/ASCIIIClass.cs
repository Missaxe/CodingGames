using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class ASCIIIClass
    {
        public static string PrintChar(char c)
        {
            int.TryParse("3", out int tt);
            // Exemple de representation ASCII pour "A" et "B"
            if (c == 'A')
                return " A  \nA A \nAAA \nA A \nA A ";
            if (c == 'B')
                return "BBB \nB  B\nBBB \nB  B\nBBB ";
            // Ajoutez des représentations similaires pour les autres lettres.

            return string.Empty;
        }

        public static char ScanChar(string s)
        {
            // Vérifier la représentation pour chaque caractère entre 'A' et 'Z'
            for (char c = 'A'; c <= 'Z'; c++)
            {
                // Si la représentation graphique correspond, retourner le caractère
                if (PrintChar(c) == s)
                {
                    return c;
                }
            }

            // Si aucun caractère ne correspond, retourner '?'
            return '?';
        }
    }
}
