using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IngredientsAndMeasures Ingredients_Measures { get; set; }


        public override string ToString()
        {
            return $"ID: {ID},\t Name: {Name},\t Alcoholic: {IsAlcoholic},\t SearchID: {SearchID}" + Environment.NewLine;
        }

    }
}
