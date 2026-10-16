namespace kadai2_1C30JT_HtetOoWaiYan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product("ノートパソコン", 120000);
            Console.WriteLine($"{productOne.Name} の金額は {productOne.Price}");

            Product productTwo = new Product("ノートパソコン", -5);
            Console.WriteLine($"{productTwo.Name} の金額は {productTwo.Price}");
        }
    }
}
