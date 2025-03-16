using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGames
{
    internal class TraitementTransFile : ITraitement
    {
        public IEnumerable<string?> Traite(IEnumerable<string> source)
        {
            if (source == null) yield return null;

            foreach (var item in source)
            {
                yield return TraiteLigne(item);
            } 
        }
        public string TraiteLigne(string ligne)
        {
            char[] ligneArray = ligne.ToCharArray();
            Array.Reverse(ligneArray);
            return new string(ligneArray);
        }
    }

    public class Inversion : IInversion
    {
        public List<string> Inverse(IEnumerable<string> source)
        {
            List<string> list = new List<string>(source);
            
            for (int i = 0; i< list.Count; i++)
            {
                string padded = i.ToString().PadLeft(5, '0');
                StringBuilder st = new StringBuilder(padded);
                st.Append($":{list[i]}");
                list[i] = st.ToString();

            }
            return list; 
        }

    }
    public interface ITraitement
    {
        IEnumerable<string> Traite(IEnumerable<string> source);
        string TraiteLigne(string ligne); 
    }
    public interface IInversion
    {
        List<string> Inverse(IEnumerable<string> source);
    }
}
