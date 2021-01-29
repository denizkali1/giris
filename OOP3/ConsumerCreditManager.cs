using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerCreditManager : ICreditManager
    {
        public void Anything()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Consumer credit payment plan prepared.");
        }
    }
}
