using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace whatDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.WriteLine("入力 1 :");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("入力 2 :");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("入力 3 :");
            day = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(year, month, day);
            string date = dateTime.ToString("dddd", new CultureInfo("jp-JP"));
            Console.WriteLine($"{year}年{month}月{day}日{date}です。");
        }
    }
}
