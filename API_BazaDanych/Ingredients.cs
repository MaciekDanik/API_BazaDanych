using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BazaDanych
{
    public class IngredientsAndMeasures
    {
        public List<string> Ingredients { get; set; }
        public List<string> Measures { get; set; }

        public IngredientsAndMeasures() {
            Ingredients = new List<string>();
            Measures = new List<string>();
        }
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
