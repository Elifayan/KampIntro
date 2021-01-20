using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //// type safety- tip güvenliği
            /// Do not repeat yourself- Kendini tekrarlama
            /// Değer tutucu, alias(takma ad)

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            /////örnek
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı a yarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
