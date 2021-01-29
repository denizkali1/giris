using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection
        public void Apply(ICreditManager creditManager, List <ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void GiveCreditPreNotification(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
