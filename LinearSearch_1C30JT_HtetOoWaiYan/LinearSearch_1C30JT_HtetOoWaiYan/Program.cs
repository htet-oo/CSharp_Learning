namespace LinearSearch_1C30JT_HtetOoWaiYan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{30,48,42,78,62,12,88,53,94,24 };
            bool indexFoundOrNot = false;
            int indexNumber = 0;
            Console.Write("探したい番号を入力してください。　: ");
            int indexToFind = int.Parse(Console.ReadLine());
            for (int i = 1; i <= array.Length; i++)
            {
                indexNumber++;
                if (indexToFind == array[i-1])
                {
                    indexFoundOrNot = true;
                }
            }

            if (indexFoundOrNot)
            {
                Console.WriteLine("入力した直が見つかりました。");
                Console.WriteLine($"探索した回数は{indexNumber}回です。");
            }
            else
            {
                Console.WriteLine("入力した直が見つかりません。");
                Console.WriteLine($"探索した回数は{indexNumber}回です。");
            }
        }
    }
}
