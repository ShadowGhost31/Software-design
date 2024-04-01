using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public interface IDeviceFactory
    {
        IDevice CreateDevice();
    }

}
