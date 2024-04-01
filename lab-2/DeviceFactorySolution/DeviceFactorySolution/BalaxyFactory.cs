using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            return new EBook("Balaxy EBook");
        }
    }

}
