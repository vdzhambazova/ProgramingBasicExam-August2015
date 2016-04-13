namespace _04.Firefighters
{
    using System;

    public class Firefighters
    {
        static void Main()
        {
            int f = int.Parse(Console.ReadLine());
            int kidsCount = 0;
            int adultsCount = 0;
            int seniorsCount = 0;

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "rain")
                {
                    break;
                }

                char[] charArray = inputLine.ToCharArray();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray.Length <= f)
                    {
                        if (charArray[i] == 'K')
                        {
                            kidsCount += 1;
                        }
                        else if (charArray[i] == 'A')
                        {
                            adultsCount += 1;
                        }
                        else if (charArray[i] == 'S')
                        {
                            seniorsCount += 1;
                        }
                    }
                }

                int people = 0;

                if (charArray.Length > f)
                {
                    for (int j = 0; j < charArray.Length; j++)
                    {
                        if (charArray[j] == 'K')
                        {
                            people += 1;
                            if (people > f)
                            {
                                break;
                            }

                            kidsCount += 1;
                        }
                    }

                    for (int k = 0; k < charArray.Length; k++)
                    {
                        if (charArray[k] == 'A')
                        {
                            people += 1;
                            if (people > f)
                            {
                                break;
                            }

                            adultsCount += 1;
                        }
                    }

                    for (int l = 0; l < charArray.Length; l++)
                    {
                        if (charArray[l] == 'S')
                        {
                            people += 1;
                            if (people > f)
                            {
                                break;
                            }

                            seniorsCount += 1;
                        }
                    }
                }
            }

            Console.WriteLine("Kids: {0}", kidsCount);
            Console.WriteLine("Adults: {0}", adultsCount);
            Console.WriteLine("Seniors: {0}", seniorsCount);
        }
    }
}




