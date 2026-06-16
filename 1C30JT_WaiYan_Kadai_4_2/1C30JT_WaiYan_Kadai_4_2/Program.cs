namespace _1C30JT_WaiYan_Kadai_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputToInt;
            Console.Write("回数を代入してください。");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userInputToInt))
            {
                for (int i = 0; i < userInputToInt; i++)
                {
                    for(int j = 0; j < userInputToInt; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }
        }
    }
}
