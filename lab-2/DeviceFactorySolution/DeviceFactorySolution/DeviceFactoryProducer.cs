using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public class DeviceFactoryProducer
    {
        public static IDeviceFactory GetFactory(string brand)
        {
            switch (brand.ToLower())
            {
                case "iprone":
                    return new IProneFactory();
                case "kiaomi":
                    return new KiaomiFactory();
                case "balaxy":
                    return new BalaxyFactory();
                default:
                    throw new ArgumentException("Unknown brand");
            }
        }
    }
}
