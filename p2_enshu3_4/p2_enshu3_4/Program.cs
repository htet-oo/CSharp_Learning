namespace p2_enshu3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> monthList = new List<string>
            {
                "January",
                "January",
                "April",
                "May",
                "June"
            };

            monthList[1] = "February";
            monthList.Insert(2,"March");
            Console.WriteLine("変更、挿入の確認");
            foreach(string month in monthList)
            {
                Console.WriteLine(month);
            }
            monthList.Add("Junly");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            Console.WriteLine();
            Console.WriteLine("追加の確認");
            foreach (string month in monthList)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine();
            Console.WriteLine("J ではじまる月を表示する");
            var starWithJ = monthList.Where(month => month.StartsWith("J")).ToList();
            foreach(string month in starWithJ)
            {
                Console.WriteLine($"Jから始まる月　：　{month}");
            }

            Console.WriteLine();
            Console.WriteLine("r で終わる月を表示する");
            var endWithR = monthList.Where(month => month.EndsWith("r")).ToList();
            foreach (string month in endWithR)
            {
                Console.WriteLine($"Jから終わる月　：　{month}");
            }
        }
    }
}
