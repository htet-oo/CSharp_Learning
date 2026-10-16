using System;

namespace SelectionSortAndBinarySearch_1C30JT_HtetOoWaiYan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Score = { 30, 48, 42, 78, 62, 12, 88, 53, 94, 24 };

            Console.WriteLine("選択ソート前の配列：");
            PrintArray(Score);

            int compareCount = SelectionSort(Score);

            Console.WriteLine("\n選択ソート後の配列：");
            PrintArray(Score);

            Console.WriteLine($"\n比較回数は {compareCount} 回です。");

            Console.Write("\n検索する値を入力してください：");
            int x = int.Parse(Console.ReadLine());

            int result = BinarySearch(x, Score);

            if (result > 0)
            {
                Console.WriteLine("入力した値が見つかりました。");
            }
            else
            {
                Console.WriteLine("入力した値は見つかりません。");
            }

            Console.WriteLine($"探索回数は {Math.Abs(result)} 回です。");
        }

        static int SelectionSort(int[] Score)
        {
            int compareCount = 0;

            for (int i = 0; i < Score.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < Score.Length; j++)
                {
                    compareCount++;

                    if (Score[j] < Score[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = Score[i];
                Score[i] = Score[minIndex];
                Score[minIndex] = temp;
            }

            return compareCount;
        }

        static int BinarySearch(int x, int[] Score)
        {
            int left = 0;
            int right = Score.Length - 1;
            int compareCount = 0;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                compareCount++;

                if (x == Score[mid])
                {
                    return compareCount;
                }
                else if (x < Score[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -compareCount;
        }

        static void PrintArray(int[] Score)
        {
            foreach (int value in Score)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}