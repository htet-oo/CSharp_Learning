// お釣りの金種計算
using ConsoleKinshu;

int pay, sum;

Console.Write("請求金額> ");
sum = int.Parse(Console.ReadLine()!);

Console.Write("支払金額> ");
pay = int.Parse(Console.ReadLine()!);

int money, cnt;
Calc calc = new Calc();
money = calc.changes(pay,sum);

Console.WriteLine("お釣り　:" + money.ToString());
Console.WriteLine("万円札　　:　" + calc.forTenThousand(money));
Console.WriteLine("五千円札　:　" + calc.forFiveThousand());
Console.WriteLine("千円札　　:　" + calc.forOneThousand());
Console.WriteLine("五百円玉　:　" + calc.forFiveHundred());
Console.WriteLine("百円玉　　:　" + calc.forOneHundred());
Console.WriteLine("五十円玉　:　" + calc.forFifty());
Console.WriteLine("十円玉　　:　" + calc.forTen());
Console.WriteLine("五円玉　　:　" + calc.forFive());
Console.WriteLine("一円玉　　:　" + calc.forOne());
