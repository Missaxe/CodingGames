using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class PatternPixel
    {
        public class PatternSearch
        {
            public static int[] Solve(int imageWidth, int imageHeight, string[] image,
                          int patternWidth, int patternHeight, string[] pattern)
            {
                // Initialize the result as [-1, -1] (not found)
                int[] result = { -1, -1 };  // Initialisation du tableau de résultat avec [-1, -1], ce qui signifie que le motif n'a pas été trouvé.

           
                for (int i = 0; i <= imageHeight - patternHeight; i++) // On parcourt chaque ligne de l'image où le motif peut tenir
                {
                    for (int j = 0; j <= imageWidth - patternWidth; j++) // On parcourt chaque colonne de l'image où le motif peut tenir
                    {
                        bool match = true; // On suppose au départ qu'il y a une correspondance.

                
                        for (int m = 0; m < patternHeight; m++)  // Pour chaque ligne du motif
                        {
                            for (int n = 0; n < patternWidth; n++)  // Pour chaque colonne du motif
                            {
                                // Si un caractère du motif ne correspond pas avec l'image, on marque "match" comme false
                                if (image[i + m][j + n] != pattern[m][n])
                                {
                                    match = false;
                                    break; // On arrête la vérification dès qu'il y a une différence
                                }
                            }
                            if (!match) break; // Si on a trouvé une non-correspondance, on arrête immédiatement cette ligne.
                        }

                        if (match)
                        {
                            // Si on n'a pas encore trouvé de correspondance (résultat [-1, -1]), ou si la nouvelle correspondance
                            // est plus proche du coin supérieur gauche (meilleure position), on la garde.
                            if (result[0] == -1 && result[1] == -1 || i < result[1] || (i == result[1] && j < result[0]))
                            {
                                result[0] = j; // Stocke la position X (colonne) du coin supérieur gauche
                                result[1] = i; // Stocke la position Y (ligne) du coin supérieur gauche
                            }
                        }
                    }
                }

        
                return result;  // Retourne la position du motif dans l'image ou [-1, -1] si le motif n'a pas été trouvé
            }


        }
    }
}
