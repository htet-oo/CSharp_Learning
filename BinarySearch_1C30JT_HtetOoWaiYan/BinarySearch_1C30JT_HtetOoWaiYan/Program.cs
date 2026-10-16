namespace BinarySearch_1C30JT_HtetOoWaiYan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {12,24,30,42,48,53,62,78,88,94 };
            Console.Write("探したい番号を入力してください。　: ");
            int indexToFind = int.Parse(Console.ReadLine());
            bool indexFoundOrNot = false;
            int indexNumber = 0;

            int left = 0;
            int right = array.Length -1;

            while(left <= right)
            {
                int mid = (right + left) / 2;
                indexNumber++;

                if (indexToFind == array[mid])
                {
                    indexFoundOrNot = true;
                    break;
                }else if (indexToFind < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
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
