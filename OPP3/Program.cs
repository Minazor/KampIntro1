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
            LoggerService FS = new FileLoggerService();
            LoggerService DS = new DataBaseLoggerService();

            ApplicationManager appM = new ApplicationManager();
            appM.toApply(FCM, new List<LoggerService> {FS,DS });

            List<CreditManager> credits = new List<CreditManager>() {FCM,TCM};

            appM.preNotification(credits);
        }
    }
}
