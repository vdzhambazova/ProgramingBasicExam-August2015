using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GrandTheftExamo
    {
        static void Main()
        {
        byte N = byte.Parse(Console.ReadLine());

        long[] intArr = new long[N * 2];

        for(int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = long.Parse(Console.ReadLine());
        }

        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long sumOfBottles = 0;
        

        for (int i = 0; i<intArr.Length; i++)
        {
            if(i%2 == 0)
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

        long packs = 0;
        long bottles = 0;

        if (sumOfBottles % 6 == 0)
        {
            packs = sumOfBottles / 6;
            bottles = 0;
        }
        else
        {
            packs = sumOfBottles / 6;
            bottles = sumOfBottles -(packs*6);
        }
        

        Console.WriteLine("{0} thieves slapped.", thievesSlapped);
        Console.WriteLine("{0} thieves escaped.", thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", packs, bottles);

        }
}

