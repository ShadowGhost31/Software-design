using lab_2.Factories;

namespace lab_2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            // Приклад використання
            var channels = new List<string> { "Channel 1", "Channel 2", "Channel 3" };
            double monthlyFee = 10.99;
            int minimumSubscriptionPeriod = 6;

            // Придбання підписки через веб-сайт
            var webSubscription = WebSite.PurchaseSubscription(monthlyFee, minimumSubscriptionPeriod, channels, "Premium");
            webSubscription.DisplayDetails();

            // Придбання підписки через мобільний додаток
            var mobileSubscription = MobileApp.PurchaseSubscription(monthlyFee, minimumSubscriptionPeriod, channels, "Domestic");
            mobileSubscription.DisplayDetails();

            // Придбання підписки через дзвінок менеджеру
            var callSubscription = ManagerCall.PurchaseSubscription(monthlyFee, minimumSubscriptionPeriod, channels, "Educational");
            callSubscription.DisplayDetails();
        }
    }
}
