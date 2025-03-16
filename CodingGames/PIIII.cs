using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    class Point
    {
        public double x, y;
    }
    internal class PIIII
    {
        public static double Approx(Point[] pts)
        {
            double incrementPts = 0;
         
            for(int i=0; i<pts.Length; i++)
            {
                double formula = pts[i].x * pts[i].x + pts[i].y * pts[i].y;
                if(formula <= 1)
                {
                    incrementPts++;

                }
                
            }
            double PI = (4.0 * incrementPts) / pts.Length;
            return PI; 
        }
    }
}
