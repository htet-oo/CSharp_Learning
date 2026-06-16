namespace Renshu8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wdata today = new Wdata();
            today.month = 10;
            today.day = 9;
            today.sky = "晴れ";
            today.output(today.month,today.day,today.sky);
            //Console.WriteLine(today.month + "月" + today.day + "日" + today.sky);

            Wdata tomorrow = new Wdata();
            tomorrow.month = 10;
            tomorrow.day = 10;
            tomorrow.sky = "曇り";
            tomorrow.output(tomorrow.month,tomorrow.day,tomorrow.sky);
            //Console.WriteLine($"{tomorrow.month}月{tomorrow.day}日{tomorrow.sky}");

            Wdata[] data = new Wdata[31];
            data[0] = new Wdata();
            data[0].month = 1;
            data[0].day = 10;
            data[0].sky = "雨";
            Console.WriteLine($"{data[0].month}月{data[0].day}日{data[0].sky}");


        }
    }
}
