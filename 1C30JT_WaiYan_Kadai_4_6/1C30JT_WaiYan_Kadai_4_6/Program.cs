namespace _1C30JT_WaiYan_Kadai_4_6
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
                int i = 0, j = 0;
                while (i <= userInputToInt)
                {
                    while (j < i)
                    {
                        Console.Write("*");
                        j = j + 1;
                    }
                    Console.WriteLine();
                    i = i + 1;
                    j = 0;
                }
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }
        }
    }
}
