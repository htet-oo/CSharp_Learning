namespace ProgrammingII_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  * * *九九の表　* * *");
            Console.Write("  |");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0,3}",i);
            }
            Console.WriteLine("\n-------------------------------------");
            for (int x = 1; x <= 9; x++)
            {
                Console.Write("{0} |",x);
                for (int y = 1; y <= 9; y++)
                {
                    Console.Write("{0,3}",x * y);
                }
                Console.Write("\n");
            }

        }
    }
}
