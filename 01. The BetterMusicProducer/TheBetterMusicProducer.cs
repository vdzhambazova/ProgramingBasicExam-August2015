namespace _01.The_BetterMusicProducer
{
    using System;

    public class TheBetterMusicProducer
    {
        static void Main()
        {
            int albumsInEurope = int.Parse(Console.ReadLine());
            decimal priceInEuro = decimal.Parse(Console.ReadLine());

            int albumsInNorthAmerica = int.Parse(Console.ReadLine());
            decimal priceInDolars = decimal.Parse(Console.ReadLine());

            int albumsInSouthAmerica = int.Parse(Console.ReadLine());
            decimal priceInPesos = decimal.Parse(Console.ReadLine());

            int concertsPerTour = int.Parse(Console.ReadLine());
            decimal profitFromConcEuro = decimal.Parse(Console.ReadLine());

            decimal profitInEurope = albumsInEurope * priceInEuro * 1.94m;
            decimal profitInNorthAmerica = albumsInNorthAmerica * priceInDolars * 1.72m;
            decimal profitInSouthAmerica = albumsInSouthAmerica * priceInPesos / 332.74m;
            decimal profitFromAlbums = (((profitInEurope + profitInSouthAmerica + profitInNorthAmerica) * 0.65m) * 0.8m);
            decimal profitFromConcerts = (concertsPerTour * profitFromConcEuro * 1.94m);
            if (profitFromConcerts > 100000)
            {
                profitFromConcerts = profitFromConcerts * 0.85m;
            }

            bool profitFromAlbumsIsBigger = (profitFromAlbums > profitFromConcerts);

            if (profitFromAlbumsIsBigger)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", profitFromAlbums);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", profitFromConcerts);
            }

        }
    }
}

