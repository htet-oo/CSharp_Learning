namespace _1C30JT_WaiYan_Kadai_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputToInt;
            int[] a = new int[5];
            int[] b = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"a[{i}] : ");
                userInput = Console.ReadLine();
                if(int.TryParse(userInput,out userInputToInt))
                {
                    a[i] = userInputToInt;
                }
                else
                {
                    Console.WriteLine("数字を代入してください。");

                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];
            }

            for(int i = 0;i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
