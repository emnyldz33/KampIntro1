using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emin";
            int yas = 28;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 36;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 28 ;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 43 ;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursunEgitmeni + " " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] 
            { 
            kurs1, kurs2, kurs3 
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmeni + " " + kurs.IzlenmeOrani);
            }



            //Console.WriteLine("Hello World!") ;
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }


    }
}
