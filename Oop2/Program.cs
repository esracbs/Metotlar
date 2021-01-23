using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //esra cabas
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "esra";
            musteri1.Soyadi = "cabas";
            musteri1.TcNo = "12345678910";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek nesne - Tüzel nesne birbirinin yerine kullanılamaz
            //müşteri classı hm gerçek müşterinin hem tüzel müşterinin referansını tutabililyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri(); 
        }
    }
}
