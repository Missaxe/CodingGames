using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class TestIJ
    {

        public static bool Test(int i, int j)
        {
            var isParsed = int.TryParse("1", out _ );
          using  var  fss = File.Create("data.dat");
            return (i == 1 || j == 1 || i + j == 1);
        }
    }
}
