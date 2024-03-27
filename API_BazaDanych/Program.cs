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

            d.getDetails().Wait();

            Console.WriteLine(d.drinks.ElementAt(148).SearchID);
            
        }
    }
}
