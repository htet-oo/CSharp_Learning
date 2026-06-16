namespace Renshu5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            foreach(int value in a)
            {
                Console.WriteLine(value);
            }
        }
    }
}
