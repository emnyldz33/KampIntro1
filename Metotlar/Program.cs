using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            URUN urun1  = new URUN();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            URUN urun2 = new URUN();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            URUN[] urunler = new URUN[]
            {
                urun1, urun2
            };

            foreach (URUN urun  in urunler)
            {
                Console.WriteLine(urun.Adi + " --  " + urun.Fiyati + " -- " + urun.Aciklama);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }


            Console.WriteLine("-----------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 14);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12 , 45);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 15);


        }
    }
}
