using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

            List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);

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
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call_Alcoholic = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic";
            string call_NonAlcoholic = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Non_Alcoholic";
            string response_Alcoholic = await client.GetStringAsync(call_Alcoholic);
            string response_NonAlcoholic = await client.GetStringAsync(call_NonAlcoholic);

            //List<Drink> Drinks_Alcoholic = JsonSerializer.Deserialize<List<Drink>>(response_Alcoholic);
            //List<Drink> Drinks_NonAlcoholic = JsonSerializer.Deserialize<List<Drink>>(response_NonAlcoholic);

            /*foreach(var d in Drinks_Alcoholic)
            {
                //d.IsAlcoholic = true;
                Console.WriteLine(d.ToString());
            }
            foreach(var d in Drinks_NonAlcoholic)
            {
                //d.IsAlcoholic = false;
            }*/

            //Console.WriteLine(Drinks_Alcoholic.ToString());

        }

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
                TMPdrinks_Alc = JsonSerializer.Deserialize<Drinks>(json);
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
                TMPdrinks_NonAlc = JsonSerializer.Deserialize<Drinks>(json_non);
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
    }
}
