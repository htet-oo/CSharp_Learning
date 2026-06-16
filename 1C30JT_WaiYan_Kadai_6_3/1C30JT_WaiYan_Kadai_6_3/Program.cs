namespace _1C30JT_WaiYan_Kadai_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string userInput;
                int userInputToInt;
                Console.Write("整数Nを入力してください : ");
                userInput = Console.ReadLine();
                userInputToInt = int.Parse(userInput);
                bool[] mono = new bool[userInputToInt];
                int count = 0;

                for (int i = 0; i < mono.Length; i++)
                {

                    if (i % 3 == 0)
                    {
                        if (i - 1 >= 0)
                        {
                            mono[i - 1] = !mono[i - 1];
                        }

                        if (i + 1 < mono.Length)
                        {
                            mono[i + 1] = !mono[i + 1];
                        }
                    }

                    if (i % 5 == 0)
                    {
                        if (i - 1 >= 0)
                        {
                            mono[i - 1] = !mono[i - 1];
                        }

                        if (i + 1 < mono.Length)
                        {
                            mono[i + 1] = !mono[i + 1];
                        }
                    }

                    if (i % 7 == 0)
                    {
                        if (i - 1 >= 0)
                        {
                            mono[i - 1] = !mono[i - 1];
                        }

                        if (i + 1 < mono.Length)
                        {
                            mono[i + 1] = !mono[i + 1];
                        }
                    }
                }

                Console.WriteLine($"trueの数は{mono.Count(x => x)}");
            }
            catch( OverflowException ofe)
            {
                Console.WriteLine("エラー : 入力された値がおおきすぎます。");
                return;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("エラー : 入力された値は整数ではありません。");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"予期せぬエラーが発生しました。{e.Message}");
                return;
            }
        }
    }
}
