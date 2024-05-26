using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.ForTest
{
  
    public interface IValidator
    {
        bool Validate(string value, string valueToCompare);
    }

    public class WordValidator : IValidator
    {
        public bool Validate(string value, string valueToCompare)
        {
            if (value == null || valueToCompare == null)
                throw new ArgumentNullException("Value and valueToCompare cannot be null");

            return value.Equals(valueToCompare, StringComparison.OrdinalIgnoreCase);
        }
    }
}
