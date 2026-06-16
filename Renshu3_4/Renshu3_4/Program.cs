namespace Renshu3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputToNumber;
            Console.Write("数直を代入してください。");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userInputToNumber))
            {
                if (userInputToNumber < 10 && userInputToNumber >= 0)
                {
                    Console.WriteLine("1桁の数です。");
                }
                else if (userInputToNumber >= 10 && userInputToNumber < 100)
                {
                    Console.WriteLine("2桁の数です。");
                }
                else if (userInputToNumber >= 100 && userInputToNumber < 1000)
                {
                    Console.WriteLine("3桁の数です。");
                }
                else if (userInputToNumber >= 1000 && userInputToNumber < 10000)
                {
                    Console.WriteLine("4桁の数です。");
                }
                else
                {
                    Console.WriteLine($"{userInput.Length}桁の数です。");
                }
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }
        }
    }
}
