using System.Runtime.CompilerServices;

namespace API_BazaDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //APITest t = new APITest();
            //t.GetData().Wait();

            DrinkAPI d = new DrinkAPI();
            d.getData().Wait();

            Drink drink = d.drinks[0];

            d.getDetails(drink).Wait();

            Console.WriteLine(d.drinks.ElementAt(0).SearchID);
            
        }
    }
}
