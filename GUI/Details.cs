using API_BazaDanych;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Details : Form
    {
        private Drink drink;
        public Details(Drink _drink, DrinkDB database)
        {
            InitializeComponent();
            drink = _drink;
            txtBox_drinkName.Text = drink.Name;
            txtBox_drinkCategory.Text = drink.Category;
            txtBox_drinkGlass.Text = drink.Glass;
            txtBox_recepie.Text = drink.Instructions;
            txtBox_ingredients.Text = drink.IngrToString();

            string urlAdress = drink.drinkPIC;
            string search = "/preview";
            string find = urlAdress + search;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(find);

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void lbl_drinkInstructions_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddToFav_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_drinkName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_drinkGlass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
