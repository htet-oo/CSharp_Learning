namespace _1C30JT_WaiYan_kadai_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal shincho, taiju;
            decimal bmi, shinchoToMeter;
            Console.Write("身長は : ");
            shincho = decimal.Parse(Console.ReadLine());
            Console.Write("体調 : ");
            taiju = decimal.Parse(Console.ReadLine());
            shinchoToMeter = shincho / (decimal)100;
            bmi = taiju / (shinchoToMeter * shinchoToMeter);
            Console.WriteLine($"BMIの結果は : {Math.Round(bmi, 2)}");
        }
    }
}
