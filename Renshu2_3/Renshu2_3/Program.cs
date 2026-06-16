namespace Renshu2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string candy = "きャンディー";
            Console.Write("Please enter the candy number 1 :");
            String a = Console.ReadLine();
            bool isAInt = int.TryParse(a, out int resultForA);
            Console.Write("Please enter the candy number 2 :");
            String b = Console.ReadLine();
            bool isBInt = int.TryParse(b, out int resultForB);
            if (isAInt == false)
            {
                Console.WriteLine("Invalid Number IN A:");
            }
            else
            {
                Console.WriteLine("Invalid Number IN B:");
            }
            string basket = candy + (a + b).ToString() + "つ";
            Console.Write("The Result for total candy is :");
            Console.WriteLine(basket);
        }
    }
}
