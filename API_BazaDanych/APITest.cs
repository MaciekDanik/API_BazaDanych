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
    public class APITest
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string response = await client.GetStringAsync(call);

            List<Student> students = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(response);

            foreach(var student in students)
            {
                student.IsDeleted = false;
                Console.WriteLine(student.ToString());
            }
        }
    }

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
                //Console.WriteLine(drink.ToString());
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
                //Console.WriteLine(drink.ToString());
            }

            foreach (var x in drinks) { Console.WriteLine(x.ToString()); }
        }

        public async Task getDetails(Drink drink)
        {
            HttpClient client = new HttpClient();
            //DetailedDrink detailedDrink = new DetailedDrink();
            string urlAdress = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=";

            string search = drink.SearchID;
            string find = urlAdress + search;

            var result = await client.GetAsync(find);
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();

                DetailedDrink detailedDrink = Newtonsoft.Json.JsonConvert.DeserializeObject<DetailedDrink>(json);

                if(detailedDrink.drinks[0].strIngredient12 != null)
                {
                    Console.WriteLine($"ID: {drink.ID}\t Name: {detailedDrink.drinks[0].strIngredient12}");
                }
                else { Console.WriteLine("NULL"); }

            }
        }
    }
}
