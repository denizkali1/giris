using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " eklendi.\n");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " silindi.\n");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgisi:\n");
            Console.WriteLine("Müşteri adı: " + musteri.Ad);
            Console.WriteLine("Müşteri soyadı: " + musteri.Soyad);
            Console.WriteLine("Müşteri TC: " + musteri.Id);
            Console.WriteLine("Müşteri cinsiyeti: " + musteri.Cinsiyet);
            Console.WriteLine();

            
        }

    }
}
