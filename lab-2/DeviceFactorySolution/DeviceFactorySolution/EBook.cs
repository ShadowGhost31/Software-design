using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceFactorySolution
{
    public class EBook : IDevice
    {
        private string modelName;

        public EBook(string modelName)
        {
            this.modelName = modelName;
        }

        public string GetInfo()
        {
            return $"EBook: {modelName}";
        }
    }

}
