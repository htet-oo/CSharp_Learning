namespace _1C30JT_WaiYan_Kadai_4_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numOfPeople;
            int numOfPeopleToInt;
            string budget;
            float bugetToFloat;

            Console.Write("予算を整数で入力してください : ");
            budget = Console.ReadLine();
            if (float.TryParse(budget, out bugetToFloat))
            {
                bugetToFloat = bugetToFloat;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            Console.Write("参加人数を整数で入力してください : ");
            numOfPeople = Console.ReadLine();
            if (int.TryParse(numOfPeople, out numOfPeopleToInt))
            {
                numOfPeopleToInt = numOfPeopleToInt;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            int pizzaThreeTol = 0;
            int count = 0;
            for (int i = 0; i < numOfPeopleToInt; i++)
            {
                for (int j = 0; j < numOfPeopleToInt - i; j++)
                {
                    pizzaThreeTol = numOfPeopleToInt - i - j;
                    if ((i * 800 + j * 1100 + pizzaThreeTol * 1200) == bugetToFloat)
                    {
                        Console.WriteLine($"マルゲリータ{i}枚, デリシャスミート{j}枚, シーフードスペシャル{pizzaThreeTol}");
                        ++count;
                    }

                }
            }
            if (count <= 0)
            {
                Console.WriteLine("予算を使い切る組み合わせがありませんでした。");
            }
        }
    }
}
