﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void Add(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.TCNo + " " + musteri.Ad + " " + musteri.Soyad + " " + "eklendi..");
        }

        public void List()
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " : " + musteri.TCNo + " " + musteri.Ad + " " + musteri.Soyad);
            }
        }

        public void Delete(Musteri musteri)
        {
            musteriler.Remove(musteri);
        }

    }
}
