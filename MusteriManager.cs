using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi +" "+musteri.Soyadi+" basarılı bir sekilde eklendi.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " basarılı bir sekilde silindi.");
        }

        public void Listele(Musteri[] musteri)
        { 
            foreach(var mus in musteri )
            {
                Console.WriteLine(mus.Id+"-"+mus.Adi+" "+mus.Soyadi+" "+mus.Telefon+" "+mus.Adres);
            }
        }
    }
}
