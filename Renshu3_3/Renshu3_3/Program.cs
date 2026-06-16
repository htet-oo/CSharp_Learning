namespace Renshu3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInputToNumber; string userInput;
            Console.Write("点数を代入してください。");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userInputToNumber))
            {
                if (userInputToNumber < 0 || userInputToNumber > 100)
                {
                    Console.WriteLine("エラー");
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
            else
            {
                Console.WriteLine(".........数字を代入してください。.........");
            }

        }
    }
}
