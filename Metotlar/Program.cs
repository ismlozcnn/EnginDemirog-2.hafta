using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Id = 2;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("------Metotlar---------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 15,9);
            sepetManager.Ekle2("Elma", "Yeşil ekma", 13,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 35,3);

            Console.ReadKey();
        }
    }


}


//Do not Repeat Yourselff!  --  DRY  --  Clean Code   -- Best Practice
