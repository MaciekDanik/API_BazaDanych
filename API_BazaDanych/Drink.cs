using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]
namespace API_BazaDanych
{
    public class Drink
    {
        public int ID { get; set; }
        public string SearchID { get; set; }
        public string Name { get; set; }
        public string AlternateDrink { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
        public string Glass { get; set; }
        public string Instructions { get; set; }
        public string drinkPIC { get; set; }        
        public bool IsAlcoholic { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Measuers { get; set; }
        //public IngredientsAndMeasures? Ingredients_Measures { get; set; }

        public Drink()
        {
            Ingredients = new List<string>();
            Measuers = new List<string>();
        }


        public override string ToString()
        {
            return $"ID: {ID},\t Name: {Name},\t Alcoholic: {IsAlcoholic}" + Environment.NewLine;
        }

        public string IngrToString()
        {
            //string generalInfo = $"ID: {ID}\tName: {Name},\tCategory: {Category}"+Environment.NewLine + $"Alcoholic: {IsAlcoholic}";

            string ingr = "";

            for (int i = 0; i< Ingredients.Count; i++)
            {
                ingr += Ingredients[i].ToString() + Measuers[i].ToString() + Environment.NewLine;
            }
            return ingr;
        }

    }
}
