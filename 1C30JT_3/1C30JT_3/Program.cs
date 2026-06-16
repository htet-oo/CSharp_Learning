namespace _1C30JT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            int cnt, WeekNo;
            int DaysCnt = 0;
            int LeapCnt = 0;
            int[] Days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            char[] Week = new char[] {'月', '火', '水', '木', '金', '土', '日'};
            Console.Write("年を入力 : ");
            year = int.Parse(Console.ReadLine());
            Console.Write("月を入力 : ");
            month = int.Parse(Console.ReadLine());
            Console.Write("日を入力 : ");
            day = int.Parse(Console.ReadLine());

            for(int i = 1980; i < year; i++)
            {
                if(i % 400 == 0)
                {
                    LeapCnt = LeapCnt + 1;
                }
            }

            DaysCnt = (year - 1980) * 365 + LeapCnt;

            for (int i = 0; i < month; i++)
            {
                DaysCnt = DaysCnt + Days[i];
                if (year % 400 == 0)
                {
                    if (Days[i] == 28)
                    {
                        DaysCnt = DaysCnt + 1;
                    }
                }
            }

            DaysCnt = DaysCnt + day;
            WeekNo = DaysCnt % 7;
            Console.WriteLine(Week[WeekNo + 1]);
        }
    }
}
