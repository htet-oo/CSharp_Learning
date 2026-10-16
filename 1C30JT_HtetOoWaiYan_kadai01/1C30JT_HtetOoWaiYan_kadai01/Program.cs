namespace _1C30JT_HtetOoWaiYan_kadai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("「月を入力してください。＞」   ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("「日を入力してください。＞」   ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("「地域を入力してください。＞」   ");
            string　region = Console.ReadLine();

            Console.Write("「気温を入力してください。＞」   ");
            float temperature = float.Parse(Console.ReadLine());

            Console.WriteLine($"「本日は　{month}月 {day}日です。」");
            Console.WriteLine($"  {region}の気温{temperature}は度です。");

        }
    }
}
