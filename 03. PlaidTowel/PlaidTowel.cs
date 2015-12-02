using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PlaidTowel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char rh = char.Parse(Console.ReadLine());

        //Top

        string top =
            new string(b, n) + rh +
            new string(b, n * 2 - 1) + rh +
            new string(b, n);

        Console.WriteLine(top);

        //MiddleTop
        int outerHyphens = n - 1;
        int innerHyphens = 1;

        for (int i = 0; i < n - 1; i++)
        {

            string topMiddle =
                new string(b, outerHyphens) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens*2-1) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens);

            Console.WriteLine(topMiddle);
            innerHyphens += 2;
            outerHyphens -= 1;

        }

        //Middle

        string middle =
            rh +
            new string(b, innerHyphens) + rh +
            new string(b, innerHyphens) + rh;

        Console.WriteLine(middle);
        //MiddleBottom
        outerHyphens += 1;
        innerHyphens -= 2;
        for (int i = 0; i < n - 1; i++)
        {
            string topBottom =
                new string(b, outerHyphens) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens*2-1) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens);

            Console.WriteLine(topBottom);
            outerHyphens += 1;
            innerHyphens -= 2;
        }

        //Top

        top =
            new string(b, n) + rh +
            new string(b, n * 2 - 1) + rh +
            new string(b, n);

        Console.WriteLine(top);

        //MiddleTop
        outerHyphens = n - 1;
        innerHyphens = 1;

        for (int i = 0; i < n - 1; i++)
        {

            string topMiddle =
                new string(b, outerHyphens) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens * 2 - 1) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens);

            Console.WriteLine(topMiddle);
            innerHyphens += 2;
            outerHyphens -= 1;

        }

        //Middle

        middle =
            rh +
            new string(b, innerHyphens) + rh +
            new string(b, innerHyphens) + rh;

        Console.WriteLine(middle);
        //MiddleBottom
        outerHyphens += 1;
        innerHyphens -= 2;
        for (int i = 0; i < n - 1; i++)
        {
            string topBottom =
                new string(b, outerHyphens) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens * 2 - 1) + rh +
                new string(b, innerHyphens) + rh +
                new string(b, outerHyphens);

            Console.WriteLine(topBottom);
            outerHyphens += 1;
            innerHyphens -= 2;
        }

        //Bottom

        Console.WriteLine(top);

    }
}

