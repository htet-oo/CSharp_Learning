namespace _1C30JT_WaiYan_Kadai_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputToInt, result = 0;
            Console.Write("回数を代入してください。");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userInputToInt))
            {
                for (int i = 0; i <= userInputToInt; i++) {
                    result = result + i;
                }
                Console.WriteLine($"1 から {userInput} までの和は　{result} です。");
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

        }
    }
}
