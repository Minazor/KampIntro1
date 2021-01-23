using OPP3;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void toApply(CreditManager cm, List<LoggerService> loggerServices)
        {

            cm.Calculate();
            foreach (var log in loggerServices)
            {
                log.Log();
            }
        }
            public void preNotification(List<CreditManager> creditList)
            {
                foreach (var c in creditList)
                {
                    c.Calculate();
                }
            }

        }
    }
