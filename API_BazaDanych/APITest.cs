using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GUI")]

namespace API_BazaDanych
{
    public class DrinkAPI
    {
        public List<Drink> drinks = new List<Drink>();
        public async Task getData()
        {
            HttpClient client = new HttpClient();
            Drinks TMPdrinks_Alc = new Drinks();
            Drinks TMPdrinks_NonAlc = new Drinks();

            int id = 1;

            var result = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic");
            if(result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                TMPdrinks_Alc = System.Text.Json.JsonSerializer.Deserialize<Drinks>(json);
            }

            foreach(var drink in TMPdrinks_Alc.drinks)
            {
                Drink tmp = new Drink();
                tmp.SearchID =drink.idDrink;
                tmp.Name = drink.strDrink;
                tmp.drinkPIC = drink.strDrinkThumb;
                tmp.IsAlcoholic = true;
                tmp.ID = id;

                drinks.Add(tmp);
                id++;
            }

            var result_nonAlc = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic");
            if (result_nonAlc.IsSuccessStatusCode)
            {
                var json_non = await result_nonAlc.Content.ReadAsStringAsync();
                TMPdrinks_NonAlc = System.Text.Json.JsonSerializer.Deserialize<Drinks>(json_non);
            }

            foreach (var drink in TMPdrinks_NonAlc.drinks)
            {
                Drink tmp = new Drink();
                tmp.SearchID = drink.idDrink;
                tmp.Name = drink.strDrink;
                tmp.drinkPIC = drink.strDrinkThumb;
                tmp.IsAlcoholic = false;
                tmp.ID = id;

                drinks.Add(tmp);
                id++;
            }

            foreach (var x in drinks) { Console.WriteLine(x.ToString()); }
        }

        public async Task getDetails(Drink drink)
        {
            HttpClient client = new HttpClient();
            string urlAdress = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=";

            string search = drink.SearchID;
            string find = urlAdress + search;

            var result = await client.GetAsync(find);
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();

                DetailedDrink detailedDrink = Newtonsoft.Json.JsonConvert.DeserializeObject<DetailedDrink>(json);

                if(detailedDrink.drinks[0].strIngredient1 != null)
                {
                    Console.WriteLine($"ID: {drink.ID}\t Name: {detailedDrink.drinks[0].strIngredient1}");
                }
                else { Console.WriteLine("NULL"); }

            }
        }
    }
}
