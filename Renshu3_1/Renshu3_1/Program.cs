namespace Renshu3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("a は : ");
            a = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out a);
            if (a < 0)
            {
                Console.WriteLine("正の数を代入してください。");
            }
        }
    }
}
