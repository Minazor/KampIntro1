using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun elma = new Urun();
            elma.Adi = "Elma";
            elma.Fiyati = 10;
            elma.Aciklama = "Amasya Elması";

            Urun armut = new Urun();
            armut.Adi = "Armut";
            armut.Fiyati = 15;
            armut.Aciklama = "Çankırı Armutu";

            Urun[] urunler = {elma,armut};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");

            }

            Console.WriteLine("---------METOTLAR---------");

            //instance - örnek
            SepetManager sepet = new SepetManager();
            sepet.Ekle(elma);
            sepet.Ekle(armut);

            sepet.Ekle2("Armut", "Çankırı armutu", 15);
        }
    }
}
