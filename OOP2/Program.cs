﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1; 
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.TcNo = "12345678910";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "123456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "0123456789";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);


            // Gerçek Müşteri - Tüzel Müşteri (Şirket) (Her ikiside müşteri, fakat birbirileri yerine kullanılamaz.)
            // SOLID  - > Yazılım geliştirme prensiplerinden 'L' harfi bunu kuralı ifade ediyor.
        }
    }
}
