﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager

    
    {
        public void Ekle(URUN urun) 
        { 
        Console.WriteLine("Tebrikler. Sepete eklendi!" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi) 
        {
            Console.WriteLine( "Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
