using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1023;
            musteri1.Ad = "Salih";
            musteri1.Soyad = "Kaya";
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1234;
            musteri2.Ad = "Beren";
            musteri2.Soyad = "Kısa";
            musteri2.Cinsiyet = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1235;
            musteri3.Ad = "Deniz";
            musteri3.Soyad = "Mavi";
            musteri3.Cinsiyet = "Kadın";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("Kayıtlı Müşteriler:\n");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad +" "+ musteri.Soyad);
            }

            Console.WriteLine("\n**************************************\n");


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteri3);

        }
    }
}
