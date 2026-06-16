namespace _1C30JT_WaiYan_kadai_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kakugo, sansu, rika;
            Console.Write("国語の点数は。: ");
            kakugo = int.Parse(Console.ReadLine());
            Console.Write("算数の点数は。: ");
            sansu = int.Parse(Console.ReadLine());
            Console.Write("理科の点数は。: ");
            rika = int.Parse(Console.ReadLine());
            int total = kakugo + sansu + rika;
            int average = total / 3;
            Console.WriteLine("会計 : " + total);
            Console.WriteLine("平均点 : " + average);
        }
    }
}
