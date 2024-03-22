namespace API_BazaDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            APITest t = new APITest();
            t.GetData().Wait();
        }
    }
}
