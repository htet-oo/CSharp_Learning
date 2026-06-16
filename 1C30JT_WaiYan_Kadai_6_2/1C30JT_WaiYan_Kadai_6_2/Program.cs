namespace _1C30JT_WaiYan_Kadai_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                string userInput;
                Console.Write("整数を入力してください : ");
                userInput = Console.ReadLine();
                int userInputToInt = int.Parse(userInput);
                try
                {
                    for (int i = 1; i <= userInputToInt; i++)
                    {
                        checked
                        {
                            result += i;
                        }
                    }

                    Console.WriteLine($"入力された整数　: {userInputToInt}");
                    Console.WriteLine($"1 から　{userInputToInt} までの和　: {result}");
                }
                catch (OverflowException ofe)
                {
                    Console.WriteLine("エラー : 計算途中で変数の値を超えました。");
                    return;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("エラー : 入力された値は整数ではありません。");
                return;
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("エラー : 入力された値がおおきすぎます。");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"予期せぬエラーが発生しました。{e.Message}");
                return;
            }
            finally
            {
                Console.WriteLine("プログラムを終了します。");
            }


        }
    }
}
