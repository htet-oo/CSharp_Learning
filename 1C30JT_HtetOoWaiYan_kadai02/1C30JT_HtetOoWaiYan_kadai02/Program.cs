namespace _1C30JT_HtetOoWaiYan_kadai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1つ目の整数を入力してください　：　");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("2つ目の整数を入力してください　：　");
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne == numberTwo)
            {
                Console.WriteLine("2つ目の値は同じです。");
            }else if (numberOne > numberTwo)
            {
                Console.WriteLine("1つ目の値の方が大きいです。");
            }
            else if (numberTwo > numberOne)
            {
                Console.WriteLine("2つ目の値の方が大きいです。");
            }
            else
            {
                Console.WriteLine("Can't  deciede");
            }
        }
    }
}
