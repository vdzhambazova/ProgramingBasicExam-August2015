using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






    class TheBetterMusicProducer
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

        decimal ProfitInEurope = albumsInEurope * priceInEuro * 1.94m;
        decimal ProfitInNorthAmerica = albumsInNorthAmerica * priceInDolars * 1.72m;
        decimal ProfitInSouthAmerica = albumsInSouthAmerica * priceInPesos / 332.74m;

        decimal ProfitFromAlbums = (((ProfitInEurope+ProfitInSouthAmerica+ProfitInNorthAmerica) *0.65m)*0.8m);
        

        decimal ProfitFromConcerts = (concertsPerTour * profitFromConcEuro * 1.94m);

        if (ProfitFromConcerts > 100000)
        {
            ProfitFromConcerts = ProfitFromConcerts * 0.85m;
        }

        bool ProfitFromAlbumsIsBigger = (ProfitFromAlbums > ProfitFromConcerts);

        if (ProfitFromAlbumsIsBigger)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", ProfitFromAlbums);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", ProfitFromConcerts);
        }


    }
    }

