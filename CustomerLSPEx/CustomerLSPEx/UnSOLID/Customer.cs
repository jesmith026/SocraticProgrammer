using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLSPEx.UnSOLID
{
    public class Customer
    {
        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        public virtual void AddLoyaltyPoints(int points)
        {
            Console.WriteLine($"Adding {points} points to Customer's loyalty account");
        }
    }

    public class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            var total = base.GetDiscount(totalSales);

            return total - (total * .25); //25% off
        }

        public override void AddLoyaltyPoints(int points)
        {
            Console.WriteLine($"Adding {points} points to Silver Customer's loyalty account");
        }
    }

    public class GoldCustomer : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            var total = base.GetDiscount(totalSales);

            return total - (total * .5); //50% off
        }

        public override void AddLoyaltyPoints(int points)
        {
            Console.WriteLine($"Adding {points} points to Gold Customer's loyalty account");
        }
    }

    public class Lead : Customer
    {
        public override double GetDiscount(double totalSales)
        {
            var total = base.GetDiscount(totalSales);

            return total - (total * .1); //10% off
        }

        public override void AddLoyaltyPoints(int points)
        {
            throw new Exception("Illegal Operation. Leads have no loyalty account");
        }
    }
}
