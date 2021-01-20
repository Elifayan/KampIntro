using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            //parametreler değişken olur.
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(6, 9);
        } 
    }
}
