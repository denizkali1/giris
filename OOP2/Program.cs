using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.Name = "Deniz";
            customer1.Surname = "Kalı";
            customer1.IDNumber = "12345678910";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "54321";
            customer2.Company = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer1);


        }
    }
}
