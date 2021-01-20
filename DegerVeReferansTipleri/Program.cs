using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1+" "+sayi2);


            if (!"a".Equals("b")){
                Console.WriteLine("Ayn");
            }

        }
    }
}
