namespace Renshu3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInputNumber;
            string userInput;
            Console.Write("数直を代入してください。");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userInputNumber))
            {
                if (userInputNumber == 100)
                {
                    Console.WriteLine("満点です。");
                }
                else if (userInputNumber < 100)
                {
                    if (userInputNumber > 80)
                    {
                        Console.WriteLine("もう少しです。");
                    }
                    if (userInputNumber < 80)
                    {
                        Console.WriteLine("頑張りましょう");
                    }
                }
                else
                {
                    Console.WriteLine("ok");
                }
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

        }
    }
}
