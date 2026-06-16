namespace DateEcho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.Write("入力 1 :");
            year = int.Parse(Console.ReadLine());

            Console.Write("入力 2 :");
            month = int.Parse(Console.ReadLine());

            Console.Write("入力 3 :");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine($"{year}年 {month}月 {day}日です。");
        }
    }
}
