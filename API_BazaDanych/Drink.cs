using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BazaDanych
{
    public class Drink
    {
        public string Name { get; set; }

        public string drinkPIC { get; set; }

        public string SearchID { get; set; }
        public bool IsAlcoholic { get; set; }

        public int ID { get; set; }

        public override string ToString()
        {
            return $"ID: {ID},\t Name: {Name},\t Alcoholic: {IsAlcoholic}" + Environment.NewLine;
        }

    }

    public class Drink_Template
    {
        public string strDrink { get; set; }

        public string strDrinkThumb { get; set; }

        public string idDrink { get; set; }
        //public bool IsAlcoholic { get; set; }

        public override string ToString()
        {
            return $"ID: {idDrink},\t Name: {strDrink},\t Alcoholic: " + Environment.NewLine;
        }

    }

    public class Drinks
    {
        public Drink_Template[] drinks { get; set; }
    }
}
