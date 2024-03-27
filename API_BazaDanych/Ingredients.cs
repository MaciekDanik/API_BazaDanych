using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BazaDanych
{
    public class IngredientsAndMeasures
    {
        public List<string> Ingredients;
        public List<string> Measures;

        public override string ToString()
        {
            string result="";
            for(int i = 0; i < Ingredients.Count; i++)
            {
                result += Ingredients[i] + ": " + Measures[i] + Environment.NewLine;
            }
            return result;
        }
    }
}
