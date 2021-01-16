using System;

namespace Donguler0
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // array = dizi

            String[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Proglamaya başlangıç için temel kurs", "Java" , "python" , "C#" };


            for (int i = 0 ; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("SAYFA SONU - footer");
        }
    }
}
