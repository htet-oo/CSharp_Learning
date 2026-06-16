namespace Renshu3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("A は : ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0){
                Console.WriteLine($"{a} は　偶数です。");
            }
            else {
                Console.WriteLine($"{a} は　奇数です。");
            }
        }
    }
}
