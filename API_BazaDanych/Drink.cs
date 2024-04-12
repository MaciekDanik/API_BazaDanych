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
        public string? AlternateDrink { get; set; }
        public string? Tags { get; set; }
        public string? Category { get; set; }
        public string? Glass { get; set; }
        public string? Instructions { get; set; }
        public string? drinkPIC { get; set; }        
        public bool IsAlcoholic { get; set; }
        public List<string>? Ingredients { get; set; }
        public List<string>? Measuers { get; set; }
        public bool detailed { get; set; }
        public bool Favourite { get; set; }

        public Drink()
        {
            Ingredients = new List<string>();
            Measuers = new List<string>();
            //SearchID = "";
            detailed = false;
            Favourite = false;
            Tags = "";
            Category = "";
            Glass = "";
            Instructions = "";
        }


        public override string ToString()
        {
            if (Favourite == false && IsAlcoholic == false)
            {
                return $"ID: {ID},\t Name: {Name},\t\tNot Alcoholic" + Environment.NewLine;
            }
            else if (Favourite == false && IsAlcoholic == true)
            {
                return $"ID: {ID},\t Name: {Name},\t\tAlcoholic" + Environment.NewLine;
            }
            else if (Favourite == true && IsAlcoholic == true)
            {
                return $"ID: {ID},\t Name: {Name},\t\tAlcoholic,\t\tFav" + Environment.NewLine;
            }
            else
            {
                return $"ID: {ID},\t Name: {Name},\t\tNot Alcoholic,\t\tFav" + Environment.NewLine;
            }
        }

        public string IngrToString()
        {
            string ingr = "";

            for (int i = 0; i< Ingredients.Count; i++)
            {
                ingr += Ingredients[i].ToString() + Measuers[i].ToString() + Environment.NewLine;
            }
            return ingr;
        }

    }
}
