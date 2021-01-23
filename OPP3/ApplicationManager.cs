using OPP3;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void toApply(CreditManager cm) {

            cm.Calculate();
        }

        public void preNotification(List<CreditManager> creditList)
        {
            foreach(var c in creditList)
            {
                c.Calculate();
            } 
        }
        
    }
}
