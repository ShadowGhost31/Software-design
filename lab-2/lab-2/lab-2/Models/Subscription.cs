using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.Models
{
    internal class Subscription
    {
        public double MonthlyFee { get; protected set; }
        public int MinimumSubscriptionPeriod { get; protected set; }
        public List<string> Channels { get; protected set; }

        public Subscription(double monthlyFee, int minimumSubscriptionPeriod, List<string> channels)
        {
            MonthlyFee = monthlyFee;
            MinimumSubscriptionPeriod = minimumSubscriptionPeriod;
            Channels = channels;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Subscription Details:");
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
