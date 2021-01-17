using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id=1;
            musteri1.Adi = "Musa";
            musteri1.Soyadi = "Bulbul";
            musteri1.Telefon = "05424789632";
            musteri1.Adres = "Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Murat";
            musteri2.Soyadi = "Kasap";
            musteri2.Telefon = "05553254748";
            musteri2.Adres = "Mardin";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Hatice";
            musteri3.Soyadi = "Zabun";
            musteri3.Telefon = "05412136987";
            musteri3.Adres = "Kütahya";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);

            Console.ReadKey();
        }
    }
}
