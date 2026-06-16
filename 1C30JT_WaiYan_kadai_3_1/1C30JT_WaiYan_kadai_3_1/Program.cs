namespace _1C30JT_WaiYan_kadai_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float itemWeight;
            int areaCode;
            string isMemberOrNot;
            float totalCost = 0;
            float promotion = 0;
            Console.Write("配達物の重さを代入してください : ");
            if (float.TryParse(Console.ReadLine(), out itemWeight))
            {
                if ((itemWeight >= 25) || (itemWeight <= 0))
                {
                    Console.WriteLine(itemWeight >=25 
                        ? $"{itemWeight} 以上の荷物は取り扱い出来ません。"
                        : "正しい重量を代入してください。");
                    return;
                }
                else if ((itemWeight >= 15) && (itemWeight < 25))
                {
                    totalCost += 2000;
                }
                else if ((itemWeight >= 5) && (itemWeight < 15))
                {
                    totalCost += 1000;
                }
                else
                {
                    totalCost += 500;
                }

            }
            else
            {
                Console.WriteLine("実数型を代入してください。");
            }

            Console.Write("配達地域コートを代入してください : ");
            if (int.TryParse(Console.ReadLine(), out areaCode))
            {
                if (areaCode == 1)
                {
                    totalCost += 0;
                }
                else if (areaCode == 2)
                {
                    totalCost += 400;
                }
                else if (areaCode == 3)
                {
                    totalCost += 1000;
                }
                else
                {
                    Console.WriteLine("配達地域コード1から3まで入力してください。");
                    return;
                }
            }
            else
            {
                Console.WriteLine("整数型を代入してください。");
                return;
            }

            Console.Write("会員ですか?y/n:");
            isMemberOrNot = Console.ReadLine();
            bool isMemberOrNotToBool = isMemberOrNot switch
            {
                "yes" => true,
                "y" => true,
                "Y" => true,
                "true" => true,
                "0" => true,

                "no" => false,
                "n" => false,
                "N" => false,
                "false" => false,
                "1" => false,

                _=> throw new Exception("yかnを入力してください。")

            };

            if (isMemberOrNotToBool == true)
            {
                if (totalCost >= 1500)
                {
                    promotion = (totalCost * 10) / 100;
                    totalCost = totalCost - promotion;
                }
            }

            Console.WriteLine($"宅配便の料金 : {totalCost}");



        }
    }
}
