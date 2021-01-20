using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
    class Class1
    {

        static Boolean Sms(string ad, string soyad, long cep, long sabitTel, string mail)
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
