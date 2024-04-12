using API_BazaDanych;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;

namespace GUI
{
    public partial class Form1 : Form
    {
        public DrinkDB DrinkDB;
        private HttpClient client;
        private Drinks TMPdrinks_Alc;
        private Drinks TMPdrinks_NonAlc;

        private Drink selectedDrink;
        private int id;
        private int newID;
        public Form1()
        {
            InitializeComponent();
            DrinkDB = new DrinkDB();
            client = new HttpClient();
            TMPdrinks_Alc = new Drinks();
            TMPdrinks_NonAlc = new Drinks();
            id = 1;

            //DrinkDB.Drinks.RemoveRange(DrinkDB.Drinks);
            if (DrinkDB.Drinks.Count() != 0)
            {
                lstBox_Initial.DataSource = DrinkDB.Drinks.ToList<Drink>();
            }

        }

        private void lstBox_Initial_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = lstBox_Initial.SelectedItem.ToString().Split(',');

            txtBox_InitialResult.Clear(); //Do wywalenia

            string res = Regex.Match(tmp[0], @"\d+").Value;
            int wynik = int.Parse(res);

            txtBox_InitialResult.Text = wynik.ToString();
            selectedDrink = DrinkDB.Drinks.Find(wynik);

        }

        private async void btn_GetDetails_Click(object sender, EventArgs e)
        {
            if (selectedDrink.detailed == false)
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

                    if (detailedDrink.drinks[0].strIngredient1 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient1);
                    }
                    else
                    {
                        selectedDrink.Ingredients.Add("");
                    }
                    if (detailedDrink.drinks[0].strIngredient2 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient2);
                    }
                    else
                    {
                        selectedDrink.Ingredients.Add("");
                    }
                    if (detailedDrink.drinks[0].strIngredient3 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient3);
                    }
                    else
                    {
                        selectedDrink.Ingredients.Add("");
                    }
                    if (detailedDrink.drinks[0].strIngredient4 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient4);
                    }
                    else
                    {
                        selectedDrink.Ingredients.Add("");
                    }
                    if (detailedDrink.drinks[0].strIngredient5 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient5);
                    }
                    else
                    {
                        selectedDrink.Ingredients.Add("");
                    }
                    if (detailedDrink.drinks[0].strIngredient6 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient6);
                    }
                    if (detailedDrink.drinks[0].strIngredient7 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient7);
                    }
                    if (detailedDrink.drinks[0].strIngredient8 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient8);
                    }
                    if (detailedDrink.drinks[0].strIngredient9 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient9);
                    }
                    if (detailedDrink.drinks[0].strIngredient10 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient10);
                    }
                    if (detailedDrink.drinks[0].strIngredient11 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient11);
                    }
                    if (detailedDrink.drinks[0].strIngredient12 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient12);
                    }
                    if (detailedDrink.drinks[0].strIngredient13 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient13);
                    }
                    if (detailedDrink.drinks[0].strIngredient14 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient14);
                    }
                    if (detailedDrink.drinks[0].strIngredient15 != null)
                    {
                        selectedDrink.Ingredients.Add(detailedDrink.drinks[0].strIngredient15);
                    }

                    if (detailedDrink.drinks[0].strMeasure1 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure1);
                    }
                    else
                    {
                        selectedDrink.Measuers.Add("");
                    }
                    if (detailedDrink.drinks[0].strMeasure2 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure2);
                    }
                    else
                    {
                        selectedDrink.Measuers.Add("");
                    }
                    if (detailedDrink.drinks[0].strMeasure3 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure3);
                    }
                    else
                    {
                        selectedDrink.Measuers.Add("");
                    }
                    if (detailedDrink.drinks[0].strMeasure4 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure4);
                    }
                    else
                    {
                        selectedDrink.Measuers.Add("");
                    }
                    if (detailedDrink.drinks[0].strMeasure5 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure5);
                    }
                    else
                    {
                        selectedDrink.Measuers.Add("");
                    }
                    if (detailedDrink.drinks[0].strMeasure6 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure6);
                    }
                    if (detailedDrink.drinks[0].strMeasure7 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure7);
                    }
                    if (detailedDrink.drinks[0].strMeasure8 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure8);
                    }
                    if (detailedDrink.drinks[0].strMeasure9 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure9);
                    }
                    if (detailedDrink.drinks[0].strMeasure10 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure10);
                    }
                    if (detailedDrink.drinks[0].strMeasure11 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure11);
                    }
                    if (detailedDrink.drinks[0].strMeasure12 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure12);
                    }
                    if (detailedDrink.drinks[0].strMeasure13 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure13);
                    }
                    if (detailedDrink.drinks[0].strMeasure14 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure14);
                    }
                    if (detailedDrink.drinks[0].strMeasure15 != null)
                    {
                        selectedDrink.Measuers.Add(detailedDrink.drinks[0].strMeasure15);
                    }


                    string ConnectionStr = "Data Source=S:\\MyFiles\\Studia\\Sem6\\NET_Java\\Lab2\\API_BazaDanych\\GUI\\Drinks.db;";
                    SqliteConnection con = new SqliteConnection(ConnectionStr);
                    con.Open();


                    selectedDrink.AlternateDrink = detailedDrink.drinks[0].strDrinkAlternate;
                    selectedDrink.Tags = detailedDrink.drinks[0].strTags;
                    selectedDrink.Category = detailedDrink.drinks[0].strCategory;
                    selectedDrink.Glass = detailedDrink.drinks[0].strGlass;
                    selectedDrink.Instructions = detailedDrink.drinks[0].strInstructions;
                    selectedDrink.detailed = true;

                    string Recepie = selectedDrink.Instructions;
                    string Tags = selectedDrink.Tags;
                    string Category = selectedDrink.Category;
                    string Glass = selectedDrink.Glass;
                    string Alternate = selectedDrink.AlternateDrink;
                    List<string> Ingr = selectedDrink.Ingredients;
                    List<string> Meas = selectedDrink.Measuers;
                    bool det = selectedDrink.detailed;

                    string Query = "UPDATE Drinks SET Instructions = '" + Recepie + "' AND Tags = '" + Tags + "' AND Category = '" + Category + "' AND Glass = '" + Glass + "' AND AlternateDrink = '" + Alternate + "' AND Ingredients = '" + Ingr + "' AND Measuers= '" + Meas + "' AND detailed = '" + det + "' WHERE ID = " + selectedDrink.ID;

                    SqliteCommand cmd = new SqliteCommand(Query, con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    selectedDrink = DrinkDB.Drinks.Find(selectedDrink.ID);

                    DrinkDB.SaveChanges();

                    MessageBox.Show("Data has been saved!");

                    Details detailsForm = new Details(selectedDrink, DrinkDB);
                    detailsForm.ShowDialog();



                }
            }
            else
            {
                Details detailsForm = new Details(selectedDrink, DrinkDB);
                detailsForm.ShowDialog();
            }
        }

        private void btn_SortAlc_Click(object sender, EventArgs e)
        {
            lstBox_Initial.DataSource = DrinkDB.Drinks.Where(s => s.IsAlcoholic == true).ToList<Drink>();
        }

        private void btn_SortNonAlc_Click(object sender, EventArgs e)
        {
            lstBox_Initial.DataSource = DrinkDB.Drinks.Where(s => s.IsAlcoholic == false).ToList<Drink>();
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            lstBox_Initial.DataSource = DrinkDB.Drinks.ToList<Drink>();
            txtBox_FilterName.Clear();
        }

        private void txtBox_FilterName_TextChanged(object sender, EventArgs e)
        {
            string reg = txtBox_FilterName.Text;
            lstBox_Initial.DataSource = DrinkDB.Drinks.Where(s => s.Name.Contains(reg)).ToList<Drink>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void downloadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DrinkDB.Drinks.RemoveRange(DrinkDB.Drinks);
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

                    DrinkDB.Drinks.Add(tmp);
                    DrinkDB.SaveChanges();

                    id++;
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

                    DrinkDB.Drinks.Add(tmp);
                    DrinkDB.SaveChanges();

                    id++;
                }
            }
            id = 1;
            lstBox_Initial.DataSource = DrinkDB.Drinks.ToList<Drink>();
        }

        private void btn_FilterFav_Click(object sender, EventArgs e)
        {
            lstBox_Initial.DataSource = DrinkDB.Drinks.Where(s => s.Favourite == true).ToList<Drink>();
        }

        private void btn_AddFav_Click(object sender, EventArgs e)
        {
            string ConnectionStr = "Data Source=S:\\MyFiles\\Studia\\Sem6\\NET_Java\\Lab2\\API_BazaDanych\\GUI\\Drinks.db;";
            SqliteConnection con = new SqliteConnection(ConnectionStr);
            con.Open();


            selectedDrink.Favourite = true;
            bool fav = selectedDrink.Favourite;

            string Query = "UPDATE Drinks SET Favourite = '" + fav + "' WHERE ID =" + selectedDrink.ID;

            SqliteCommand cmd = new SqliteCommand(Query, con);
            cmd.ExecuteNonQuery();
            DrinkDB.SaveChanges();
            con.Close();

            selectedDrink = DrinkDB.Drinks.Find(selectedDrink.ID);
        }
    }
}
