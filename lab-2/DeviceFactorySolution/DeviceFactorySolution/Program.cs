namespace DeviceFactorySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] brands = { "IProne", "Kiaomi", "Balaxy" };

            foreach (var brand in brands)
            {
                IDeviceFactory factory = DeviceFactoryProducer.GetFactory(brand);
                IDevice device = factory.CreateDevice();
                Console.WriteLine(device.GetInfo());
            }
        }
    }
}
