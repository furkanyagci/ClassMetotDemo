using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TCNo = "12345678901";
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TCNo = "09876543210";
            musteri2.Ad = "Kerem";
            musteri2.Soyad = "Boğankurt";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TCNo = "98783567895";
            musteri3.Ad = "Demir";
            musteri3.Soyad = "Doğramacı";

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.List();
            Console.WriteLine("------------------------");
            musteriManager.Delete(musteri2);
            musteriManager.List();



            Console.WriteLine("Hello World!");
        }
    }
}
