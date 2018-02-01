using System;
using System.Collections.Generic;
using unsolid = CustomerLSPEx.UnSOLID;
using solid = CustomerLSPEx.SOLID;

namespace CustomerLSPEx
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSOLIDExample();
        }

        private static void RunUnSOLIDExample()
        {
            var customers = new List<unsolid.Customer>
            {
                new unsolid.Customer(),
                new unsolid.SilverCustomer(),
                new unsolid.GoldCustomer(),
                new unsolid.Lead()
            };

            foreach (var customer in customers)
            {
                customer.AddLoyaltyPoints(1);
            }
        }

        private static void RunSOLIDExample()
        {
            var loyaltyCustomers = new List<solid.IHasLoyalty>()
            {
                new solid.Customer(),
                new solid.SilverCustomer(),
                new solid.GoldCustomer(),
            };

            var discountCustomers = new List<solid.IHasDiscount>()
            {
                new solid.Customer(),
                new solid.SilverCustomer(),
                new solid.GoldCustomer(),
                new solid.Lead()
            };

            foreach (var loyalCustomer in loyaltyCustomers)
            {
                loyalCustomer.AddLoyaltyPoints(1);
            }

            foreach (var discountCustomer in discountCustomers)
            {
                Console.WriteLine($"Discounted price for member level " +
                                  $"'{discountCustomer.GetType().Name}' is " +
                                  $"${discountCustomer.GetDiscount(100.50):N2}");
            }
        }
    }
}
