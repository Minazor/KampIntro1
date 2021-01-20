using System;

namespace Deneme
{
    class Program
    {
        internal static object ad;
        internal static object soyad;
        internal static object cep;
        internal static object sabitTel;
        internal static object mail;
        static void Main(string[] args)
        {
            ad = "Mina";
            soyad = "İnal";
            cep = 32674892;
            sabitTel = 32543490;
            mail = "sjkd";

            if(Sms("Mina", "İnal", 32674892, 32543490, "sjkd"))
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");

            }


        }
        static Boolean Sms(string ad, string soyad, int cep, int sabitTel, string mail)
        {

            if (Program.ad.Equals(ad) && Program.soyad.Equals(soyad) && Program.cep.Equals(cep) && Program.sabitTel.Equals(sabitTel) && Program.mail.Equals(mail))
            {
                return true;
            }

            else
            {
                 return false;
            }


        }
    }
}
