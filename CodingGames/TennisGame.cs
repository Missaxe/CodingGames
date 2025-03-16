using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class TennisGame
    {
      
        public static string ComputeGameState(string namep1, string namep2 , string[] wins)
        {
               int pointsP1 = 0;
               int pointsP2 = 0;
            for (int i = 0; i < wins.Length; i++)
            {
                if (wins[i] == namep1)
                {
                    pointsP1 = pointsP1 + 15    ;
                }
                if (wins[i] == namep2)
                {
                    pointsP2 = pointsP2 + 15;
                }

            }
            if(pointsP1 == 0 && pointsP2 == 0)
                return $"{namep1} 0 - {namep2} 0";
            if (pointsP1 == 15 && pointsP2 == 15)
                return "15a";
            if (pointsP1 == 30 && pointsP2 == 30)
                return "30a";
            if (pointsP1 <= 30 && pointsP2 <= 30)
            {
                return $"{namep1} {pointsP1} - {namep2} {pointsP2}";
            }
            if( pointsP1 == 60 && pointsP2 < 45)
                return $"{namep1} WINS";
            if (pointsP2 == 60 && pointsP1 < 45)
                return $"{namep2} WINS";
            if (pointsP2 == 45 && pointsP1 == 45)
                return "DEUCE";
            if (pointsP1 == 60 && pointsP2 >= 45)
                return $"{namep1} ADVANTAGE";
            if (pointsP2 == 60 && pointsP1 >= 45)
                return $"{namep2} ADVANTAGE";


            if (pointsP1 >= 45)
            {
                pointsP1 = 40;
                return $"{namep1} {pointsP1-5} - {namep2} {pointsP2-5}";
            }
            if (pointsP2 >= 45)
            {
                pointsP2 = 40;
             
            }
            return $"{namep1} {pointsP1} - {namep2} {pointsP2}";

        }
    }
}
