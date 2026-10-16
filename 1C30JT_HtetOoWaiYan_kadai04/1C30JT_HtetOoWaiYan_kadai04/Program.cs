namespace _1C30JT_HtetOoWaiYan_kadai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("面積計算をします。");
            Console.WriteLine("四角形と三角形のどちらの面積を求めますか。");
            bool flat = true;
            int userInputNumber = 0;
            while (flat)
            {
                Console.Write("四角形 : 1,三角形 : 2");
                userInputNumber = int.Parse(Console.ReadLine());
                if (userInputNumber == 1 || userInputNumber == 2)
                {
                    flat = false;
                }
                else
                {
                    Console.WriteLine("---error:1か2以外の数値が入力されました");
                }
            }
            if (userInputNumber ==1)
            {
                Console.WriteLine("縦の長さを入力してください　：　");
                double vertical = double.Parse(Console.ReadLine());
                Console.WriteLine("横の長さを入力してください　：　");
                double horizontal = double.Parse(Console.ReadLine());
                Console.WriteLine($"縦{vertical}m 横{horizontal}m の面積は{vertical * horizontal}m²です。");
            }
            else
            {

                Console.WriteLine("底辺の長さを入力してください　：　");
                double bottom = double.Parse(Console.ReadLine());
                Console.WriteLine("高さを入力してください　：　");
                double heigh = double.Parse(Console.ReadLine());
                Console.WriteLine($"底辺{bottom}m、高さ{heigh}mの面積は{bottom * heigh / 2}m²です。");
            }

        }
    }
}
