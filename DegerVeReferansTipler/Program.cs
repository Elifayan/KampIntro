using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            ////int,decimal,float,bool,double=değer tipi--sayısal görüntüde olanlar
            ///array,class,interface=Referans tip
            int sayi1 = 10;
            int sayi2 = 10;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?? 30
            //bellekte alan var** stack-değer tipi
            ///heap

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            ///sayilar1[0]??? 999



        }
    }
}
