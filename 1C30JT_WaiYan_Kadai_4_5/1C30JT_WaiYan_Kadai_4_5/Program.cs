namespace _1C30JT_WaiYan_Kadai_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputOne;
            string inputTwo;
            int inputOneToInt;
            int inputTwoToInt;
            int inputForVerTo, inputForHorTo;

            Console.Write("一辺(その1) :");
            inputOne = Console.ReadLine();
            if (int.TryParse(inputOne, out inputOneToInt))
            {
                inputOneToInt = inputOneToInt;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }

            Console.Write("一辺(その2) :");
            inputTwo = Console.ReadLine();
            if (int.TryParse(inputTwo, out inputTwoToInt))
            {
                inputTwoToInt = inputTwoToInt;
            }
            else
            {
                Console.WriteLine("数字を代入してください。");
            }



            if (inputOneToInt < inputTwoToInt)
            {
                inputForHorTo = inputTwoToInt;
                inputForVerTo = inputOneToInt;
            }
            else
            {
                inputForHorTo = inputOneToInt;
                inputForVerTo = inputTwoToInt;

            }

            Console.WriteLine("one" + inputForVerTo);
            Console.WriteLine("two" + inputForHorTo);

            int i = 0, j = 0;
            while (i < inputForVerTo) 
            {
                while (j < inputForHorTo) 
                {
                    Console.Write("*");
                    j = j + 1;
                }
                Console.WriteLine();
                i = i + 1;
                j = 0;
            }
        }
    }
}
