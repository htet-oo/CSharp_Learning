namespace _1C30JT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GTotal = 0;
            int ETotal = 0;
            int OTotal = 0;
            for (int i = 1; i <= 100; i++)
            {
                GTotal = GTotal + i;
                if (i % 2 == 0)
                {
                    ETotal = ETotal + i;
                }
                else
                {
                    OTotal = OTotal + i;
                }
            }

            Console.WriteLine("整数の会計は" + GTotal);
            Console.WriteLine("偶数の会計は" + ETotal);
            Console.WriteLine("奇数の会計は" + OTotal);
        }
    }
}
