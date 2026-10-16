namespace p2_enshu3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("Lion");
            animals.Add("Tiger");
            animals.Add("Elephant");
            animals.Add("Panda");
            animals.Add("Bear");
            animals.Add("Bear");
            animals.Add("Koala");
            animals.Add("Monkey");

            Console.WriteLine("---追加の確認---");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            animals.RemoveAt(4);
            Console.WriteLine("---削除の確認---");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("---存在の確認---");
            bool koalaCheck = animals.Contains("Koala");
            bool penguinChecck = animals.Contains("Penguin");

            if (koalaCheck)
            {
                Console.WriteLine("Koala あります。");
            }
            else
            {
                Console.WriteLine("Koala ありません。");
            }

            if (penguinChecck)
            {
                Console.WriteLine("Penguin あります。");
            }
            else
            {
                Console.WriteLine("Penguin ありません。");
            }

            Console.WriteLine("---挿入の確認---");
            animals.Insert(4,"Penguin");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
