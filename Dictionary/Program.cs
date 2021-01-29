using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Most Popular Brands\n");
            //It has nothing to do with the facts.

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Apple", "Phone");
            myDictionary.Add("Toyota", "Car");
            myDictionary.Add("MSI", "Computer");
            myDictionary.Add("Bosh", "Refrigator");
            myDictionary.Add("Diesel", "Watch");
            myDictionary.Add("JBL", "Headphone");

            myDictionary.List();

        }
    }
}
