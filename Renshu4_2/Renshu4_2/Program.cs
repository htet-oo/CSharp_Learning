namespace Renshu4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (j = 1; j <= 9; j++)
            {
                for (i = 1; i <=9; i++)
                {
                    Console.WriteLine(j + "x" + i + "=" + j*i);
                }
                Console.WriteLine();
            }
        }
    }
}
