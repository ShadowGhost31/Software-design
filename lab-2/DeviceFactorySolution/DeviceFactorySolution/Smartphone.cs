using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public class Smartphone : IDevice
    {
        private string modelName;

        public Smartphone(string modelName)
        {
            this.modelName = modelName;
        }

        public string GetInfo()
        {
            return $"Smartphone: {modelName}";
        }
    }

}
