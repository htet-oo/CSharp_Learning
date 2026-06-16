namespace _1C30JT_WaiYan_Kadai_4_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputToInt;
            Console.Write("整数　n を代入してください　 : ");
            userInput = Console.ReadLine();
            if(int.TryParse(userInput, out userInputToInt))
            {
                userInputToInt = userInputToInt;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            for(int i = 0; i < userInputToInt; i++)
            {
                string circleOne,circleTwo;

                if (i % 2 == 0)
                {
                    circleOne = " □ ";
                    circleTwo = " ■ ";
                }
                else
                {
                    circleOne = " ■ ";
                    circleTwo = " □ ";
                }
                    for (int j = 1; j <= userInputToInt; j++)
                    {
                        if (j % 2 == 0)
                        {
                        Console.Write(circleTwo);
                        }
                        else
                        {
                        Console.Write(circleOne);

                        }
                    }
                Console.WriteLine();

            }
        }
    }
}
