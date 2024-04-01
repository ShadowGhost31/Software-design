using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public class Laptop : IDevice
    {
        private string modelName;

        public Laptop(string modelName)
        {
            this.modelName = modelName;
        }

        public string GetInfo()
        {
            return $"Laptop: {modelName}";
        }
    }

}
