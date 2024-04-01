using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            return new Smartphone("Kiaomi Smartphone");
        }
    }

}
