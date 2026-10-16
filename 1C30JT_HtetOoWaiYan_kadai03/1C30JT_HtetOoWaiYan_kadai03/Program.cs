namespace _1C30JT_HtetOoWaiYan_kadai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {90,70,60,50,20,80,10,30,40 };
            int biggest = intArray.Max();
            int smallest = intArray.Min();
            Console.WriteLine($"「配列array : {{{string.Join(" ", intArray)}}}」");
            Console.WriteLine($"「配列arrayの最大値は{biggest} : {Array.IndexOf(intArray,biggest)}番です。」");
            Console.WriteLine($"「配列arrayの最小値は{smallest} : {Array.IndexOf(intArray,smallest)}番です。」");

        }
    }
}
