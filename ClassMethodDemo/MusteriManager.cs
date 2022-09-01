using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteriler)
        {
            Console.WriteLine(" ( " + musteriler.Ad + " " + musteriler.Soyad + " / " + musteriler.Id + ")");
            Console.WriteLine("Müşteri Siteye Eklendi!");
        }

        public void Delete(Musteri musteriler)
        {
            Console.WriteLine(" ( " + musteriler.Ad + " " + musteriler.Soyad + " / " + musteriler.Id + ")");
            Console.WriteLine("Müşteri Siteden Silindi!");
        }

        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("(" + musteri.Ad + " " + musteri.Soyad + " / " + musteri.Id + ")");
            }
            Console.WriteLine("Tüm Müşteriler Listelenmiştir!");
        }
    }
}
