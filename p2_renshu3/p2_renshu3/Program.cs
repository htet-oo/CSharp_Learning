namespace p2_renshu3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("pineapple");
            fruits.Add("grape");

            foreach (string s in fruits)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            fruits.RemoveAt(3);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            bool result = fruits.Contains("banana");
            Console.WriteLine(result);

            if (result)
            {
                Console.WriteLine("There is banana");
            }
            else
            {
                Console.WriteLine("There is no banana");
            }

            fruits.Insert(3,"Lemon");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
        }


    }
}
