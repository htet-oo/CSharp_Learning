using System;
using System.Linq;

namespace _1C30JT_HTETOOWAIYAN_Poker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("ポーカーの役判定をします");
            Console.Write("カードをカンマ区切りで入力してください：");

            string[] cards = Console.ReadLine().Split(',');

            string hands = CardToHands(cards);
            Console.WriteLine(hands);

            int CountCards(string[] strings)
            {
                int count = 0;

                for (int i = 0; i < strings.Length; i++)
                {
                    for (int j = 0; j < strings.Length; j++)
                    {
                        if (strings[i] == strings[j])
                        {
                            count++;
                        }
                    }
                }

                return count;
            }

            int[] Order(string[] ranks)
            {
                int[] ordered = RankToNumbers(ranks);

                for (int i = 0; i < ordered.Length - 1; i++)
                {
                    int min = i;

                    for (int j = i + 1; j < ordered.Length; j++)
                    {
                        if (ordered[j] < ordered[min])
                        {
                            min = j;
                        }
                    }

                    int temp = ordered[i];
                    ordered[i] = ordered[min];
                    ordered[min] = temp;
                }

                return ordered;
            }

            string CardToHands(string[] cards)
            {
                string[] ranks = GetRanks(cards);

                return CountCards(ranks) switch
                {
                    17 => "フォーカード",
                    13 => "フルハウス",
                    11 => "スリーカード",
                    9 => "ツーペア",
                    7 => "ワンペア",
                    5 => GetNoPairHands(GetSuits(cards), ranks),
                    _ => throw new ArgumentException()
                };
            }

            string[] GetSuits(string[] cards)
            {
                return cards.Select(x => x.Substring(0, 1)).ToArray();
            }

            string[] GetRanks(string[] cards)
            {
                return cards.Select(x => x.Substring(1)).ToArray();
            }

            int[] RankToNumbers(string[] ranks)
            {
                return ranks.Select(x => x switch
                {
                    "A" => 1,
                    "J" => 11,
                    "Q" => 12,
                    "K" => 13,
                    _ => int.Parse(x)
                }).ToArray();
            }

            string GetNoPairHands(string[] suits, string[] ranks)
            {
                int[] ordered = Order(ranks);

                if (ordered[0] == 1 && ordered[1] == 10)
                {
                    if (CountCards(suits) == 25)
                    {
                        return "ロイヤルストレートフラッシュ";
                    }
                    else
                    {
                        return "ストレート";
                    }
                }
                else if (ordered[4] - ordered[0] == 4)
                {
                    if (CountCards(suits) == 25)
                    {
                        return "ストレートフラッシュ";
                    }
                    else
                    {
                        return "ストレート";
                    }
                }
                else if (CountCards(suits) == 25)
                {
                    return "フラッシュ";
                }
                else
                {
                    return "ノーペア";
                }
            }
        }
    }
}
