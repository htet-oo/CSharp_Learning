using System.Numerics;

namespace my_renshu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arraySize;
            string arrayOne;
            string arrayTwo;

            arraySize = Console.ReadLine();
            int[] arraySizeToInt = arraySize
                .Split(' ')
                .Select(c => int.TryParse(c, out int i)? i : 0)
                .ToArray();

            arrayOne = Console.ReadLine();
            int[] arrayOneToInt = arrayOne
                .Split(' ')
                .Select(c => int.TryParse(c, out int i)? i : 0)
                .ToArray();

            arrayTwo = Console.ReadLine();
            int[] arrayTwoToInt = arrayTwo
                .Split(' ')
                .Select(c => int.TryParse(c, out int i) ? i : 0)
                .ToArray();

            for (int i = 0; i < arrayTwoToInt.Length; i++)
            {
                Console.WriteLine(arrayTwoToInt[i]);
            }

            int count = 0;

            for (int i = 0; i < arrayTwoToInt.Length; i++)
            {
                for (int j = 0; j < arrayTwoToInt[i]; j++)
                {
                    if (j < arrayTwoToInt.Length)
                    {
                        Console.Write($"{arrayOneToInt[count]} ");
                        count++;
                    }
                    else
                    {
                        Console.Write($"{arrayOneToInt[count]}");
                        count++;
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
