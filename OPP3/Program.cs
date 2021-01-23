using System;
using System.Collections.Generic;
using OOP3;

namespace OPP3
{
    class Program
    {
        static void Main(string[] args)
        {
            FinanceCreditManager FCM = new FinanceCreditManager();
            HouseCreditManager HCM = new HouseCreditManager();
            TransportCreditManager TCM = new TransportCreditManager();

            ApplicationManager appM = new ApplicationManager();
            //appM.toApply(FCM);

            List<CreditManager> credits = new List<CreditManager>() {FCM,TCM};

            appM.preNotification(credits);
        }
    }
}
