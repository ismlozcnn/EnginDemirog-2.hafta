using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnginDemirogYazılımcıKampı
{
    class Program
    {
        static void Main(string[] args)
        {
            //DO NOT REPEAT YOURSELF - Kendini tekrarlama

            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGiris = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu göster");
            }
            else
            {
                Console.WriteLine("değişmedi butonu göster");
            }


            if (sistemGiris==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);




            Console.ReadKey();
        }
    }
}
