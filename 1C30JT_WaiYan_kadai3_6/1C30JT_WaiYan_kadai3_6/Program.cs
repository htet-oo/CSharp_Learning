namespace _1C30JT_WaiYan_kadai3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputToNumber;
            Console.Write("点数を代入してください。");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out userInputToNumber))
            {
                if (userInputToNumber >= 60)
                {
                    if (userInputToNumber >= 80)
                    {
                        Console.WriteLine("優");
                    }
                    else if (userInputToNumber >= 70) 
                    {
                        Console.WriteLine("良");
                    }
                    else
                    {
                        Console.WriteLine("可");
                    }

                }
                else
                {
                    Console.WriteLine("不可");
                }
            }
            else 
            {
                Console.WriteLine("数字を代入してください。");
            }
        }
    }
}
