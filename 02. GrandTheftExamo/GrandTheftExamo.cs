namespace _02.GrandTheftExamo
{
    using System;

    public class GrandTheftExamo
    {
        static void Main()
        {
            byte number = byte.Parse(Console.ReadLine());
            long[] intArr = new long[number * 2];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = long.Parse(Console.ReadLine());
            }

            long thievesSlapped = 0;
            long thievesEscaped = 0;
            long sumOfBottles = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (intArr[i] > 5)
                    {
                        thievesSlapped += 5;
                        thievesEscaped += intArr[i] - 5;
                    }
                    else
                    {
                        thievesSlapped += intArr[i];
                    }
                }
                else
                {
                    sumOfBottles += intArr[i];
                }
            }

            long packs;
            long bottles;

            if (sumOfBottles % 6 == 0)
            {
                packs = sumOfBottles / 6;
                bottles = 0;
            }
            else
            {
                packs = sumOfBottles / 6;
                bottles = sumOfBottles - (packs * 6);
            }

            Console.WriteLine("{0} thieves slapped.", thievesSlapped);
            Console.WriteLine("{0} thieves escaped.", thievesEscaped);
            Console.WriteLine("{0} packs, {1} bottles.", packs, bottles);
        }
    }
}

