using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Yıldırım";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 20;
            musteri2.Ad = "Sevim";
            musteri2.Soyad = "Bal";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 30;
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Güneş";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);

            Console.WriteLine("--------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.List(musteriler);
        }
    }
}

