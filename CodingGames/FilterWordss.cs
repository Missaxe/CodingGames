using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class FilterWordss
    {
        //[DllImport("unmanaged.ddl")]
        //public static extern IntPtr UnmanagedMethod(int number);

        //[MethodImport("unmanaged.ddl")]
        //public static extern IntPtr UnmanagedMethod(int number);

        public static string[] FilterWords(string[] words, string letters)
        {

            HashSet<string> result = new HashSet<string>();
            char[] letChar = letters.ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {
             var kk = words[i].IndexOfAny(letChar)!= -1;
                if(kk)
                {
                    result.Add(words[i]);

                }
            }
            return result.ToArray();


        }

        public string caseVar (int[] numberList)
        {
            int? numbor = null;
            numbor ??= 1;

            foreach (var number in numberList)
            {
                switch (number) {
                    case var x when x >=1 && x <= 3 :
                        return "yes";
                    case var x when x>=4 && x <= 5 :
                        return "no";
                    default  :  
                        return "unknown";
                    }
            }
            return ";";
        }

        //public static async System.Collections.Generic.IAsyncEnumerable mm()
        //{
        //    while(await HasNextStringAsync())
        //    { 
        //        yield return await GetNextStringAsync(); 
        //    }

        //}

        //public static async System.Collections.Generic.IAsyncEnumerable mm()
        //{
        //    while ( HasNextStringAsync())
        //    {
        //        yield return  GetNextStringAsync();
        //    }

        //}
        //public static async System.Collections.Generic.IAsyncEnumerable mm()
        //{
        //    while (HasNextString())
        //    {
        //        yield return GetNextString();
        //    }

        //}
    }
}
