namespace p2_renshu3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> countList = new List<string>
            {
                "First",
                "Second",
                "Third",
                "Fourth",
                "Fifth"
            };

            Console.WriteLine("リストの表示");
            foreach(string item in countList)
            {
                Console.WriteLine($"{countList.IndexOf(item)}番目の要素 : {item}");
            }
            Console.WriteLine();

            countList.Insert(0,"Zero");
            countList.RemoveAt(1);
            countList.RemoveAt(1);

            foreach (string item in countList)
            {
                Console.WriteLine($"{countList.IndexOf(item)}番目の要素 : {item}");
            }
            Console.WriteLine();

            var countCheckList = countList.Where(item => item.StartsWith("F")).ToList();

            Console.WriteLine("検索結果");
            foreach (string item in countCheckList)
            {
                Console.WriteLine($"f から始まる文字　：　{item}");
            }

        }
    }
}
