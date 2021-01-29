using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            HousingCreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            //Burada newlemek yerine;
            //aplicationManager.Apply(new ConsumerCreditManager(), new DatabaseLoggerService()); 
            //yapısını da newlemek için kullanabilirsin.

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(consumerCreditManager, new List<ILoggerService> { databaseLoggerService, smsLoggerService });
            Console.WriteLine();
            applicationManager.Apply(new ArtisanCreditManager(), new List<ILoggerService> { databaseLoggerService, new SmsLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager, vehicleCreditManager  };
            //applicationManager.GiveCreditPreNotification(credits);
            //bu yapyla da aynı anda farklı kredi hesaplarını yapabilirsin.
        }
    }
}
