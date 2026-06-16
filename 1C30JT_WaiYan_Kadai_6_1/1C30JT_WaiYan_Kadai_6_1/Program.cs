namespace _1C30JT_WaiYan_Kadai_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string userInput;
                int userInputToInt;
                Console.Write("整数を入力してください : ");
                userInput = Console.ReadLine();
                userInputToInt = int.Parse(userInput);
                Console.WriteLine(userInputToInt);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("エラー : 入力された値は整数ではありません。");
            }
            catch (OverflowException ove)
            {
                Console.WriteLine("エラー : 入力された値がおおきすぎます。");
            }
            catch (Exception e)
            {
                Console.WriteLine($"予期せぬエラーが発生しました。{e.Message}");
            }
            finally
            {
                Console.WriteLine("プログラムを終了します。");
            }

        }
    }
}
