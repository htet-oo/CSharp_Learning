namespace ProgrammingII_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("点数を入力してください。 >  ");
            score = int.Parse(Console.ReadLine());
            if(score >= 80)
            {
                Console.WriteLine("");
            }
            else if (score >= 70)
            {
                Console.WriteLine("良");
            }
            else if (score >= 60)
            {
                Console.WriteLine("可");
            }
            else
            {
                Console.WriteLine("不可");
            }
        }
    }
}
