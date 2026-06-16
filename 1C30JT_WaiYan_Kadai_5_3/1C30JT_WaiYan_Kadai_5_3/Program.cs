namespace _1C30JT_WaiYan_Kadai_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] value = new int[31];
            for (int i = 0; i < value.Length; i++)
            {
                if ((i == 0) || (i == 1))
                {
                    value[i] = 1;
                }
                else
                {
                    value[i] = value[i - 1] + value[i - 2];
                }
            }

            string userInputN;
            string userInputM;
            int userInputNToInt;
            int userInputMToInt;
            Console.Write("整数 N を入力　: ");
            userInputN = Console.ReadLine();
            if (int.TryParse(userInputN, out userInputNToInt))
            {
                userInputNToInt = userInputNToInt;
                if (userInputNToInt > 30)
                {
                    Console.WriteLine("30 以下を入力してください");
                }

            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            Console.Write("整数 M を入力　: ");
            userInputM = Console.ReadLine();
            if (int.TryParse(userInputM, out userInputMToInt))
            {
                userInputMToInt = userInputMToInt;
                if (userInputNToInt > 30)
                {
                    Console.WriteLine("30 以下を入力してください");
                }
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            Console.WriteLine($"F[{userInputNToInt}] + F[{userInputMToInt}] = {value[userInputNToInt] + value[userInputMToInt]}");
        }
    }
}
