using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyat = 15;
            string aciklama = "amasya elmasi";

            string[] meyveler = new string[] { "elma","karpuz"};

            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

                
            }
            Console.WriteLine("----------metotlar----------");
                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yeşil armut",12,3);
            sepetManager.Ekle2("elma","kırmızı elma",10,2);
            sepetManager.Ekle2("karpuz","siyarbakır karpuzu",20,1);


        }
    }
}
