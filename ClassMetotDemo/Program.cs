using ClassMetotDemo;
using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Hasan";
            musteri1.Id = 1;
            musteri1.LastName = "Düğünyurdu";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Elon";
            musteri2.Id = 2;
            musteri2.LastName = "Musk";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.LastName);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriListele();

        }
    }
}