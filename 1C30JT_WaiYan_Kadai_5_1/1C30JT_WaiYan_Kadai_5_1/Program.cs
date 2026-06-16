using System;

namespace _1C30JT_WaiYan_Kadai_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numOfPeople;
            int numOfPeopleToInt;
            Console.Write("人数を入力してください　: ");
            numOfPeople = Console.ReadLine();
            if (int.TryParse(numOfPeople, out numOfPeopleToInt))
            {
                Console.WriteLine($"{numOfPeopleToInt} 人の点数を入力せよ。");
                int[] markArray = new int[numOfPeopleToInt];
                for (int i = 0; i < numOfPeopleToInt; i++)
                {
                    string value;
                    int valueToInt;
                    Console.Write($"{i+1} : ");
                    value = Console.ReadLine();
                    if (int.TryParse(value, out valueToInt))
                    {
                        markArray[i] = valueToInt;
                    }
                    else
                    {
                        Console.WriteLine("数字を代入してください。");
                    }
                }

                string[] labels = new string[11];

                for (int i = 0; i < labels.Length; i++)
                {
                    int start = i * 10;

                    if (start == 100)
                    {
                        labels[i] = "   ^100";
                        Console.WriteLine(labels[i]);
                    }
                    else
                    {
                        if(start == 0)
                        {
                            labels[i] = $" {start} ~ {start + 9} ";
                            Console.WriteLine(labels[i]);
                        }
                        else
                        {
                            labels[i] = $"{start} ~ {start + 9}";
                            Console.WriteLine(labels[i]);
                        }
                    }
                }

                int[] count = new int[11];

                foreach (int num in markArray)
                {
                    int key;
                    if (num == 100)
                    {
                        key = 10;
                    }
                    else
                    {
                        key = num / 10;
                    }
                    count[key]++;

                }

                Console.WriteLine("---分布グラフ---");

                for (int i = 0;i < labels.Length; i++)
                {
                    Console.Write(labels[i] + " : ");
                    for(int j = 0; j < count[i]; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }


        }
    }
}
