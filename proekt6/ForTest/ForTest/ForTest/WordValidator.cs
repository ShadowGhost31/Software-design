using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.ForTest
{
    // Factory Method pattern
    public class WordValidatorFactory
    {
        public static IValidator CreateWordValidator()
        {
            return new WordValidator();
        }
    }
}
