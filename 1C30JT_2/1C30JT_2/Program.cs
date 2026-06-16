namespace _1C30JT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arrayTwo = new int[] { 0, 0, 0, 0, 0, 0, 0 };

            Console.Write("実行前の　Ary1　の内容　: ");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write(arrayOne[i]);
            }

            Console.WriteLine();
            Console.Write("実行前の　Ary2　の内容　: ");
            for (int i = 0;i < arrayTwo.Length; i++)
            {
                Console.Write(arrayTwo[i]);
            }

            Console.WriteLine();
            Console.Write("実行後の　Ary1　の内容　: ");
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write(arrayOne[i]);
            }

            Console.WriteLine();
            Console.Write("実行後の　Ary2　の内容　: ");
            for(int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write(arrayOne[arrayOne.Length -1 -i]);
            }

        }
    }
}
