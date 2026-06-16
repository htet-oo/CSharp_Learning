namespace _1C30JT_WaiYan_Kadai_4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputN;
            string userInputM;
            int userInputNToInt;
            int userInputMToInt;
            Console.Write("n の値 : ");
            userInputN = Console.ReadLine();
            if(int.TryParse(userInputN, out userInputNToInt))
            {
                userInputNToInt = userInputNToInt;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            Console.Write("基準値　m : ");
            userInputM = Console.ReadLine();
            if (int.TryParse(userInputM, out userInputMToInt))
            {
                userInputMToInt = userInputMToInt;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            for(int i = 1; i <= userInputNToInt; i++)
            {
                Console.WriteLine(i);
                if(i == userInputMToInt)
                {
                    Console.WriteLine("中断しました。");
                    break;
                }
                
            }


        }
    }
}
