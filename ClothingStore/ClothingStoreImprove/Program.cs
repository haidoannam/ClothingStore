using ClothingStoreImprove.Factory;
using ClothingStoreImprove.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothingStoreImprove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // support new kinds of clothing other
            IList<Clothing> clothingOfVendor = new List<Clothing>();
            ClothingFactory tShirtfactory = new TShirtFactory(new List<string> { "Red", "Color" }, new List<string> { "1", "2" }, 6);
            clothingOfVendor.Add(tShirtfactory.GetClothing());

            // support ordering from different suppliers?
            IList<Clothing> clothingOfVendor1 = new List<Clothing>();
            ClothingFactory tShirtfactoryVendor1 = new TShirtFactory(new List<string> { "Red", "Color" }, new List<string> { "1", "2" }, 6);
            clothingOfVendor1.Add(tShirtfactoryVendor1.GetClothing());
            IList<Clothing> clothingOfCustomer = new List<Clothing>();
            
            foreach(var itemVendor in clothingOfVendor)
            {
                clothingOfCustomer.Add(itemVendor);
            }

            foreach (var itemVendor in clothingOfVendor1)
            {
                clothingOfCustomer.Add(itemVendor);
            }

            // What other parts of the app might need to scale?
            // 1. Get total price of vendor and customer
            var totalPriceVendor = clothingOfVendor.Select(x => x.Price).Sum();
            var totalPriceCustomer = clothingOfCustomer.Select(x => x.Price).Sum();
            
            // 2. Check count of vendor and customer 
            // 3. Check item of vendor and customer are exist

        }
    }
}
