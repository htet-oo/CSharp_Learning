namespace kadai1_1C30JT_HtetOoWaiYan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.GetBookName(1);
            book.GetBookPrice(1);
            book.CalcSum(2800,3);

            Console.WriteLine($"Id{book.id},Name{book.name},Price{book.price},TotalPrice{book.GetSum()}");
        }
    }
}
