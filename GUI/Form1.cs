using API_BazaDanych;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class Form1 : Form
    {
        public List<Drink> drinks = new List<Drink>();
        private HttpClient client;
        private Drinks TMPdrinks_Alc;
        private Drinks TMPdrinks_NonAlc;

        private Drink selectedDrink;
        private int id;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            TMPdrinks_Alc = new Drinks();
            TMPdrinks_NonAlc = new Drinks();
            id = 1;
        }

        private async void btn_LoadData_Click(object sender, EventArgs e)
        {
            var result = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic");

            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                TMPdrinks_Alc = System.Text.Json.JsonSerializer.Deserialize<Drinks>(json);

                foreach (var drink in TMPdrinks_Alc.drinks)
                {
                    Drink tmp = new Drink();
                    tmp.SearchID = drink.idDrink;
                    tmp.Name = drink.strDrink;
                    tmp.drinkPIC = drink.strDrinkThumb;
                    tmp.IsAlcoholic = true;
                    tmp.ID = id;

                    drinks.Add(tmp);
                    id++;
                    //Console.WriteLine(drink.ToString());
                }
            }

            var result_nonAlc = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic");
            if (result_nonAlc.IsSuccessStatusCode)
            {
                var json_non = await result_nonAlc.Content.ReadAsStringAsync();
                TMPdrinks_NonAlc = System.Text.Json.JsonSerializer.Deserialize<Drinks>(json_non);

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
            }

            foreach (var drink in drinks)
            {
                txtBox_InitialResult.Text += drink.ToString();
                lstBox_Initial.Items.Add(drink);
            }
        }

        private void lstBox_Initial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = lstBox_Initial.SelectedItem.ToString().Split(',');

            txtBox_InitialResult.Clear(); //Do wywalenia

            string res = Regex.Match(tmp[0], @"\d+").Value;
            int wynik = int.Parse(res);

            txtBox_InitialResult.Text = wynik.ToString();

            foreach (var drink in drinks)
            {
                if (drink.ID == wynik)
                {
                    selectedDrink = drink;
                }
            }

        }

        private async void btn_GetDetails_Click(object sender, EventArgs e)
        {
            string urlAdress = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=";
            string search = selectedDrink.SearchID;
            string find = urlAdress + search;

            var result = await client.GetAsync(find);
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();

                DetailedDrink detailedDrink = Newtonsoft.Json.JsonConvert.DeserializeObject<DetailedDrink>(json);

                selectedDrink.AlternateDrink = detailedDrink.drinks[0].strDrinkAlternate;
                selectedDrink.Tags = detailedDrink.drinks[0].strTags;
                selectedDrink.Category = detailedDrink.drinks[0].strCategory;
                selectedDrink.Glass = detailedDrink.drinks[0].strGlass;
                selectedDrink.Instructions = detailedDrink.drinks[0].strInstructions;
                

                string ingr1 = detailedDrink.drinks[0].strIngredient1;
                if ( ingr1 != null)
                {
                    //selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient1.ToString());
                    selectedDrink.Ingredients.Add(ingr1);
                }/*
                if (detailedDrink.drinks[0].strIngredient2 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient2);
                }
                if (detailedDrink.drinks[0].strIngredient3 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient3);
                }
                if (detailedDrink.drinks[0].strIngredient4 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient4);
                }
                if (detailedDrink.drinks[0].strIngredient5 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient5);
                }
                if (detailedDrink.drinks[0].strIngredient6 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient6);
                }
                if (detailedDrink.drinks[0].strIngredient7 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient7);
                }
                if (detailedDrink.drinks[0].strIngredient8 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient8);
                }
                if (detailedDrink.drinks[0].strIngredient9 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient9);
                }
                if (detailedDrink.drinks[0].strIngredient10 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient10);
                }
                if (detailedDrink.drinks[0].strIngredient11 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient11);
                }
                if (detailedDrink.drinks[0].strIngredient12 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient12);
                }
                if (detailedDrink.drinks[0].strIngredient13 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient13);
                }
                if (detailedDrink.drinks[0].strIngredient14 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient14);
                }
                if (detailedDrink.drinks[0].strIngredient15 != null)
                {
                    selectedDrink.Ingredients_Measures.Ingredients.Add(detailedDrink.drinks[0].strIngredient15);
                }

                if (detailedDrink.drinks[0].strMeasure1 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure1);
                }
                if (detailedDrink.drinks[0].strMeasure2 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure2);
                }
                if (detailedDrink.drinks[0].strMeasure3 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure3);
                }
                if (detailedDrink.drinks[0].strMeasure4 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure4);
                }
                if (detailedDrink.drinks[0].strMeasure5 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure5);
                }
                if (detailedDrink.drinks[0].strMeasure6 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure6);
                }
                if (detailedDrink.drinks[0].strMeasure7 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure7);
                }
                if (detailedDrink.drinks[0].strMeasure8 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure8);
                }
                if (detailedDrink.drinks[0].strMeasure9 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure9);
                }
                if (detailedDrink.drinks[0].strMeasure10 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure10);
                }
                if (detailedDrink.drinks[0].strMeasure11 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure11);
                }
                if (detailedDrink.drinks[0].strMeasure12 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure12);
                }
                if (detailedDrink.drinks[0].strMeasure13 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure13);
                }
                if (detailedDrink.drinks[0].strMeasure14 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure14);
                }
                if (detailedDrink.drinks[0].strMeasure15 != null)
                {
                    selectedDrink.Ingredients_Measures.Measures.Add(detailedDrink.drinks[0].strMeasure15);
                }
                */
                Details detailsForm = new Details(selectedDrink);
                detailsForm.ShowDialog();


            }
        }
    }
}
