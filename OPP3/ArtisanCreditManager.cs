using OPP3;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanCreditManager : CreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
