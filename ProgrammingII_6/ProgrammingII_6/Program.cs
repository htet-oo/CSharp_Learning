namespace ProgrammingII_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 1, 3, 3, 6, 4};
            int max = score[0];
            for (int i = 0; i <= 4; i++)
            {
                if (max < score[i])
                {
                    max = score[i];
                }

            }
            Console.WriteLine(max);
        }
    }
}
