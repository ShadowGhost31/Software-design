using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Models
{


    // Реалізація класу підписки для внутрішнього використання
    class DomesticSubscription : Subscription
    {
        public DomesticSubscription(double monthlyFee, int minimumSubscriptionPeriod, List<string> channels) : base(monthlyFee, minimumSubscriptionPeriod, channels)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Domestic Subscription Details:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}$");
            Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} months");
            Console.WriteLine("Channels:");
            foreach (var channel in Channels)
            {
                Console.WriteLine(channel);
            }
        }
    }

}
