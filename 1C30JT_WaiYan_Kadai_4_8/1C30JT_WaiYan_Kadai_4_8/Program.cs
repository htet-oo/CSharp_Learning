namespace _1C30JT_WaiYan_Kadai_4_8
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
                int i = 1, j = 0;
                do
                {
                    do
                    {
                        Console.Write("*");
                        j = j + 1;
                    } while (j < i);
                    Console.WriteLine("");
                    i = i + 1;
                    j = 0;
                }while (i <= userInputToInt);
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }
        }
    }
}
