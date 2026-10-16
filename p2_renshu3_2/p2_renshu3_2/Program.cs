namespace p2_renshu3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(string name, int price)> fruitsList = new List<(string name, int price)>
            {
                ("apple", 400),
                ("pineapple", 600),
                ("grape",900),
                ("watermelon", 2000)
            };

            var expensiveFruitByWhere = fruitsList.Where(f => f.price >= 2000).ToList();
            foreach (var fruit in expensiveFruitByWhere)
            {
                Console.WriteLine($"{fruit.name} and {fruit.price}");
            }
            Console.WriteLine();

            var fruitName = fruitsList.Select(f => f.name).ToArray();

            for(int i = 0; i < fruitName.Length; i++)
            {
                Console.WriteLine(fruitName[i]);
            }
            Console.WriteLine();

            var fruitNameTwo = fruitsList.Where(f => f.name.StartsWith("a")).ToList();

            foreach (var fruit in fruitNameTwo)
            {
                Console.WriteLine($"{fruit.name},{fruit.price}");
            }
           
        }
    }
}
