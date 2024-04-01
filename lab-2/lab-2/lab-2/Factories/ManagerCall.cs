using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_2.Models;

namespace lab_2.Factories
{
    class ManagerCall
    {
        public static Subscription PurchaseSubscription(double monthlyFee, int minimumSubscriptionPeriod, List<string> channels, string subscriptionType)
        {
            switch (subscriptionType)
            {
                case "Domestic":
                    return new DomesticSubscription(monthlyFee, minimumSubscriptionPeriod, channels);
                case "Educational":
                    return new EducationalSubscription(monthlyFee, minimumSubscriptionPeriod, channels);
                case "Premium":
                    return new PremiumSubscription(monthlyFee, minimumSubscriptionPeriod, channels);
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }
}
